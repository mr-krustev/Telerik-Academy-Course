namespace Matrix.Logic
{
    public class EntryPoint
    {
        static void Main()
        {
            var size = ConsoleInputProvider.ReadMatrixSize();
            var matrix = Matrix.Generate(size,size);
            ConsoleRenderer.PrintMatrix(matrix);
        }
    }
}
