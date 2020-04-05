using System;

namespace Casting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Passport passport = new Passport() { Name = "Damian", Code = "AR-45.3434fd-AA", Country = "Argentina" };
            BasicData basicData = new BasicData() { Name = "Javier", Number = "36.543.198" };

            /* Implicit conversion */
            BasicData basicDataCasting = passport;

            Console.WriteLine("BASIC DATA");
            Console.WriteLine($"Name: {basicDataCasting.Name}, Number: {basicDataCasting.Number}");

            Console.WriteLine();



            /* Explicit conversion, I should use (destination data type)  */
            Passport passportCasting = (Passport)basicData;

            Console.WriteLine("PASSPORT");
            Console.WriteLine($"Name: {passportCasting.Name}, Code: {passportCasting.Code}, Country: {passportCasting.Country}");

            Console.ReadLine();
        }
    }

    public class Passport
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Code { get; set; }

        /* Define implicit casting */
        public static implicit operator BasicData(Passport passport)
        {
            return new BasicData()
            {
                Name = passport.Name,
                Number = passport.Code
            };
        }
    }

    public class BasicData
    {
        public string Name { get; set; }
        public string Number { get; set; }

        /* Define explicit casting */
        public static explicit operator Passport(BasicData basicData)
        {
            return new Passport()
            {
                Name = basicData.Name,
                Code = basicData.Number
            };
        }
    }
}

/* Output

BASIC DATA
Name: Damian, Number: AR-45.3434fd-AA

PASSPORT
Name: Javier, Code: 36.543.198, Country:

 */
