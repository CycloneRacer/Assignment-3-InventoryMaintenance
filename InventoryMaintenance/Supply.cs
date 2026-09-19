using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    public class Supply : InvItem
    {

        public string Manufacturer { get; set; }
        //Kyle Rosa
        public Supply() { }

        public Supply(int itemNo, string description, decimal price, string manufacturer) : base(itemNo, description, price)
        {
            Manufacturer = manufacturer;
        }

        public override string GetDisplayText() => $"{ItemNo}  {Manufacturer}  {Description} ({Price:c})";

    }
}
