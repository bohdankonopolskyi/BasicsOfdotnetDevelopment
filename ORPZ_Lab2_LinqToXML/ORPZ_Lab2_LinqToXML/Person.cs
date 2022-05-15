using System;
namespace ORPZ_Lab2_LinqToXML

{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirthDay { get; set; }
        public Address Address { get; set; }
        public string LicenceNumber { get; set; }

        public Person()
        {
        }
        public override string ToString()
        {
            return string.Format($"Name={Name}, Patronymic={Patronymic}, Surname={Surname}, " +
                $"Birthday={BirthDay.ToShortDateString()}, Licence Number={LicenceNumber}\n " );
        }
    }
}
