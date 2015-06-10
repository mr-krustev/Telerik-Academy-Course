using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    public class Person
    {
        private string name;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name", "Invalid name!");
                }
                this.name = value;
            }
        }

        public int? Age { get; set; }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine("Name: " + this.name);
            if (this.Age == null)
            {
                result.AppendLine("Age: None");
            }
            else
            {
                result.AppendLine("Age: " + this.Age);
            }

            return result.ToString();
        }
    }
}
