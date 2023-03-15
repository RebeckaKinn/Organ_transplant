namespace Organ_transplant
{
    internal class Program
    {
        public class Person
        {
            public string? Name { get; set; }
            public int Kidneys { get; set; }
            public string? BloodType { get; set; }
            public bool Healthy { get; set; }
            public bool Donate { get; set; }
        }
        public class People
        {
            public List<Person> arrayList = new List<Person>();

            public People()
            {
                CreateArray();
            }

            public void CreateArray()
            {
                arrayList.Add(new Person { Name = "Jay-Z", Kidneys = Convert.ToInt32(2), BloodType = "A", Healthy = Convert.ToBoolean(true), Donate = Convert.ToBoolean(false) });
                arrayList.Add(new Person { Name = "Madonna", Kidneys = Convert.ToInt32(2), BloodType = "B", Healthy = Convert.ToBoolean(true), Donate = Convert.ToBoolean(false) });
                arrayList.Add(new Person { Name = "Ole Ivars", Kidneys = Convert.ToInt32(2), BloodType = "A", Healthy = Convert.ToBoolean(true), Donate = Convert.ToBoolean(false) });
            }


        }

        static void Accident(List<Person> people)
        {

            foreach (var person in people)
            {
                if (person.Name == "Jay-Z")
                {
                    person.Kidneys = Convert.ToInt32(0);
                    person.Healthy = Convert.ToBoolean(false);
                    Console.WriteLine($"Å nei! {person.Name} har vært i en ulykke og har nå kun {person.Kidneys} fungerbare nyrer!");
                }
            }
            Console.WriteLine("Han må nå til sykehuset for å få donert en ny nyre.");
            Console.WriteLine("Heldigvis har han noen bekjente han kan kontakte.");
            Console.WriteLine($"Kjæresten {people[1].Name} og kompisen {people[2].Name}");
        }

        static void CheckHealth(List<Person> people)
        {
            foreach (var person in people)
            {
                if (person.Name != "Jay-Z")
                {
                    if (people[0].BloodType == person.BloodType)
                    {
                        Console.WriteLine($"{people[0].Name} og {person.Name} har samme blodtype");
                        if (person.Healthy == true)
                        {
                            person.Donate = Convert.ToBoolean(true);
                            Console.WriteLine($"og {person.Name} er frisk nok til å donere.");
                        }
                    }
                }
            }
        }

        static void Operation(List<Person> people)
        {
            foreach (var person in people)
            {
                if (person.Donate == true)
                {
                    person.Kidneys--;
                    people[0].Kidneys++;

                    Console.WriteLine($"Operasjonen var vellykket, og {person.Name} har gitt sin nyre til {people[0].Name}.");
                    Console.WriteLine($"{person.Name} har nå {person.Kidneys} nyre,");
                    Console.WriteLine($"mens {people[0].Name} har nå {people[0].Kidneys} fungerbar nyre.");
                    people[0].Healthy = true;
                    person.Donate = false;
                }
            }
        }


        static void Main(string[] args)
        {
            People people = new People();

            Console.WriteLine($"Dette er historien om {people.arrayList[0].Name}, {people.arrayList[1].Name} og {people.arrayList[2].Name}.");
            Console.WriteLine("Trykk enter for å fortsette hisrotien.");
            Console.ReadLine();
            Accident(people.arrayList);
            Console.WriteLine("Trykk enter for å fortsette hisrotien.");
            Console.ReadLine();
            Console.WriteLine($"{people.arrayList[1].Name} og {people.arrayList[2].Name} er begge friske og har begge {people.arrayList[1].Kidneys} nyrer.");
            Console.WriteLine("Det eneste de må nå er å skjekke om blodtypen er riktig.");
            Console.WriteLine("Trykk enter for å fortsette hisrotien.");
            Console.ReadLine();
            CheckHealth(people.arrayList);
            Console.WriteLine("Trykk enter for å fortsette hisrotien.");
            Console.ReadLine();
            Operation(people.arrayList);
            Console.WriteLine($"{people.arrayList[0].Name} kommer neppe til å ta en salto med buss igjen!");
            Console.WriteLine("SLUTT");
        }
    }
}