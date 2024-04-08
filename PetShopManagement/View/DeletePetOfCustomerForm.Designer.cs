namespace PetShopManagement.View
{
    partial class DeletePetOfCustomerForm
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
            this.flwPetOfCustomerList = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
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
            this.pnlBody.Size = new System.Drawing.Size(412, 562);
            this.pnlBody.TabIndex = 6;
            // 
            // pnlBillNotPaid_ListView
            // 
            this.pnlBillNotPaid_ListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBillNotPaid_ListView.Controls.Add(this.flwPetOfCustomerList);
            this.pnlBillNotPaid_ListView.Controls.Add(this.btnCancel);
            this.pnlBillNotPaid_ListView.Controls.Add(this.btnDelete);
            this.pnlBillNotPaid_ListView.Controls.Add(this.panel4);
            this.pnlBillNotPaid_ListView.Location = new System.Drawing.Point(6, 5);
            this.pnlBillNotPaid_ListView.Name = "pnlBillNotPaid_ListView";
            this.pnlBillNotPaid_ListView.Size = new System.Drawing.Size(400, 550);
            this.pnlBillNotPaid_ListView.TabIndex = 0;
            // 
            // flwPetOfCustomerList
            // 
            this.flwPetOfCustomerList.AutoScroll = true;
            this.flwPetOfCustomerList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flwPetOfCustomerList.Dock = System.Windows.Forms.DockStyle.Top;
            this.flwPetOfCustomerList.Location = new System.Drawing.Point(0, 50);
            this.flwPetOfCustomerList.Name = "flwPetOfCustomerList";
            this.flwPetOfCustomerList.Size = new System.Drawing.Size(398, 407);
            this.flwPetOfCustomerList.TabIndex = 19;
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
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(16, 480);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(147, 51);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MistyRose;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.tbxListOfPet);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(398, 50);
            this.panel4.TabIndex = 0;
            // 
            // tbxListOfPet
            // 
            this.tbxListOfPet.AutoSize = true;
            this.tbxListOfPet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxListOfPet.Location = new System.Drawing.Point(124, 14);
            this.tbxListOfPet.Name = "tbxListOfPet";
            this.tbxListOfPet.Size = new System.Drawing.Size(167, 23);
            this.tbxListOfPet.TabIndex = 0;
            this.tbxListOfPet.Text = "Pet of Customer";
            // 
            // DeletePetOfCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 562);
            this.Controls.Add(this.pnlBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeletePetOfCustomerForm";
            this.Text = "DeletePetOfCustomerForm";
            this.pnlBody.ResumeLayout(false);
            this.pnlBillNotPaid_ListView.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlBillNotPaid_ListView;
        private System.Windows.Forms.FlowLayoutPanel flwPetOfCustomerList;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label tbxListOfPet;
        private System.Windows.Forms.Button btnDelete;
    }
}