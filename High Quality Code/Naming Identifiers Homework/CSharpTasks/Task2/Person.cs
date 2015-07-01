namespace CSharpTasks
{
    public class Person
    {
        private string name;
        private int age;

        public Person(Gender gender, string name, int age)
        {
            this.Gender = gender;
            this.Name = name;
            this.Age = age;
        }

        public Gender Gender { get; private set; }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }
    }
}