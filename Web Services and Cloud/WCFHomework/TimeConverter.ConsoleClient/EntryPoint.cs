namespace TimeConverter.ConsoleClient
{
    using TimeConverter;
    using System;

    public class EntryPoint
    {
        public static void Main()
        {
            var service = new TimeConverterServiceClient();

            var result = service.GetDayOfWeek(DateTime.Now);

            service.Close();

            Console.WriteLine(result);
        }
    }
}
