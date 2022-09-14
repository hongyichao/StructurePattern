using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ProductProxy
    {
        DbContext dbContext;
        Product product;
        public ProductProxy(Product product, DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.product = product;
        }

        public void setName(string newName) 
        {
            product.setName(newName);
            dbContext.markAsChanged(product);            
        }
    }
}
