using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coom.Common
{
    public abstract class BaseClass
    {
        private int id;
        private string name;

        public int getId()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        public void setId(int id)
        {
             this.id = id;
        }

        public void setName(string name)
        {
             this.name = name;
        }

        abstract public void info();
        
    }
}
