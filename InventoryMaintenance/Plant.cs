using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    public class Plant : InvItem
    {
        //Kyle Rosa
        //The Plant class represents inheritance becuase it inherits properties and methods from the InvItem class.
        //Additionally, the Plant class adds its own property, Size, and overrides the GetDisplayText method to provide a customized display format for plant items.
        public string Size { get; set; }

        public Plant() { }

        public Plant(int itemNo, string description, decimal price, string size) : base(itemNo, description, price)
        {
            Size = size;
        }

        public override string GetDisplayText() => $"{ItemNo}  {Size}  {Description} ({Price:c})";

    }
}
