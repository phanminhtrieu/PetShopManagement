namespace PetShopManagement.View
{
    partial class CrateAddPetForm
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
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlBillNotPaid_ListView = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cbbCustomerID = new System.Windows.Forms.ComboBox();
            this.cbbSize = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbCrateID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPetID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddPet = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbxListOfPet = new System.Windows.Forms.Label();
            this.pnlBody.SuspendLayout();
            this.pnlBillNotPaid_ListView.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnlBody.Controls.Add(this.pnlBillNotPaid_ListView);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(551, 581);
            this.pnlBody.TabIndex = 4;
            // 
            // pnlBillNotPaid_ListView
            // 
            this.pnlBillNotPaid_ListView.Controls.Add(this.button1);
            this.pnlBillNotPaid_ListView.Controls.Add(this.cbbCustomerID);
            this.pnlBillNotPaid_ListView.Controls.Add(this.cbbSize);
            this.pnlBillNotPaid_ListView.Controls.Add(this.dateTimePicker1);
            this.pnlBillNotPaid_ListView.Controls.Add(this.cbbType);
            this.pnlBillNotPaid_ListView.Controls.Add(this.label8);
            this.pnlBillNotPaid_ListView.Controls.Add(this.label6);
            this.pnlBillNotPaid_ListView.Controls.Add(this.txbDescription);
            this.pnlBillNotPaid_ListView.Controls.Add(this.label5);
            this.pnlBillNotPaid_ListView.Controls.Add(this.label4);
            this.pnlBillNotPaid_ListView.Controls.Add(this.txbCrateID);
            this.pnlBillNotPaid_ListView.Controls.Add(this.label3);
            this.pnlBillNotPaid_ListView.Controls.Add(this.label2);
            this.pnlBillNotPaid_ListView.Controls.Add(this.txbPetID);
            this.pnlBillNotPaid_ListView.Controls.Add(this.label1);
            this.pnlBillNotPaid_ListView.Controls.Add(this.btnCancel);
            this.pnlBillNotPaid_ListView.Controls.Add(this.btnAddPet);
            this.pnlBillNotPaid_ListView.Controls.Add(this.panel4);
            this.pnlBillNotPaid_ListView.Location = new System.Drawing.Point(6, 5);
            this.pnlBillNotPaid_ListView.Name = "pnlBillNotPaid_ListView";
            this.pnlBillNotPaid_ListView.Size = new System.Drawing.Size(540, 568);
            this.pnlBillNotPaid_ListView.TabIndex = 0;
            this.pnlBillNotPaid_ListView.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBillNotPaid_ListView_Paint);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(407, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 39;
            this.button1.Text = "Choose";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cbbCustomerID
            // 
            this.cbbCustomerID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCustomerID.FormattingEnabled = true;
            this.cbbCustomerID.Location = new System.Drawing.Point(212, 254);
            this.cbbCustomerID.Name = "cbbCustomerID";
            this.cbbCustomerID.Size = new System.Drawing.Size(175, 31);
            this.cbbCustomerID.TabIndex = 38;
            // 
            // cbbSize
            // 
            this.cbbSize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSize.FormattingEnabled = true;
            this.cbbSize.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.cbbSize.Location = new System.Drawing.Point(212, 422);
            this.cbbSize.Name = "cbbSize";
            this.cbbSize.Size = new System.Drawing.Size(295, 31);
            this.cbbSize.TabIndex = 37;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(212, 368);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(295, 28);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // cbbType
            // 
            this.cbbType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "Dog",
            "Cat\t\t"});
            this.cbbType.Location = new System.Drawing.Point(212, 144);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(295, 31);
            this.cbbType.TabIndex = 34;
            this.cbbType.SelectedIndexChanged += new System.EventHandler(this.cbbType_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 23);
            this.label8.TabIndex = 32;
            this.label8.Text = "Size:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "Date in:";
            // 
            // txbDescription
            // 
            this.txbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescription.Location = new System.Drawing.Point(212, 309);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(295, 32);
            this.txbDescription.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Description:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "CustomerID:";
            // 
            // txbCrateID
            // 
            this.txbCrateID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCrateID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCrateID.Location = new System.Drawing.Point(212, 199);
            this.txbCrateID.Name = "txbCrateID";
            this.txbCrateID.ReadOnly = true;
            this.txbCrateID.Size = new System.Drawing.Size(295, 32);
            this.txbCrateID.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "CrateID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Type:";
            // 
            // txbPetID
            // 
            this.txbPetID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPetID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPetID.Location = new System.Drawing.Point(212, 89);
            this.txbPetID.Name = "txbPetID";
            this.txbPetID.ReadOnly = true;
            this.txbPetID.Size = new System.Drawing.Size(295, 32);
            this.txbPetID.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(360, 495);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(147, 51);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddPet
            // 
            this.btnAddPet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPet.Location = new System.Drawing.Point(55, 495);
            this.btnAddPet.Name = "btnAddPet";
            this.btnAddPet.Size = new System.Drawing.Size(147, 51);
            this.btnAddPet.TabIndex = 16;
            this.btnAddPet.Text = "Add pet";
            this.btnAddPet.UseVisualStyleBackColor = true;
            this.btnAddPet.Click += new System.EventHandler(this.btnAddPet_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MistyRose;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.tbxListOfPet);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(540, 50);
            this.panel4.TabIndex = 0;
            // 
            // tbxListOfPet
            // 
            this.tbxListOfPet.AutoSize = true;
            this.tbxListOfPet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxListOfPet.Location = new System.Drawing.Point(160, 12);
            this.tbxListOfPet.Name = "tbxListOfPet";
            this.tbxListOfPet.Size = new System.Drawing.Size(183, 23);
            this.tbxListOfPet.TabIndex = 0;
            this.tbxListOfPet.Text = "PET INFORMATION";
            // 
            // CrateAddPetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 581);
            this.Controls.Add(this.pnlBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrateAddPetForm";
            this.Text = "AddPetListForm";
            this.pnlBody.ResumeLayout(false);
            this.pnlBillNotPaid_ListView.ResumeLayout(false);
            this.pnlBillNotPaid_ListView.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlBillNotPaid_ListView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label tbxListOfPet;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddPet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbCrateID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPetID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.ComboBox cbbSize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbbCustomerID;
    }
}