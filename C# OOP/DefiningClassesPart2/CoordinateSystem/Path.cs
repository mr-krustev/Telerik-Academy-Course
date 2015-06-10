//Problem 4. Path

//Create a class Path to hold a sequence of points in the 3D space.
//Create a static class PathStorage with static methods to save and load paths from a text file.
//Use a file format of your choice.

namespace CoordinateSystem
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Path
    {
        private List<Point3D> pathOfPoints;

        public List<Point3D> PathOfPoints
        {
            get { return this.pathOfPoints; }
            set { this.pathOfPoints = value; }
        }
    }

    static class PathStorage
    {
        public static void FileRead()
        {
            StreamReader readFile = new StreamReader(@"..\..\PathOfPoints.txt");
            Path path = new Path();
            List<Point3D> allPoints = new List<Point3D>();

            using (readFile)
            {
                while (readFile.ReadLine() != null)
                {
                    int[] currentLine = readFile.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

                    allPoints.Add(new Point3D(currentLine[0], currentLine[1], currentLine[2]));
                }
            }
            path.PathOfPoints = allPoints;
        }

        public static void FileSave()
        {
            Console.WriteLine(@"Enter a folder or a file directory <e.g. c:\temp\MyTest.txt or c:\temp >: ");

            string path = Console.ReadLine();
            if (!File.Exists(path))
            {
                Console.WriteLine("Enter name for your text file: ");
                string fileName = path + "\\" + Console.ReadLine() + ".txt";

                
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    Console.WriteLine("Enter 3 numbers separated by space for your points. Write \"END\" to exit.");
                    string input = Console.ReadLine();
                    while (input != "END")
                    {
                        sw.WriteLine(input);

                        Console.WriteLine("Enter 3 numbers separated by space for your points. Write \"END\" to exit.");
                        input = Console.ReadLine();
                    }
                }
            }
        }
    }
}
