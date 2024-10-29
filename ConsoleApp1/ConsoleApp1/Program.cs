using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person> {
            new Person{  Name="Samurai",Surname="Samuraiova",Age=200 },
            new Person{  Name="Zarifa",Surname="Eliyeva",Age=22 },
            new Person{  Name="Nezrin",Surname="Ismayilova",Age=21 },
            new Person{  Name="Anora",Surname="Qaflanova",Age=20 },
            new Person{  Name="Ayla",Surname="Atakisiyeva",Age=19 },
            new Person{  Name="Anar",Surname="Abbasov",Age=23 },
            new Person{  Name="Ismayil",Surname="Ibrahimzade",Age=21 }
            };


            List<Person> person = people.FindAll(name => name.Age>20);//yasi 20den yuxari olanlar
            person.ForEach(n => Console.WriteLine(n.Name ));

            Console.WriteLine("\n");

            Person person1 = people.Find(name => name.Name == "Samurai");// lazim olan adi cixardir
            Console.WriteLine(person1.Name+" "+person1.Surname);

            Console.WriteLine("\n");

            List<Person> persons = people.FindAll(surname => surname.Surname.EndsWith("ova") || surname.Surname.EndsWith("ov"));
            persons.ForEach(s=> Console.WriteLine(s.Name+" "+s.Surname));

            //soyadi "ov" ve "ova" ile bitenleri cixardir.
          


        }




    }
}