using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public interface IOrder
    {
        List<int> OrderSum(List<Item> list, string group,int count);
    }
}
