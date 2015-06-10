namespace Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Reflection;

    [Version(VersionAttribute.Type.Class, "TestAttribute", "2.11")] // Problem 11. Version attribute
    class Start
    {
        
        static void Main()
        {
            

            Matrix<int> testMatrix = new Matrix<int>(4, 3); 

            testMatrix[1, 1] = 5; 
            Console.WriteLine("Matrix[1,1] = {0}", testMatrix[1, 1]);

            Matrix<double> testMatrix2 = new Matrix<double>(new double[,] { { 1.2, 2.3, 3.4 }, { 1.2, 2.3, 3.4 } });
            Console.WriteLine("Another Matrix[1,1] = {0}", testMatrix2[1, 1]); 

            Matrix<int> firstMatrix = new Matrix<int>(3, 3); 
            Matrix<int> secondMatrix = new Matrix<int>(3, 3);

            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Cols; j++)
                {
                    firstMatrix[i, j] = (i + 3) * (j + 1) + 5;
                    secondMatrix[i, j] = (i + 1) * (j + 2);
                }
            }

            Console.WriteLine("Matrix 1:\n{0}", firstMatrix);
            Console.WriteLine("Matrix 2:\n{0}", secondMatrix);

            Matrix<int> resultOfAddition = firstMatrix + secondMatrix;
            Matrix<int> resultOfSubtraction = firstMatrix - secondMatrix;
            Matrix<int> resultOfMultiplication = firstMatrix * secondMatrix;

            Console.WriteLine("Matrix1 + Matrix2 =\n{0}", resultOfAddition);
            Console.WriteLine("Matrix1 - Matrix2 =\n{0}", resultOfSubtraction);
            Console.WriteLine("Matrix1 * Matrix2 =\n{0}", resultOfMultiplication);

            if (firstMatrix)
            {
                Console.WriteLine("{0} does not contain zero elements", firstMatrix);
            }
            else
            {
                Console.WriteLine("{0} contains zero element(s)");
            }

            firstMatrix[0, 0] = 0;

            if (firstMatrix)
            {
                Console.WriteLine("{0} does not contain zero elements", firstMatrix);
            }
            else
            {
                Console.WriteLine("{0} contains zero element(s)", firstMatrix);
            }

            var attr = typeof(Start).GetCustomAttributes<VersionAttribute>();

            foreach (var attribute in attr)                      // Problem 11. Version attribute
            {
                Console.WriteLine("{0}: {1}     Version: {2}",
                    attribute.Component, attribute.Name, attribute.Version);
            }

        }
    }
    
}
