using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
namespace ORPZ_Lab2_LinqToXML
{
    class MainClass
    {
        static List<Address> addresses = new List<Address>()
            {
                new Address(){ Region = "Kyiv", Street = "Grushevskogo", Number = "25"},
                new Address(){ Region = "Kyiv", Street = "Volodymyrska", Number = "2"},
                new Address(){ Region = "Ivano-Frankivsk", Street = "Kyivska", Number = "10"},
                new Address(){ Region = "Odessa", Street = "Frunze", Number = "63" },
                new Address(){ Region = "Uzhgorod", Street = "Korzo", Number = "55" },
                new Address(){ Region = "Kyiv", Street = "Smolenska", Number = "5"},
                new Address(){ Region = "Odessa", Street = "Soborna", Number = "7"},
                new Address(){ Region = "Kyiv", Street = "Solomianska", Number = "27"},
                new Address(){ Region = "Donetsk", Street = "Dekabrystiv", Number = "55"},
                new Address(){ Region = "Ivano-Frankivsk", Street = "Vokzalna", Number = "6"}
            };

        static List<Person> people = new List<Person>()
            {
                new Person(){ Name = "Pavlo", Surname = "Kaschuk", Patronymic = "Oleksandrovych", Address = addresses[0],
                    BirthDay = new DateTime(1995, 12, 5), LicenceNumber = "KX874636"  },
                new Person(){ Name = "Eric", Patronymic = "Davidovich", Surname = "Kituashvili", Address = addresses[1],
                BirthDay = new DateTime(1990, 6, 12), LicenceNumber = "KX653276"},
                new Person(){ Name = "Stanislav", Patronymic = "Olexandrovych", Surname = "Asafev", Address = addresses[2],
                BirthDay = new DateTime(1998, 3, 17), LicenceNumber = "IB9896343"},
                new Person(){ Name = "Kostiantyn", Patronymic = "Oleksandrovych", Surname = "Zarutskyi", Address = addresses[3],
                BirthDay = new DateTime(1989, 1, 27), LicenceNumber = "OC9894357" },
                new Person(){ Name = "Evgeniy", Patronymic = "Pavlovych", Surname = "Dubrovskyi", Address = addresses[4],
                BirthDay = new DateTime(1991, 10, 19), LicenceNumber = "HH6352410"},
                new Person(){ Name = "Tom", Surname = "Hanson", Patronymic = "Oleksandrovych", Address = addresses[5],
                    BirthDay = new DateTime(1995, 2, 18), LicenceNumber = "CE800013"  },
                new Person(){ Name = "Ilya", Patronymic = "Oleksandrovych", Surname = "KickDown", Address = addresses[6],
                BirthDay = new DateTime(1992, 6, 13), LicenceNumber = "MO62500E"},
                new Person(){ Name = "Vadim", Patronymic = "Mykolayovych", Surname = "Luschyk", Address = addresses[7],
                BirthDay = new DateTime(1998, 3, 17), LicenceNumber = "BK444476"},
                new Person(){ Name = "Grygoriy", Patronymic = "Oleksandrovych", Surname = "Zavozin", Address = addresses[8],
                BirthDay = new DateTime(1989, 1, 27), LicenceNumber = "PH0388499" },
                new Person(){ Name = "Dmytro", Patronymic = "Pavlovych", Surname = "Kozakov", Address = addresses[9],
                BirthDay = new DateTime(1991, 10, 19), LicenceNumber = "CX009111"}
                ,
                new Person(){ Name = "Georgiy", Patronymic = "Tumasovych", Surname = "Chivchyan",
                BirthDay = new DateTime(1993, 4, 22), LicenceNumber = "AX8864739" },
                new Person(){ Name = "Arkadiy", Patronymic = "Petrovych", Surname = "Tsaregradtcev",
                BirthDay = new DateTime(1982, 12, 5), LicenceNumber = "CK00657481"}
            };

        static List<Auto> autos = new List<Auto>()
            {
                new Auto(){ Manufacturer = "Porsche", Model = "911 Turbo S", BodyColor = CarBodyColor.Yellow, BodyType = CarBodyType.Coupe,
                ManufactureYear = 2021, Condition = TechnicalCondition.Good, PlateNumber = "HH0911HH", VIN = "PVAG9387738HFK",
                Owners =   { "OC9894357", "MO62500E" }, Permissons =   { "BK444476", "KX653276" } },
                new Auto(){ Manufacturer = "Audi", Model = "RS Q8", BodyColor = CarBodyColor.Green, BodyType = CarBodyType.SUV,
                ManufactureYear = 2020, Condition = TechnicalCondition.Good, PlateNumber = "KA7777HH", VIN = "VAG873829gdhj",
                Owners =  { "KX874636", "KX653276" }},
                new Auto(){ Manufacturer = "BMW", Model = "X5 M", BodyColor = CarBodyColor.Red, BodyType = CarBodyType.SUV,
                ManufactureYear = 2021, Condition = TechnicalCondition.Repair, PlateNumber = "AH8000CK", VIN = "BMWAG03883773JDH",
                Owners =  { "PH0388499" }},
                new Auto(){ Manufacturer = "Ford", Model = "Mustang", BodyColor = CarBodyColor.Blue, BodyType = CarBodyType.Coupe,
                ManufactureYear = 2020, Condition = TechnicalCondition.Totaled, VIN = "FCA84747874USK"},
                new Auto() {Manufacturer = "Mercedes", Model = "E63 S AMG", BodyColor = CarBodyColor.Black, BodyType = CarBodyType.Sedan,
                ManufactureYear = 2018, Condition = TechnicalCondition.Good, PlateNumber = "KA0063AA", VIN = "DML827438927984hdj",
                Owners =  { "BK444476" }},
                new Auto() {Manufacturer = "Mercedes", Model = "C43 AMG", BodyColor = CarBodyColor.Green, BodyType = CarBodyType.Coupe,
                ManufactureYear = 2018, Condition = TechnicalCondition.Good, PlateNumber = "BH0043CC", VIN = "DML827438927984HRE",
                Owners =  { "MO62500E" }},
                new Auto() {Manufacturer = "Mercedes", Model = "E63 S AMG", BodyColor = CarBodyColor.White, BodyType = CarBodyType.Sedan,
                ManufactureYear = 2018, Condition = TechnicalCondition.Good, PlateNumber = "KA2222AA", VIN = "DML827438927984EEE",
                Owners =  { "KX874636", "KX653276" }},
                new Auto() {Manufacturer = "Mercedes", Model = "S400d", BodyColor = CarBodyColor.White, BodyType = CarBodyType.Sedan,
                ManufactureYear = 2018, Condition = TechnicalCondition.Good, PlateNumber = "AO2222AA", VIN = "DML400438927984SSS",
                Owners =  { "CX009111" }},
                new Auto() {Manufacturer = "Audi", Model = "A8 Long", BodyColor = CarBodyColor.Green, BodyType = CarBodyType.Sedan,
                ManufactureYear = 2022, Condition = TechnicalCondition.Good, PlateNumber = "AT2226HI", VIN = "VAG400438927965LL",
                Owners =  { "IB9896343" }},
                new Auto() {Manufacturer = "Audi", Model = "RS 6 Avant", BodyColor = CarBodyColor.Blue, BodyType = CarBodyType.Wagon,
                ManufactureYear = 2021, Condition = TechnicalCondition.Good, VIN = "VAG0997366678990RS" },
                new Auto() {Manufacturer = "Porsche", Model = "Cayenne Turbo GT", BodyColor = CarBodyColor.Red, BodyType = CarBodyType.SUV,
                ManufactureYear = 2022, Condition = TechnicalCondition.Good, VIN = "PVAG680GT8338378" },
                new Auto() {Manufacturer = "Porsche", Model = "Panamera GTS", BodyColor = CarBodyColor.Green, BodyType = CarBodyType.Coupe,
                ManufactureYear = 2020, Condition = TechnicalCondition.Good, PlateNumber = "AT8008KK", VIN = "PVAG680GT8338378",
                Owners =  { "IB9896343", "HH6352410"}}

            };
        public static void Main(string[] args)
        {
            //CreateCarXml("autos");

            //CreatePersonXml("people");
            XDocument xdoc = XDocument.Load("autos.xml");
            //IEnumerable<Auto> selectedCars = SelectCars(xdoc);

            XDocument xdoc2 = XDocument.Load("people.xml");
            //IEnumerable<Person> selectedPeople = SelectPeople(xdoc2);



            //GetFilteredOrderedCars2(xdoc);

            //DeleteSomeCars(xdoc, "2020");
            //var query = xdoc2.Descendants("people").Where(z => z.Element(nameof(Person.LicenceNumber)).Value.Equals(".."));

            //JoinCarsWithOwners(xdoc, xdoc2);
            //AddNewElement(xdoc, "CarJacked");
            UpdateCars(xdoc, "PVAG9387738HFK");
            //GetGroupedByBodyTypeCars(xdoc);
            XDocument gDoc = XDocument.Load("groupedCars.xml");
            OrderGroups(gDoc.Root);
            gDoc.Save("groupedCars1.xml");
            
        }

        public static void CreateCarXml(string FileName)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.Async = true;
            using (XmlWriter writer = XmlWriter.Create(FileName + ".xml", settings))
            {
                writer.WriteStartElement("autos");

                foreach (Auto auto in autos)
                {
                    writer.WriteStartElement("auto");
                    writer.WriteElementString(nameof(Auto.Manufacturer), auto.Manufacturer);
                    writer.WriteElementString(nameof(Auto.Model), auto.Model);
                    writer.WriteElementString(nameof(Auto.BodyColor), auto.BodyColor.ToString());
                    writer.WriteElementString(nameof(Auto.BodyType), auto.BodyType.ToString());
                    writer.WriteElementString(nameof(Auto.ManufactureYear), auto.ManufactureYear.ToString());
                    writer.WriteElementString(nameof(Auto.Condition), auto.Condition.ToString());
                    writer.WriteElementString(nameof(Auto.PlateNumber), auto.PlateNumber);
                    writer.WriteElementString(nameof(Auto.VIN), auto.VIN);
                    writer.WriteStartElement(nameof(Auto.Owners));
                    foreach (var owner in auto.Owners)
                    {
                        writer.WriteElementString("owner", owner);
                    }
                    writer.WriteEndElement();
                    writer.WriteEndElement();

                }
                writer.WriteEndElement();
                
            }
        }

        public static void CreatePersonXml(string FileName)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.Async = true;
            using (XmlWriter writer = XmlWriter.Create(FileName + ".xml", settings))
            {
                writer.WriteStartElement("people");
                foreach (Person owner in people)
                {
                    writer.WriteStartElement("person");
                    writer.WriteElementString(nameof(Person.Surname), owner.Surname);
                    writer.WriteElementString(nameof(Person.Name), owner.Name);
                    writer.WriteElementString(nameof(Person.Patronymic), owner.Patronymic);
                    writer.WriteElementString(nameof(Person.BirthDay), owner.BirthDay.ToShortDateString());
                    writer.WriteElementString(nameof(Person.LicenceNumber), owner.LicenceNumber);
                    writer.WriteElementString(nameof(Address.Region), owner.Address?.Region ?? "Non-Registered");
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }
        }

        // 1
        public static IEnumerable<Auto> SelectCars(XDocument document)
        {

            var query = document.Descendants("auto").Select(a => new Auto()
            {
                Manufacturer = a.Element(nameof(Auto.Manufacturer)).Value,
                Model = a.Element(nameof(Auto.Model)).Value,
                BodyColor = (CarBodyColor)Enum.Parse(typeof(CarBodyColor), a.Element(nameof(Auto.BodyColor)).Value, true),
                BodyType = (CarBodyType)Enum.Parse(typeof(CarBodyType), a.Element(nameof(Auto.BodyType)).Value, true),
                ManufactureYear = int.Parse(a.Element(nameof(Auto.ManufactureYear)).Value),
                Condition = (TechnicalCondition)Enum.Parse(typeof(TechnicalCondition), a.Element(nameof(Auto.Condition)).Value, true),
                PlateNumber = a.Element(nameof(Auto.PlateNumber)).Value,
                VIN = a.Element(nameof(Auto.VIN)).Value
                //Owners = a.Descendants(nameof(Auto.Owners)).Select(o => o.Element("owner").Value)?.ToList()
            }).ToList();
            return query;
        }

        //2
        public static IEnumerable<Person> SelectPeople(XDocument document)
        {
            var query = document.Descendants("person")
                .Select(p => new Person()
                {
                    Surname = p.Element(nameof(Person.Surname)).Value,
                    Name = p.Element(nameof(Person.Name)).Value,
                    Patronymic = p.Element(nameof(Person.Patronymic)).Value,
                    BirthDay = Convert.ToDateTime(p.Element(nameof(Person.BirthDay)).Value),
                    LicenceNumber = p.Element(nameof(Person.LicenceNumber)).Value,
                    Address = new Address() { Region = p.Element(nameof(Address.Region)).Value }

                }
                ).ToList();
            return query;
        }

        //3
        public static IEnumerable<Auto> GetFilteredOrderedCars(XDocument document, string manufacturer)
        {

            var query = document.Descendants("auto")
                .Where(a => a.Element(nameof(Auto.Manufacturer)).Value.Equals(manufacturer))
                .OrderBy(a => a.Element(nameof(Auto.Manufacturer)).Value)
                .Select(a => new Auto()
                {
                    Manufacturer = a.Element(nameof(Auto.Manufacturer)).Value,
                    Model = a.Element(nameof(Auto.Model)).Value,
                    BodyColor = (CarBodyColor)Enum.Parse(typeof(CarBodyColor), a.Element(nameof(Auto.BodyColor)).Value, true),
                    BodyType = (CarBodyType)Enum.Parse(typeof(CarBodyType), a.Element(nameof(Auto.BodyType)).Value, true),
                    ManufactureYear = int.Parse(a.Element(nameof(Auto.ManufactureYear)).Value),
                    Condition = (TechnicalCondition)Enum.Parse(typeof(TechnicalCondition), a.Element(nameof(Auto.Condition)).Value, true),
                    PlateNumber = a.Element(nameof(Auto.PlateNumber)).Value,
                    VIN = a.Element(nameof(Auto.VIN)).Value,
                    Owners = a.Descendants(nameof(Auto.Owners)).Select(o => o.Element("owner").Value).ToList()
                }).ToList();

            return query;
        }

        //4
        public static void GetGroupedByBodyTypeCars(XDocument document)
        {
            XDocument query = new XDocument(new XElement("GroupedAutos",
                document.Descendants("autos").Elements()
                .GroupBy(g => g.Element(nameof(Auto.BodyType)).Value)
                .Select(g => new XElement("Group", new XAttribute(nameof(Auto.BodyType), g.Key),
                g.Elements().Select(p => new XElement(p))))));
            query.Save(fileName: "groupedCars.xml");
            
        }


        //5
        public static void JoinCarsWithOwners(XDocument AutosDoc, XDocument PeopleDoc)
        {
            var query =
                AutosDoc.Descendants("auto")
                .SelectMany(x => x.Descendants(nameof(Auto.Owners)).Elements("owner").Select(e => e.Value),
                (x, p) => new { Automobile = x, Owner = p });

            var xDocument = new XElement("AutosJoinOwners",
                query.Join(PeopleDoc.Descendants("people"),
                a => a.Owner,
                p => p.Element("person").Element(nameof(Person.LicenceNumber)).Value,
                (a, p) => new XElement("Auto", new XElement(a.Automobile), new XElement(p.Element("person")))

                ));
            xDocument.Save("Join.xml");

        }
        //6
        public static void AddNewElement(XDocument xDocument, string fieldName)
        {
            foreach (var rec in xDocument.Descendants("auto"))
            {
                rec.Add(new XElement(fieldName, "false"));
            }
            xDocument.Save("autos.xml");
        }

        //7
        public static void UpdateCars(XDocument xDocument, string filter)
        {
           var query =  xDocument.Descendants("auto")?.Where(x => x.Element(nameof(Auto.VIN)).Value.Equals(filter)).FirstOrDefault();
            if(query != null)
            query.Element("CarJacked").Value = "true";
            xDocument.Save("autos.xml");
        }
        //8
        public static void DeleteCarsByYear(XDocument document, string year)
        {
            document.Elements("auto").Elements()
                .Where(e => e.Element(nameof(Auto.ManufactureYear)).Value == year)
                .Remove();
            document.Save(fileName: "autos.xml");
        }

        //9
        public static void OrderGroups(XElement node)
        { 

            node.ReplaceNodes(node.Elements("GroupedAutos").OrderBy(x => x?.Element("Group").Attribute(nameof(Auto.BodyType))));
            
            foreach(var childNode in node.Elements("Node"))
                OrderGroups(childNode);
        }
    }
}