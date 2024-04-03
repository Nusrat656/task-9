using ConsoleApp15.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Dvd : ILibraries
    {
        public Dvd(string v1, string v2, int v3)
        {
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public int AvailabeCopies { get; set; }


        public void CheckOut()
        {
            if (AvailabeCopies > 0)
            {
                AvailabeCopies--;
                Console.WriteLine("Available");
            }
            else { Console.WriteLine("Not Availabe"); }

        }

        public void Return()
        {

            AvailabeCopies++;
            Console.WriteLine("Kopya artdi");

        }
    }
}
