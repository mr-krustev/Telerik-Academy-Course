namespace GSMClass
{
    using System;

    public class Battery
    {
        #region Problem 1. Define Class & Problem 3. Enumeration & Problem 5. Properties
        private string model;
        private int? hoursIdle;
        private int? hoursTalk;
        private BatteryTypes batteryType;

        public enum BatteryTypes { Li_Ion, Li_Poly, NiMH, NiCD }; // Problem 3. Enumeration

        public string Model
        {
            get { return this.model; }
            set
            {
                if (value.Length > 0)
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }

        public BatteryTypes BatteryType
        {
            get { return batteryType; }
            set
            {
                if (Enum.IsDefined(typeof(BatteryTypes), value))
                {

                    this.batteryType = value;
                }
                else
                {
                    throw new Exception("Invalid battery type!");
                }
            }
        }

        public int? HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid idle hours battery lifespan.");
                }
                this.hoursIdle = value;
            }
        }

        public int? HoursTalk
        {

            get { return this.hoursTalk; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid talking hours battery lifespan.");
                }
                this.hoursTalk = value;
            }
        }

        //public string Model { get; set ;}
        //public double HoursIdle { get; set; }
        //public double HoursTalk { get; set; }
        #endregion

        #region Problem 2. Constructors
        public Battery()
        {
        }

        public Battery(string model)
        {
            this.Model = model;
        }

        public Battery(string model, BatteryTypes batteryType)
        {
            this.Model = model;
            this.BatteryType = batteryType;
        }

        public Battery(string model, int? hoursTalk = null, int? hoursIdle = null)
        {
            this.HoursIdle = hoursIdle;
        }


        public Battery(string model, BatteryTypes batteryType, int? hoursTalk = null, int? hoursIdle = null)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }
        #endregion

        #region Problem 4. ToString
        public override string ToString()
        {
            return string.Format("{0}, {1},  idle lifespan: {2}h, talking lifespan: {3}h", this.model, this.batteryType, this.hoursIdle, this.hoursTalk);
        }
        #endregion
    }
}

