namespace GSMClass
{
    using System;
    using System.Collections.Generic;
    using GSMClass;

    public class GSM
    {
        #region Problem 1. Define Class & Problem 5. Properties & Problem 9. Call history
        private string model;
        private string manufacturer;
        private double? price;           // all unknown data should be null, thus the '?'
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (value.Trim().Length > 0)
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentNullException("Model is either blank space or null.");
                }
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value.Length > 0)
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new ArgumentNullException("Manufacturer is either blank space or null.");
                }
            }
        }

        public double? Price
        {
            get { return this.price; }
            set
            {
                if (value < 0 || value == null)
                {
                    throw new Exception("Invalid price.");

                }
                this.price = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (value.Length > 0)
                {
                    this.owner = value;
                }
                else
                {
                    throw new ArgumentNullException("Owner is either a blank space or null.");
                }
            }
        }

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
        }

        #endregion      // usually properties go after constructors, but for this problem will do it this way

        #region Problem 2. Constructors
        public GSM(string model, string manufacturer)
        {
            this.model = Model;
            this.manufacturer = Manufacturer;
        }

        public GSM(string model, string manufacturer, double price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
        }

        public GSM(string model, string manufacturer, Battery battery)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.battery = battery;
        }

        public GSM(string model, string manufacturer, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.display = display;
        }

        public GSM(string model, string manufacturer, double? price = null, Battery battery = null, Display display = null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.battery = battery;
            this.display = display;
        }
        #endregion

        #region Problem 4. ToString
        public override string ToString()
        {
            return string.Format(
    @"Owner: {0,-5}

Model: {1, 5}
Manufacturer: {2,5}

Battery: {3, 5}
Display: {4, 5}

Price: {5,5:C}
{6}
",
                this.owner == null ? "None" : this.owner,
                this.model,
                this.manufacturer,
                this.battery,
                this.display,
                this.price,
                new string('-', 40)
                );
        }
        #endregion

        #region Problem 6. Iphone4S
        //Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
        // http://www.mobileshop.eu/mobile-phones/apple/iphone-4s-8gb/

        private static GSM iPhone4S = new GSM("iPhone 4S 8GB Black", "Apple", 292.00,
            new Battery("Non-removable Li-Po 1432 mAh", Battery.BatteryTypes.Li_Poly, 8, 220),
            new Display(3.5, 16777216));

        public static GSM IPhone4S
        {
            get { return iPhone4S; }
        }

        #endregion

        #region Problem 10. Add/Delete Calls + bonus
        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            this.callHistory.Remove(call);
        }
        #endregion
    }
}