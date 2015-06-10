namespace GSMClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Globalization;

    public class Call
    {
        #region Problem 8. Calls
        private string date;
        private string time;
        private string dialedPhoneNumber;
        private int duration;

        public Call(DateTime dateAndTime, string dialedPhoneNumber, int duration)
        {
            this.date = string.Format("{0:dd.MM.yyyy}", dateAndTime);
            this.time = string.Format("{0:H:mm}", dateAndTime);
            this.dialedPhoneNumber = dialedPhoneNumber;
            this.duration = duration;
        }

        public string Date
        {
            get { return this.date; }
        }

        public string Time
        {
            get { return this.time; }
        }

        public string DialedPhoneNumber
        {
            get { return this.dialedPhoneNumber; }
        }

        public int Duration
        {
            get { return this.duration; }
        }
        #endregion

        #region Problem 11. Call price
        public static double Price(Call call, double pricePerMinute)
        {
            int minutes = call.duration / 60;

            if (call.duration % 60 != 0)
            {
                minutes++;
            }

            return minutes * pricePerMinute;
        }
        #endregion

        public override string ToString()
        {
            return string.Format("Date: {0}, Time: {1}, Dialed number: {2},Duration: {3}s", date, time, dialedPhoneNumber, duration);
        }
    }
}
