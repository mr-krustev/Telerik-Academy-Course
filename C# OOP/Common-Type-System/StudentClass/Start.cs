namespace StudentClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Students;

    public class Start
    {
        static void Main()
        {
            Student gosho = new Student("Gosho", "Stoqnov", "Ivanov");
            gosho.PermanentAdress = "Kisela street, Golemograd";
            gosho.SocialSecurtiyNumber = "222-222";
            gosho.MobilePhone = "359 999";
            gosho.University = UniversityName.UNWE;
            gosho.Faculty = FacultyName.FacultyOfBusinessAndEconomics;
            gosho.Specialty = SpecialtyType.Finance;

            Student pesho = new Student("Pesho", "Katranov", "Gerganov");
            pesho.PermanentAdress = "Sladka street, Golemograd";

            Console.WriteLine("pesho == gosho : {0}",pesho == gosho);
            Console.WriteLine();

            Console.WriteLine("pesho != gosho : {0} ", pesho != gosho);
            Console.WriteLine();

            Console.WriteLine("pesho.Equals(gosho) : {0}", pesho.Equals(gosho));
            Console.WriteLine();

            Console.WriteLine(pesho);
            Console.WriteLine();
            Console.WriteLine(gosho);
            Console.WriteLine();

            Console.WriteLine("pesho hashcode : {0}",pesho.GetHashCode());
            Console.WriteLine();
            Console.WriteLine("gosho hashcode : {0}",gosho.GetHashCode() );
            Console.WriteLine();

            var rebornGosho = gosho.Clone() as Student;

            Console.WriteLine(rebornGosho.CompareTo(gosho));    // 0 means they are equal which is logical since... aaah Attack of the Clones!
            

        }
    }
}
