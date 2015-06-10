namespace GSMClass
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Globalization;
    using System.Threading;
    using GSMClass;

    class UserInterface
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("fr-FR");

            Call callingEmo = new Call(DateTime.Now, "+35988877765", 299);

            Console.WriteLine("{0:C}", Call.Price(callingEmo, 0.52));

            GSMCallHistoryTest.Test();
            Console.WriteLine();
            GSMTest.TestGSMClass(5);
        }
    }
}

