using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Model
{
    public interface ITechnique
    {
        int Price { get; set; }

        bool TryBuy(int money);

        string Buy(ref int money);
    }
}
