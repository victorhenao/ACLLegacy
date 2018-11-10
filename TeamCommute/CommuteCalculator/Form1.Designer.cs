namespace CommuteCalculator
{
    partial class frmCommuteCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTechnician1 = new System.Windows.Forms.Label();
            this.lblTechnician2 = new System.Windows.Forms.Label();
            this.cbTechnician1 = new System.Windows.Forms.ComboBox();
            this.cbTechnician2 = new System.Windows.Forms.ComboBox();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.cbEquipment = new System.Windows.Forms.ComboBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.numericDistance = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTechnician1
            // 
            this.lblTechnician1.AutoSize = true;
            this.lblTechnician1.Location = new System.Drawing.Point(13, 39);
            this.lblTechnician1.Name = "lblTechnician1";
            this.lblTechnician1.Size = new System.Drawing.Size(89, 17);
            this.lblTechnician1.TabIndex = 0;
            this.lblTechnician1.Text = "Technician 1";
            // 
            // lblTechnician2
            // 
            this.lblTechnician2.AutoSize = true;
            this.lblTechnician2.Location = new System.Drawing.Point(13, 84);
            this.lblTechnician2.Name = "lblTechnician2";
            this.lblTechnician2.Size = new System.Drawing.Size(89, 17);
            this.lblTechnician2.TabIndex = 2;
            this.lblTechnician2.Text = "Technician 2";
            // 
            // cbTechnician1
            // 
            this.cbTechnician1.FormattingEnabled = true;
            this.cbTechnician1.Location = new System.Drawing.Point(144, 39);
            this.cbTechnician1.Name = "cbTechnician1";
            this.cbTechnician1.Size = new System.Drawing.Size(223, 24);
            this.cbTechnician1.TabIndex = 3;
            // 
            // cbTechnician2
            // 
            this.cbTechnician2.FormattingEnabled = true;
            this.cbTechnician2.Location = new System.Drawing.Point(144, 84);
            this.cbTechnician2.Name = "cbTechnician2";
            this.cbTechnician2.Size = new System.Drawing.Size(223, 24);
            this.cbTechnician2.TabIndex = 4;
            // 
            // lblEquipment
            // 
            this.lblEquipment.AutoSize = true;
            this.lblEquipment.Location = new System.Drawing.Point(13, 155);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(75, 17);
            this.lblEquipment.TabIndex = 5;
            this.lblEquipment.Text = "Equipment";
            // 
            // cbEquipment
            // 
            this.cbEquipment.FormattingEnabled = true;
            this.cbEquipment.Location = new System.Drawing.Point(144, 155);
            this.cbEquipment.Name = "cbEquipment";
            this.cbEquipment.Size = new System.Drawing.Size(223, 24);
            this.cbEquipment.TabIndex = 6;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(13, 236);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(63, 17);
            this.lblDistance.TabIndex = 7;
            this.lblDistance.Text = "Distance";
            // 
            // numericDistance
            // 
            this.numericDistance.Location = new System.Drawing.Point(144, 236);
            this.numericDistance.Name = "numericDistance";
            this.numericDistance.Size = new System.Drawing.Size(120, 22);
            this.numericDistance.TabIndex = 8;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(16, 308);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(86, 23);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(13, 388);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(63, 17);
            this.lblCost.TabIndex = 10;
            this.lblCost.Text = "Distance";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(144, 388);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(120, 22);
            this.txtCost.TabIndex = 11;
            // 
            // frmCommuteCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 492);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.numericDistance);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.cbEquipment);
            this.Controls.Add(this.lblEquipment);
            this.Controls.Add(this.cbTechnician2);
            this.Controls.Add(this.cbTechnician1);
            this.Controls.Add(this.lblTechnician2);
            this.Controls.Add(this.lblTechnician1);
            this.Name = "frmCommuteCalculator";
            this.Text = "Commute Calculator";
            this.LocationChanged += new System.EventHandler(this.frmCommuteCalculator_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.numericDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTechnician1;
        private System.Windows.Forms.Label lblTechnician2;
        private System.Windows.Forms.ComboBox cbTechnician1;
        private System.Windows.Forms.ComboBox cbTechnician2;
        private System.Windows.Forms.Label lblEquipment;
        private System.Windows.Forms.ComboBox cbEquipment;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.NumericUpDown numericDistance;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
    }
}

