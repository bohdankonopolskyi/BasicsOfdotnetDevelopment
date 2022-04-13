using System;
using System.Collections.Generic;
using System.Linq;
namespace ORPZ_Lab1_LinQ
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
                BirthDay = new DateTime(1991, 10, 19), LicenceNumber = "CX009111"},
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
            //Проста вибірка, отрмати колекцію Автомобілі
            getAllAutos(autos);


            //Фільтрація. Отримати колекцію автомобілів випущених після 2019 року.
            getAfterYear(autos, 2019);


            //Отримати колекцію груп по технічному стану автомобілів
            getTecnicalGroups(autos);


            //Отримати колекцію груп автомобілів за роком випуску. Та відсортувати в групах спочатку за виробником, потім за моделлю
            getSortedGroups(autos);


            //Використання SkipWhile. Пропустити перші автомобілі, поки зустрічаються в Доброму технічному стані
            getWithSkiped(autos, TechnicalCondition.Good);

            //Чи існують в колекції незареєстровані автомобілі
            doesExistUnregistered(autos);

            //Чи всі автомобілі в колекції мають номер з Регіоном "АА"
            isAllWithRegion(autos, "AA");


            //декартовий добуток колекцій Автомобілі і Власники
            getCartesian(autos, people);

            //Inner Join зʼєднання Автомобілів та Власників за ключем Номер посвідчення власника 
            getJoinOfAutoOwner(autos, people);

            //Використання SelectMany для сворення нової колекції один до багатьох: пари Автомобіль та ідентифікатор власника
            getInnerJoin(autos, people);


            //Join, GroupBy, First, Агрегатні функції. Вивети регіони за першою реєстрацією з найбільшою кількістю авто
            getMaxCountInRegion();

            //Concat Обʼєднання двох запитів. Перший повертає згруповану і відсортовану першу половину вхідної колекції
            //Другий повертає згруповану і відсортовану за спаданням другу половину вхідної колекції.
            GetConcat();

            //Left outer join колекцій Власники та Автомобілі
            GetLeftRightJoins(autos, people);

        }

        static void getAllAutos(IEnumerable<Auto> autos)
        {
            Console.WriteLine("Проста вибірка. Отримати всі елементи колекції");
            var q1 = from auto in autos
                     select auto;
            foreach (var auto in q1)
                Console.WriteLine(auto.ToString());
        }

        static void getAfterYear(IEnumerable<Auto> autos, int year)
        {
            Console.WriteLine("Проста фільтрація. Отримати Назву, Модель, Рік випуску та Номерний знак автомобілів, що випущені після 2019р");
            var q2 = autos.Where(y => y.ManufactureYear > year)
                .Select(a => new { Brand = a.Manufacturer, Model = a.Model, Year = a.ManufactureYear, Number = a.PlateNumber });
            foreach (var auto in q2)
            {
                Console.WriteLine($"Manufacturer = {auto.Brand}, Model = {auto.Model},\n" +
                $" Year = {auto.Year}, Plate = {auto.Number}\n");
            }
        }

        static void getTecnicalGroups(IEnumerable<Auto> autos)
        {
            Console.WriteLine("Простe групування. Отримати Назву, Модель, Рік випуску та Технічний стан, згруповані по технічному стану");
            var q3 = autos.GroupBy(g => g.Condition).Select(g => new
            {
                Key = g.Key,
                Amount = g.Count(),
                Vechiles = g.Select(a => new { Brand = a.Manufacturer, Model = a.Model, Condition = a.Condition, Number = a.PlateNumber })
            });
            foreach (var group in q3)
            {
                Console.WriteLine($"Group: {group.Key}, Amount of autos in Group: {group.Amount}");
                foreach (var auto in group.Vechiles)
                {
                    Console.WriteLine($"Manufacturer = {auto.Brand}, Model = {auto.Model},\n" +
                $" Condition = {auto.Condition}, Plate = {auto.Number}\n");
                }
            }
        }

        static void getSortedGroups(IEnumerable<Auto> autos)
        {
            Console.WriteLine("Сортування груп та вмісту груп");
            var q4 = autos.GroupBy(g => g.ManufactureYear).Select(g => new
            {
                Key = g.Key,
                Amount = g.Count(),
                Vechiles = g.Select(a => new { Brand = a.Manufacturer, Model = a.Model, Condition = a.Condition, Number = a.PlateNumber })
                .OrderBy(n => n.Brand).ThenBy(m => m.Model)
            }).OrderBy(g => g.Key);

            foreach (var group in q4)
            {
                Console.WriteLine($"Group: {group.Key}, Amount of autos in Group: {group.Amount}");
                foreach (var auto in group.Vechiles)
                {
                    Console.WriteLine($"Manufacturer = {auto.Brand}, Model = {auto.Model},\n" +
                $" Condition = {auto.Condition}, Plate = {auto.Number}\n");
                }
            }
        }

        static void getWithSkiped(IEnumerable<Auto> autos, TechnicalCondition condition)
        {
            Console.WriteLine("Використання SkipWhile");
            IEnumerable<Auto> q5 = autos.SkipWhile(x => x.Condition == condition);
            foreach (var auto in q5)
            {
                Console.WriteLine(auto.ToString());
            }
        }

        static void doesExistUnregistered(IEnumerable<Auto> autos)
        {
            Console.WriteLine("Використання Any");
            bool q6 = autos.Any(x => x.PlateNumber is null);

            Console.WriteLine($"Type: {q6.GetType()}, Value: {q6}");
        }

        static void isAllWithRegion(IEnumerable<Auto> autos, string reg)
        {
            var q7 = autos.All(x => x.PlateNumber.StartsWith(reg));
        }

        static void getCartesian(IEnumerable<Auto> autos, IEnumerable<Person> people)
        {
            Console.WriteLine("Використаня Декартового добутку");
            var q8 = from a in autos
                     from p in people
                     select new
                     {
                         Manufacturer = a.Manufacturer,
                         Model = a.Model,
                         Name = p.Name,
                         Surname = p.Surname
                     };
            foreach (var rec in q8)
            {
                Console.WriteLine($"Brand: {rec.Manufacturer}, Model: {rec.Model}, Owner: {rec.Name}, {rec.Surname}");
            }
        }

        static void getJoinOfAutoOwner(IEnumerable<Auto> autos, IEnumerable<Person> people)
        {
            Console.WriteLine("Using of Inner Join. Отримати пари Автомобіль-Власник");
            var q9 = from p in people
                     from a in autos
                     where a.Owners != null
                     from o in a.Owners
                     where o == p.LicenceNumber
                     select new
                     {
                         Manufacturer = a.Manufacturer,
                         Model = a.Model,
                         Name = p.Name,
                         Surname = p.Surname
                     };
            foreach (var rec in q9)
            {
                Console.WriteLine($"Auto: {rec.Manufacturer} {rec.Model}, Owner: {rec.Name} {rec.Surname}");
            }
        }


        static void getInnerJoin(IEnumerable<Auto> autos, IEnumerable<Person> people)
        {
            var q10 = autos.SelectMany(x => x?.Owners.DefaultIfEmpty("-"),
                    (x, a) => new { Automobile = x, OwnerNum = a });

            //GroupJoin зʼєднати колекції за ключем та згрупувати отриману колекцію
            Console.WriteLine("Using of  GroupJoin. Згрупувати автомобілі за власниками");
            var q11 = people.GroupJoin(q10,
                p => p.LicenceNumber,
                o => o.OwnerNum,
                (p, auto) => new
                {
                    Owner = p.Surname,
                    Automobiles = auto
                });
            foreach (var rec in q11)
            {
                Console.WriteLine($" {rec.Owner}");
                foreach (var a in rec.Automobiles)
                {
                    Console.WriteLine($"{a.Automobile.ToString()}");
                }
            }
        }

        static void getMaxCountInRegion()
        {
            Console.WriteLine("Join, GroupBy, Агрегатні функції. Вивети регіони з найбільшою кількістю авто");
            var q12 = autos.Where(a => a.Owners.Any())
                .Join(people,
                a => a.Owners.First(),
                p => p.LicenceNumber,
                (a, p) =>

                        new
                        {
                            Region = p?.Address?.Region ?? "-",
                            Automobiles = a
                        }
                )
                .GroupBy(g => g.Region).Select(g => new { Group = g.Key, Amount = g.Count() });

            var q121 = q12.Where(g => g.Amount == q12.Max(a => a.Amount));
            foreach (var rec in q121)
            {
                Console.WriteLine($"Maximal autos in region: {rec.Group}, {rec.Amount}");
            }
        }

        static void GetConcat()
        {
            //Concat Обʼєднання двох запитів. Перший повертає згруповану і відсортовану першу половину вхідної колекції
            //Другий повертає згруповану і відсортовану за спаданням другу половину вхідної колекції.
            Console.WriteLine("Concat. Вивети регіони з найбільшою кількістю авто");
            var q13 = autos.Take(autos.Count() / 2)
                .GroupBy(g => g.BodyType)
                .Select(g => new { Group = g.Key, Values = g.Select(a => a) })
                .OrderBy(x => x.Group.ToString())
                .Concat(autos.Skip(autos.Count() / 2)
                .GroupBy(g => g.BodyType)
                .Select(g => new { Group = g.Key, Values = g.Select(a => a) })
                .OrderByDescending(x => x.Group.ToString()));

            foreach (var rec in q13)
            {
                Console.WriteLine($" {rec.Group}");
                foreach (var a in rec.Values)
                {
                    Console.WriteLine($"{a.ToString()}");
                }
            }
        }
        static void GetLeftRightJoins(IEnumerable<Auto> autos, IEnumerable<Person> people)
        {
            var q10 = autos.SelectMany(x => x?.Owners.DefaultIfEmpty("-"),
                        (x, a) => new { Automobile = x, OwnerNum = a });

            var q14 = from person in people
                      join auto in q10 on person.LicenceNumber equals auto.OwnerNum into temp
                      from subauto in temp.DefaultIfEmpty()
                      select new
                      {
                          Owner = person,
                          Automobile = subauto?.Automobile.Manufacturer ?? "-"
                      };
            foreach (var rec in q14)
            {
                Console.WriteLine($"{rec.Owner.ToString()}, {rec.Automobile}");
            }

            //Right outer Join колекцій Власники та Автомобілі
            var q15 = from auto in q10
                      join person in people on auto.OwnerNum equals person.LicenceNumber into temp
                      from subperson in temp.DefaultIfEmpty()
                      select new
                      {
                          Automobile = auto.Automobile,
                          Owner = subperson?.Surname ?? "Not registered"
                      };
            foreach (var rec in q15)
            {
                Console.WriteLine($"{rec.Owner}, {rec.Automobile.Model}");
            }
        }
    }


}
