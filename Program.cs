using Assignment3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            SLL originalList = new SLL();
            originalList.AddLast(new User(1, "jim", "jim@gmail.com", "1234"));
            originalList.AddLast(new User(2, "joe", "joe@gmail.com", "4321"));

        }
    }
}
