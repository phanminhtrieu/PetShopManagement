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
    public partial class ChooseCustomerForm : Form
    {
        public string SelectedCustomerID { get; set; }

        public ChooseCustomerForm()
        {
            InitializeComponent();
            LoadCustomerList();
        }

        #region Methods
        private void LoadCustomerList()
        {
            // Mỗi lần load lại thì phải xóa hết tất cả 
            flwCustomerList.Controls.Clear();

            // Tạo danh sách chứa tất cả record của customer
            List<Customer> customers = CustomerDAO.Instance.GetAll();

            foreach (Customer customer in customers)
            {
                // Mỗi customer sẽ tương đương với một button và hiển thị id và tên của người đó
                Button btnCustomerIcon = new Button() { Width = 270, Height = 51 };
                btnCustomerIcon.Text = customer.ID + Environment.NewLine + customer.FirstName + ", " + customer.LastName;

                btnCustomerIcon.TextAlign = ContentAlignment.MiddleLeft;
                btnCustomerIcon.Tag = customer;
                btnCustomerIcon.Click += BtnCustomerIcon_Click;
                
                flwCustomerList.Controls.Add(btnCustomerIcon);
            }

            
        }


        #endregion

        #region Event
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCustomerIcon_Click(object sender, EventArgs e)
        {
            string customerID = ((sender as Button).Tag as Customer).ID;
            SelectedCustomerID = customerID;
            this.Close();
        }

        #endregion

        private void btnChoose_Click(object sender, EventArgs e)
        {

        }
    }
}
