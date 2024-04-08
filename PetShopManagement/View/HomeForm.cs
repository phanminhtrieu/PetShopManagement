using PetShopManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopManagement.View
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            LoadBillNotPaid();


        }

        #region Method

        void LoadBillNotPaid()
        {


        }

        private Form currentChildForm;
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlBody.Controls.Add(childForm);
            this.pnlBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #endregion

        // Event
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }

        private void btnCrate_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CrateForm());
        }

        private void btnPet_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PetForm());
        }

        private void btnOfferings_Click(object sender, EventArgs e)
        {
            
        }



        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            OpenChildForm(customerForm);
        }


        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        
    }
}
