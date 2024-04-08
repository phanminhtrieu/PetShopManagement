namespace PetShopManagement.View
{
    partial class ChooseCustomerForm
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
            this.flwCustomerList = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddNewCustomer = new System.Windows.Forms.Button();
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
            this.pnlBody.Size = new System.Drawing.Size(413, 563);
            this.pnlBody.TabIndex = 5;
            // 
            // pnlBillNotPaid_ListView
            // 
            this.pnlBillNotPaid_ListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBillNotPaid_ListView.Controls.Add(this.flwCustomerList);
            this.pnlBillNotPaid_ListView.Controls.Add(this.btnCancel);
            this.pnlBillNotPaid_ListView.Controls.Add(this.btnChoose);
            this.pnlBillNotPaid_ListView.Controls.Add(this.panel4);
            this.pnlBillNotPaid_ListView.Location = new System.Drawing.Point(6, 5);
            this.pnlBillNotPaid_ListView.Name = "pnlBillNotPaid_ListView";
            this.pnlBillNotPaid_ListView.Size = new System.Drawing.Size(400, 550);
            this.pnlBillNotPaid_ListView.TabIndex = 0;
            // 
            // flwCustomerList
            // 
            this.flwCustomerList.AutoScroll = true;
            this.flwCustomerList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flwCustomerList.Dock = System.Windows.Forms.DockStyle.Top;
            this.flwCustomerList.Location = new System.Drawing.Point(0, 50);
            this.flwCustomerList.Name = "flwCustomerList";
            this.flwCustomerList.Size = new System.Drawing.Size(398, 407);
            this.flwCustomerList.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(228, 480);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(147, 51);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose.Location = new System.Drawing.Point(16, 480);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(147, 51);
            this.btnChoose.TabIndex = 16;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MistyRose;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnAddNewCustomer);
            this.panel4.Controls.Add(this.tbxListOfPet);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(398, 50);
            this.panel4.TabIndex = 0;
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Location = new System.Drawing.Point(349, 14);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(25, 25);
            this.btnAddNewCustomer.TabIndex = 6;
            this.btnAddNewCustomer.Text = "+";
            this.btnAddNewCustomer.UseVisualStyleBackColor = true;
            // 
            // tbxListOfPet
            // 
            this.tbxListOfPet.AutoSize = true;
            this.tbxListOfPet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxListOfPet.Location = new System.Drawing.Point(124, 14);
            this.tbxListOfPet.Name = "tbxListOfPet";
            this.tbxListOfPet.Size = new System.Drawing.Size(152, 23);
            this.tbxListOfPet.TabIndex = 0;
            this.tbxListOfPet.Text = "CUSTOMER LIST";
            // 
            // ChooseCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 563);
            this.Controls.Add(this.pnlBody);
            this.Name = "ChooseCustomerForm";
            this.Text = "ChooseCustomerForm";
            this.pnlBody.ResumeLayout(false);
            this.pnlBillNotPaid_ListView.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlBillNotPaid_ListView;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label tbxListOfPet;
        private System.Windows.Forms.FlowLayoutPanel flwCustomerList;
        private System.Windows.Forms.Button btnAddNewCustomer;
    }
}