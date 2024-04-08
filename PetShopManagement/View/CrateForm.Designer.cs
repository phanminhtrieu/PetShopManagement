namespace PetShopManagement.View
{
    partial class CrateForm
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
            this.pnlPay = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txbCrateID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.pnlBillListView = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.btnAddPet = new System.Windows.Forms.Button();
            this.txbPetID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbName = new System.Windows.Forms.ComboBox();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBillNotPaid_ListView = new System.Windows.Forms.Panel();
            this.flwListOfCrate = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbTitleWaitingBill = new System.Windows.Forms.Label();
            this.pnlBody.SuspendLayout();
            this.pnlPay.SuspendLayout();
            this.pnlBillListView.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            this.pnlBillNotPaid_ListView.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnlBody.Controls.Add(this.pnlPay);
            this.pnlBody.Controls.Add(this.pnlAdd);
            this.pnlBody.Controls.Add(this.pnlBillNotPaid_ListView);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1224, 695);
            this.pnlBody.TabIndex = 3;
            // 
            // pnlPay
            // 
            this.pnlPay.BackColor = System.Drawing.Color.MistyRose;
            this.pnlPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPay.Controls.Add(this.label5);
            this.pnlPay.Controls.Add(this.txbCrateID);
            this.pnlPay.Controls.Add(this.btnDelete);
            this.pnlPay.Controls.Add(this.btnDeleteRow);
            this.pnlPay.Controls.Add(this.pnlBillListView);
            this.pnlPay.Controls.Add(this.txbTotal);
            this.pnlPay.Controls.Add(this.label4);
            this.pnlPay.Controls.Add(this.btnPay);
            this.pnlPay.Location = new System.Drawing.Point(539, 176);
            this.pnlPay.Name = "pnlPay";
            this.pnlPay.Size = new System.Drawing.Size(680, 514);
            this.pnlPay.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Crate ID:";
            // 
            // txbCrateID
            // 
            this.txbCrateID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCrateID.Location = new System.Drawing.Point(142, 457);
            this.txbCrateID.Name = "txbCrateID";
            this.txbCrateID.ReadOnly = true;
            this.txbCrateID.Size = new System.Drawing.Size(200, 32);
            this.txbCrateID.TabIndex = 16;
            this.txbCrateID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(33, 391);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(147, 51);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRow.Location = new System.Drawing.Point(195, 391);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(147, 51);
            this.btnDeleteRow.TabIndex = 9;
            this.btnDeleteRow.Text = "Delete row";
            this.btnDeleteRow.UseVisualStyleBackColor = true;
            this.btnDeleteRow.Visible = false;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // pnlBillListView
            // 
            this.pnlBillListView.Controls.Add(this.lsvBill);
            this.pnlBillListView.Location = new System.Drawing.Point(1, -1);
            this.pnlBillListView.Name = "pnlBillListView";
            this.pnlBillListView.Size = new System.Drawing.Size(686, 375);
            this.pnlBillListView.TabIndex = 0;
            // 
            // lsvBill
            // 
            this.lsvBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.lsvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvBill.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvBill.FullRowSelect = true;
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.LabelEdit = true;
            this.lsvBill.Location = new System.Drawing.Point(0, 0);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(686, 375);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            this.lsvBill.SelectedIndexChanged += new System.EventHandler(this.lsvBill_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            this.columnHeader3.Width = 71;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Service name";
            this.columnHeader1.Width = 316;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.Width = 249;
            // 
            // txbTotal
            // 
            this.txbTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotal.ForeColor = System.Drawing.Color.Black;
            this.txbTotal.Location = new System.Drawing.Point(439, 391);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.ReadOnly = true;
            this.txbTotal.Size = new System.Drawing.Size(214, 32);
            this.txbTotal.TabIndex = 10;
            this.txbTotal.Text = "0";
            this.txbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(371, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total:";
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(505, 441);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(147, 51);
            this.btnPay.TabIndex = 9;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.Color.MistyRose;
            this.pnlAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdd.Controls.Add(this.btnAddPet);
            this.pnlAdd.Controls.Add(this.txbPetID);
            this.pnlAdd.Controls.Add(this.btnAdd);
            this.pnlAdd.Controls.Add(this.label3);
            this.pnlAdd.Controls.Add(this.cbbName);
            this.pnlAdd.Controls.Add(this.cbbType);
            this.pnlAdd.Controls.Add(this.label2);
            this.pnlAdd.Controls.Add(this.label1);
            this.pnlAdd.Location = new System.Drawing.Point(538, 6);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(681, 163);
            this.pnlAdd.TabIndex = 2;
            // 
            // btnAddPet
            // 
            this.btnAddPet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPet.Location = new System.Drawing.Point(507, 5);
            this.btnAddPet.Name = "btnAddPet";
            this.btnAddPet.Size = new System.Drawing.Size(147, 51);
            this.btnAddPet.TabIndex = 15;
            this.btnAddPet.Text = "Add pet";
            this.btnAddPet.UseVisualStyleBackColor = true;
            this.btnAddPet.Visible = false;
            this.btnAddPet.Click += new System.EventHandler(this.btnAddPet_Click);
            // 
            // txbPetID
            // 
            this.txbPetID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPetID.Location = new System.Drawing.Point(143, 11);
            this.txbPetID.Name = "txbPetID";
            this.txbPetID.ReadOnly = true;
            this.txbPetID.Size = new System.Drawing.Size(326, 32);
            this.txbPetID.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(506, 76);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(147, 51);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Pet ID:";
            // 
            // cbbName
            // 
            this.cbbName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbName.FormattingEnabled = true;
            this.cbbName.Location = new System.Drawing.Point(143, 111);
            this.cbbName.Name = "cbbName";
            this.cbbName.Size = new System.Drawing.Size(326, 31);
            this.cbbName.TabIndex = 4;
            // 
            // cbbType
            // 
            this.cbbType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Location = new System.Drawing.Point(143, 60);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(326, 31);
            this.cbbType.TabIndex = 3;
            this.cbbType.SelectedIndexChanged += new System.EventHandler(this.cbbType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type:";
            // 
            // pnlBillNotPaid_ListView
            // 
            this.pnlBillNotPaid_ListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBillNotPaid_ListView.Controls.Add(this.flwListOfCrate);
            this.pnlBillNotPaid_ListView.Controls.Add(this.panel1);
            this.pnlBillNotPaid_ListView.Controls.Add(this.panel4);
            this.pnlBillNotPaid_ListView.Location = new System.Drawing.Point(6, 5);
            this.pnlBillNotPaid_ListView.Name = "pnlBillNotPaid_ListView";
            this.pnlBillNotPaid_ListView.Size = new System.Drawing.Size(522, 685);
            this.pnlBillNotPaid_ListView.TabIndex = 0;
            // 
            // flwListOfCrate
            // 
            this.flwListOfCrate.AutoScroll = true;
            this.flwListOfCrate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwListOfCrate.Location = new System.Drawing.Point(0, 50);
            this.flwListOfCrate.Name = "flwListOfCrate";
            this.flwListOfCrate.Size = new System.Drawing.Size(520, 583);
            this.flwListOfCrate.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 633);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 50);
            this.panel1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(163, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "SHOW BILL SERVICE";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MistyRose;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txbTitleWaitingBill);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(520, 50);
            this.panel4.TabIndex = 0;
            // 
            // txbTitleWaitingBill
            // 
            this.txbTitleWaitingBill.AutoSize = true;
            this.txbTitleWaitingBill.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTitleWaitingBill.Location = new System.Drawing.Point(180, 13);
            this.txbTitleWaitingBill.Name = "txbTitleWaitingBill";
            this.txbTitleWaitingBill.Size = new System.Drawing.Size(143, 23);
            this.txbTitleWaitingBill.TabIndex = 0;
            this.txbTitleWaitingBill.Text = "LIST OF CRATE";
            this.txbTitleWaitingBill.Click += new System.EventHandler(this.txbTitleWaitingBill_Click);
            // 
            // CrateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 695);
            this.Controls.Add(this.pnlBody);
            this.Name = "CrateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetForm";
            this.pnlBody.ResumeLayout(false);
            this.pnlPay.ResumeLayout(false);
            this.pnlPay.PerformLayout();
            this.pnlBillListView.ResumeLayout(false);
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.pnlBillNotPaid_ListView.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlPay;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDeleteRow;
        private System.Windows.Forms.Panel pnlBillListView;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlBillNotPaid_ListView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label txbTitleWaitingBill;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.FlowLayoutPanel flwListOfCrate;
        private System.Windows.Forms.TextBox txbPetID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnAddPet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbCrateID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}