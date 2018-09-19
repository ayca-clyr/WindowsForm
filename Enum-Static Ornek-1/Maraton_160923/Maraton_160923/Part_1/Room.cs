using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    abstract class Room
    {
        public string RoomName { get; set; }
        public int Capacity { get; set; }
         
        private List<Inventory> _inventory;  // Demir baş
        public List<Inventory> Inventory
        { 
            get { return _inventory; }
        }

    }
}
