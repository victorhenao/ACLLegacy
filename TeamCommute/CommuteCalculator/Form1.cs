using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommuteCalculator
{
    public partial class frmCommuteCalculator : Form
    {
        public frmCommuteCalculator()
        {
            InitializeComponent();
        }

        private void frmCommuteCalculator_LocationChanged(object sender, EventArgs e)
        {
            TechniciansItem technician1 = new TechniciansItem("Larry", 1);
            TechniciansItem technician2 = new TechniciansItem("Sara", 1);
            TechniciansItem technician3 = new TechniciansItem("Marta", 3);
            EquipmentItem equipment1 = new EquipmentItem("Motor 3/8", 15);
            EquipmentItem equipment2 = new EquipmentItem("Llave de Impacto", 5);
            EquipmentItem equipment3 = new EquipmentItem("Grabador Neumatico", 20);

            cbTechnician1.Items.Add(technician1);
            cbTechnician1.Items.Add(technician2);
            cbTechnician1.Items.Add(technician3);

            cbTechnician2.Items.Add(technician1);
            cbTechnician2.Items.Add(technician2);
            cbTechnician2.Items.Add(technician3);

            cbEquipment.Items.Add(equipment1);
            cbEquipment.Items.Add(equipment2);
            cbEquipment.Items.Add(equipment3);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int techniciansQuantity = 0;
            int cost = 0;
            if (cbTechnician1.SelectedItem != null)
                techniciansQuantity++;
            if (cbTechnician2.SelectedItem != null)
                techniciansQuantity++;
            cost = techniciansQuantity * 45000;
            txtCost.Text = cost.ToString();
        }
    }
}
