using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ProductProxy: Product
    {
        DbContext dbContext;

        public ProductProxy(int id, DbContext dbContext) : base(id)
        {
            this.dbContext = dbContext;
        }

        public override void setName(string newName) 
        {
            base.setName(newName);
            dbContext.markAsChanged(this);            
        }
    }
}
