using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coom.Common;

namespace Coom.Employees
{
    class Employee:BaseClass
    {
        public override void info()
        {
            Console.WriteLine("Thi is " + this.getId());
        }
    }
}
