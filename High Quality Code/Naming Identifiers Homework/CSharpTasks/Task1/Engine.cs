namespace CSharpTasks
{
    using System;

    public class Engine
    {
        public static void Main()
        {
            Converter converter = new Converter();
            Console.WriteLine(converter.GetString(true));
        }
    }
}