using PetShopManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopManagement.View
{
    public partial class CrateAddPetForm : Form
    {
        public CrateAddPetForm(string crateID)
        {
            InitializeComponent();
            LoadPetInfomationReadOnly(crateID);
        }

        public CrateAddPetForm()
        {
            InitializeComponent();
        }

        #region Method

        void LoadPetInfomationReadOnly(string crateID)
        {
            // Tạo một con pet mới
            Pet pet = new Pet();
            pet.CreateID();

            txbPetID.Text = pet.ID;
            txbCrateID.Text = crateID;
            cbbCustomerID.DataSource = CustomerDAO.Instance.GetAll();
            cbbCustomerID.DisplayMember = "ID";

            dateTimePicker1.MinDate = DateTime.Now;
        }


        #endregion




        #region Event

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet()
            {
                ID = txbPetID.Text,
                Type = cbbType.SelectedItem.ToString(),
                CrateID = txbCrateID.Text,
                CustomerID = (cbbCustomerID.SelectedItem as Customer).ID,
                Description = txbDescription.Text,
                DateIn = dateTimePicker1.Value.Date,
                Size = cbbSize.SelectedItem.ToString()
            };

            bool insertSuccessfully = PetDAO.Instance.Insert(pet);

            if (insertSuccessfully)
            {
                // Nếu thêm pet mới vào chuồng trống thành công thì sau khi confirm phải set lại status cho crate
                MessageBox.Show("Add pet successfully");
                CrateDAO.Instance.UpdateCrateStatusToFull(txbCrateID.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Add pet is not successfully");
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ChooseCustomerForm chooseCustomerForm = new ChooseCustomerForm();
            chooseCustomerForm.StartPosition = FormStartPosition.CenterScreen;

            chooseCustomerForm.ShowDialog();

            cbbCustomerID.Text = chooseCustomerForm.SelectedCustomerID;

        }



        #endregion

        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlBillNotPaid_ListView_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
