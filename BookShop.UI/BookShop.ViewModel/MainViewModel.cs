using BookShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.ViewModel
{
    public class MainViewModel
    {
        public List<Person> People { get; set; }

        public MainViewModel()
        {
            People = new List<Person>()
            {
                new Person("Jon", "Kane",24,"+374-10-21"),
                new Person("Mishel", "Brine",34,"+344-10-21"),
                new Person("Varn", "Korm",24,"-10-21"),
                new Person("Lara", "Jane",55,"+34-10")
            };
        }
    }
}
