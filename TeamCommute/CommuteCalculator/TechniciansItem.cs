using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommuteCalculator
{
    public class TechniciansItem
    {
        private string technicianName;
        private int technicianLevel;

        public TechniciansItem(string name, int level)
        {
            technicianName = name;
            technicianLevel = level;
        }

        public string TechnicianName
        {
            get { return technicianName; }
            set { technicianName = value; }
        }

        public int TechniciamLevel
        {
            get { return technicianLevel; }
            set { technicianLevel = value; }
        }

        public override string ToString()
        {
            return technicianName;
        }
    }
}
