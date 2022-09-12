using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Section6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = File.ReadAllText("C:\\Users\\HP\\Simplilearn_Practice_Projects\\StudentData.txt");
            Console.WriteLine(data);
        }
    }
}