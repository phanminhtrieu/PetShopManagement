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
    public partial class DeletePetOfCustomerForm : Form
    {
        public Customer SelectedCustomer { get; set; }
        public bool IsCancle { get; set; }
        public DeletePetOfCustomerForm(Customer selectedCustomer)
        {
            this.SelectedCustomer = selectedCustomer;
            InitializeComponent();
            LoadPetOfCustomerList();
        }

        public DeletePetOfCustomerForm()
        {
            InitializeComponent();
        }

        private void LoadPetOfCustomerList()
        {
            // Mỗi lần load lại thì phải xóa hết tất cả 
            flwPetOfCustomerList.Controls.Clear();

            // Tạo danh sách chứa tất cả pet của customer
            List<Pet> pets = SelectedCustomer.GetPets();

            foreach (Pet pet in pets)
            {
                // Mỗi customer sẽ tương đương với một button và hiển thị id và tên của người đó
                Button btnPetIcon = new Button() { Width = 275, Height = 51 };
                btnPetIcon.Text = "\t" + pet.ID + Environment.NewLine + "\t" + pet.Type + "\t" + pet.StatusToString();

                btnPetIcon.TextAlign = ContentAlignment.MiddleLeft;
                btnPetIcon.Tag = pet;

                flwPetOfCustomerList.Controls.Add(btnPetIcon);
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.IsCancle = true;
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message = "Are you sure want to delete all Pets of this Customer?";
            if (MessageBox.Show(message, "Attention", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                // Tạo danh sách chứa tất cả pet của customer
                List<Pet> pets = SelectedCustomer.GetPets();
                foreach (Pet pet in pets)
                {
                    pet.Delete();
                }
                MessageBox.Show("Deleted all Pets!");
                this.IsCancle = false;
                this.Close();
            }
            else
            {
                this.IsCancle = true;
            }
            

        }
    }
}
