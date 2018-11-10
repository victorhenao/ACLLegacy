using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommuteCalculator
{
    public class EquipmentItem
    {
        private string equipmentName;
        private int equipmentweight;

        public EquipmentItem(string name, int weight)
        {
            equipmentName = name;
            equipmentweight = weight;
        }

        public string EquipmentName
        {
            get { return equipmentName; }
            set { equipmentName = value; }
        }

        public int Equipmentweight
        {
            get { return equipmentweight; }
            set { equipmentweight = value; }
        }

        public override string ToString()
        {
            return equipmentName;
        }
    }
}
