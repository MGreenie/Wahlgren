using ClassLibrary.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string roleType = Console.ReadLine();
            var role = RoleFactory.Get(roleType);
        }
    }
}
