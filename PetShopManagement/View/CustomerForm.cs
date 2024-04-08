using PetShopManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopManagement.View
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();

            LoadCustomerDataGridView();
        }

        #region Method

        void LoadCustomerDataGridView()
        {
            dgvCustomer.DataSource = CustomerDAO.Instance.GetAll();
        }

        void SetTextBoxClear()
        {
            txbCustomerID.Text = "";
            txbFirstName.Text = "";
            txbLastName.Text = "";
            txbPhone.Text = "";
            txbAddress.Text = "";
            txbEmail.Text = "";

            SetTextBoxReadOnlyToTrue();
        }

        void SetTextBoxReadOnlyToFalse()
        {
            // Set trạng thái cho các text box
            txbFirstName.ReadOnly = false;
            txbLastName.ReadOnly = false;
            txbPhone.ReadOnly = false;
            txbAddress.ReadOnly = false;
            txbEmail.ReadOnly = false;
        }

        void SetTextBoxReadOnlyToTrue()
        {
            // Set trạng thái cho các text box
            txbFirstName.ReadOnly = true;
            txbLastName.ReadOnly = true;
            txbPhone.ReadOnly = true;
            txbAddress.ReadOnly = true;
            txbEmail.ReadOnly = true;
        }

        void SetEditDeleteButtonEnable()
        {
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        void SetEditDeleteButtonNotEnable()
        {
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        void SetClearAccepctButtonEnable()
        {
            btnAccepct.Enabled = true;
            btnClear.Enabled = true;
        }

        void SetClearAccepctButtonNotEnable()
        {
            btnAccepct.Enabled = false;
            btnClear.Enabled = false;
        }

        #endregion

        #region Event

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            SetTextBoxClear();
            SetEditDeleteButtonNotEnable();
            SetTextBoxReadOnlyToFalse();
            SetClearAccepctButtonEnable();

            lblTitle.Text = "Adding";

            Customer customer = new Customer();
            customer.CreateID();
            txbCustomerID.Text = customer.ID;

            txbAddress.Text = "Unknown";
            txbEmail.Text = "Unknown";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetClearAccepctButtonEnable();
            lblTitle.Text = "Editting";
            int selectedRowCount = dgvCustomer.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                SetTextBoxReadOnlyToFalse();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SetClearAccepctButtonEnable();
            lblTitle.Text = "Deleting";
            bool executeSuccessfully = true;
            
            Customer customer = new Customer();
            // Delete chi can ID
            customer.ID = txbCustomerID.Text;


            if (customer.IsCustomerHavingPet())
            {
                string message = "Are you sure want to delete this customer?\nYou should delete the customer's pets first.\nClick \"Oke\" to delete pets.";
                if (MessageBox.Show(message, "Attention", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    // Phải xóa pet trước, nếu không thì bị lỗi do pet có FK nối tới Customer

                    DeletePetOfCustomerForm deletePetOfCustomerForm = new DeletePetOfCustomerForm(customer);
                    deletePetOfCustomerForm.StartPosition = FormStartPosition.CenterScreen;
                    deletePetOfCustomerForm.ShowDialog();

                    if (deletePetOfCustomerForm.IsCancle == false)
                    {
                        executeSuccessfully = customer.Delete();
                        if (executeSuccessfully == true)
                        {
                            MessageBox.Show("Deleting is successful!");
                            LoadCustomerDataGridView();
                            SetTextBoxClear();
                        }
                        else
                        {
                            MessageBox.Show("Deleting is not successfully!");
                            LoadCustomerDataGridView();
                            SetTextBoxClear();
                        }
                    }

                }
            }
            else
            {
                string message = "Are you sure want to delete this customer?";
                if (MessageBox.Show(message, "Attention", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    executeSuccessfully = customer.Delete();
                    if (executeSuccessfully == true)
                    {
                        MessageBox.Show("Deleting is successful!");
                        LoadCustomerDataGridView();
                        SetTextBoxClear();
                    }
                    else
                    {
                        MessageBox.Show("Deleting is not successfully!");
                        LoadCustomerDataGridView();
                        SetTextBoxClear();
                    }
                }
            }

            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SetTextBoxClear();
        }

        private void btnAccepct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to accepct?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool executeSuccessfully = true;
                if (lblTitle.Text == "Adding")
                {
                    Customer customer = new Customer();
                    customer.ID = txbCustomerID.Text;
                    customer.FirstName = txbFirstName.Text;
                    customer.LastName = txbLastName.Text;
                    customer.Phone = txbPhone.Text;
                    customer.Address = txbAddress.Text;
                    customer.Email = txbEmail.Text;

                    executeSuccessfully = customer.Insert();
                    if (executeSuccessfully == true)
                    {
                        MessageBox.Show("Inserting is successful!");
                        LoadCustomerDataGridView();
                        SetClearAccepctButtonNotEnable();
                        SetTextBoxClear();
                    }
                    else
                    {
                        MessageBox.Show("Inserting is not successful!");
                        LoadCustomerDataGridView();
                        SetClearAccepctButtonNotEnable();
                        SetTextBoxClear();
                    }
                }
                else
                {
                    if (lblTitle.Text == "Editting")
                    {
                        Customer customer = new Customer();
                        customer.ID = txbCustomerID.Text;
                        customer.FirstName = txbFirstName.Text;
                        customer.LastName = txbLastName.Text;
                        customer.Phone = txbPhone.Text;
                        customer.Address = txbAddress.Text;
                        customer.Email = txbEmail.Text;

                        executeSuccessfully = customer.Update();
                        if (executeSuccessfully == true)
                        {
                            MessageBox.Show("Editting is successfully!");
                            LoadCustomerDataGridView();
                            SetTextBoxClear();
                            SetClearAccepctButtonNotEnable();
                        }
                        else
                        {
                            MessageBox.Show("Editting is not successfully!");
                            LoadCustomerDataGridView();
                            SetTextBoxClear();
                            SetClearAccepctButtonNotEnable();
                        }
                    }
                }
            }


        }

        private void dgvCustomer_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //SetClearAccepctButtonEnable();
            SetTextBoxReadOnlyToTrue();
            DataGridView dataGridView = new DataGridView();
            dataGridView = dgvCustomer;

            txbCustomerID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            txbFirstName.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txbLastName.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            txbPhone.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            txbAddress.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            txbEmail.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();

            int selectedRowCount = dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                SetEditDeleteButtonEnable();
            }
            else
            {
                SetEditDeleteButtonNotEnable();
            }
        }


        #endregion

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
