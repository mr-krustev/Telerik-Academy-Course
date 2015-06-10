/*
Problem 12. Call history test

Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
Create an instance of the GSM class.
Add few calls.
Display the information about the calls.
Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
Remove the longest call from the history and calculate the total price again.
Finally clear the call history and print it.
*/

namespace GSMClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace GSMClass
    {
        class GSMCallHistoryTest
        {
            #region Problem 12. Call history test
            public static void Test()
            {
                GSM gsm = new GSM("Samsung 60", "Samsung");
                double totalPrice = 0.00;
                Call longestCall = new Call(DateTime.Now, " ", 0);

                for (int i = 0; i < 5; i++)
                {
                    gsm.AddCall(new Call(DateTime.Now, "+35988887777", 60 + 10 * i));
                }

                for (int i = 0; i < gsm.CallHistory.Count; i++)
                {
                    totalPrice += Call.Price(gsm.CallHistory[i], 0.37);

                    if (gsm.CallHistory[i].Duration > longestCall.Duration)
                    {
                        longestCall = gsm.CallHistory[i];
                    }
                }

                Console.WriteLine("First total price: {0:C}", totalPrice);
                totalPrice = 0;
                gsm.DeleteCall(longestCall);

                for (int i = 0; i < gsm.CallHistory.Count; i++)
                {
                    totalPrice += Call.Price(gsm.CallHistory[i], 0.37);
                }

                Console.WriteLine("Second total price: {0:C}", totalPrice);

                for (int i = gsm.CallHistory.Count - 1; i >= 0; i--)
                {
                    Console.WriteLine(gsm.CallHistory[i]);
                    gsm.DeleteCall(gsm.CallHistory[i]);
                }

            }
            #endregion
        }
    }
}