namespace GSMClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GSMTest
    {
        #region Problem 7. GSM test
        public static void TestGSMClass(int gsmCount)
        {
            GSM[] gsmArray = new GSM[gsmCount];

            for (int i = 0; i < gsmCount; i++)
            {
                string GSMModel = "Samsung " + 6 + i;
                gsmArray[i] = new GSM(GSMModel, "Samsung", 220 + 50*i, new Battery("BV-BH", Battery.BatteryTypes.Li_Poly, 220 + i, 20 + i), new Display(3.4 + i/5.0, 16777231));
            }

            for (int i = 0; i < gsmCount; i++)
            {
                Console.WriteLine(gsmArray[i]);
            }

            Console.WriteLine(GSM.IPhone4S);
        }
        #endregion
    }
}
