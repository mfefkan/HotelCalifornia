using Project.BLL.GenericRepository.BaseRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.GenericRepository.ConcRep
{
    public class ProductRep : BaseRep<Product>
    {
        public List<string> ListProducts()
        {
            List<string> list = new List<string>();
            foreach (Product item in _db.Products.ToList())
            {
                list.Add(item.ToString());
            }
            return list;
        }
    }
}
