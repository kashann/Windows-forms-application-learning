using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace Proiect_PAW.Utile
{
    public class SerializeItems
    {
        public static string pathPersoana = @"C:\Users\kashi\Documents\Visual Studio 2015\Projects\PAW_2018\Proiect_PAW\Proiect_PAW\persons.txt";

        public static void SerializePersoane(Person item)
        {
            var data = System.IO.File.ReadAllText(pathPersoana);

            data = data + Environment.NewLine + item.EmployeeId+ " " + item.ContactName + " " + item.ContactNumber + " " + item.Email+ " " + item.Departament;

            System.IO.File.WriteAllText(pathPersoana,data);

        }

        public static List<Person> DeserializePersoane()
        {
            string line;
            System.IO.StreamReader file = new StreamReader(@"C:\Users\kashi\Documents\Visual Studio 2015\Projects\PAW_2018\Proiect_PAW\Proiect_PAW\persons.txt"); // deschidem fisierul
            List<Person> persoaneReturn = new List<Person>();

            //Citim linie cu linie
            while((line = file.ReadLine()) != null)
            {
                string[] persoana = line.Split(' ');
                //0 = id,1 = Nume,2 = Telefon,3 = Mail, 4 = Departament
                persoaneReturn.Add(new Person(persoana[0],persoana[1],persoana[2],persoana[3],persoana[4]));
            }

            return persoaneReturn;
        }
    }
}
