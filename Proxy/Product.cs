using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Product
    {
        private int id;
        protected String name;

        public Product(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return id;
        }

        public String getName()
        {
            return name;
        }

        public virtual void setName(String name)
        {
            this.name = name;
        }
    }
}
