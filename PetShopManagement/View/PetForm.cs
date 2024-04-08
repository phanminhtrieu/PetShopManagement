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
    public partial class PetForm : Form
    {
        public PetForm()
        {
            InitializeComponent();
            LoadPetDataGridView();
        }

        #region Method

        void LoadPetDataGridView()
        {
            dgvPet.DataSource = PetDAO.Instance.GetAll();
        }

        void FirstFormStatus()
        {
            txbID.Text = string.Empty;
            txbDesc.Text = string.Empty;
            txbCrateID.Text = string.Empty;

            cbbType.Text = string.Empty;
            cbbSize.Text = string.Empty;
            cbbCustomerID.Text = string.Empty;

            dateTimePicker1.Text = DateTime.Now.ToString();
            dateTimePicker2.Text = DateTime.Now.ToString();

            SetNotEnable();
        }

        void SetEnable()
        {
            txbCrateID.Enabled = true;
            txbDesc.Enabled = true;
            cbbType.Enabled = true;
            cbbCustomerID.Enabled = true;
            btnChooseCus.Enabled = true;
            cbbSize.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        void SetNotEnable()
        {
            txbCrateID.Enabled = false;
            txbDesc.Enabled = false; 
            cbbType.Enabled = false;
            cbbCustomerID.Enabled = false;
            btnChooseCus.Enabled = false;
            cbbSize.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Mở form kia
            if (MessageBox.Show("You should put the pet into the crate.", "Attention", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                CrateForm crateForm = new CrateForm();
                crateForm.ShowDialog();
            }

            FirstFormStatus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetClearAccepctButtonEnable();
            lblTitle.Text = "Editting";
            int selectedRowCount = dgvPet.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                SetEnable();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SetClearAccepctButtonEnable();
            lblTitle.Text = "Deleting";

            // Delete chỉ cần id pet là đủ
            Pet pet = new Pet();
            pet.ID = txbID.Text;

            bool executeSuccessfully = true;

            if (MessageBox.Show("Are you sure want to delete this Pet?", "Attention", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                executeSuccessfully = pet.Delete();
                if (executeSuccessfully == true)
                {
                    MessageBox.Show("Deleting is successful!");
                    LoadPetDataGridView();
                    FirstFormStatus();
                }
                else
                {
                    MessageBox.Show("Deleting is not successful!");
                    LoadPetDataGridView();
                    FirstFormStatus();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FirstFormStatus();
        }

        private void btnAccepct_Click(object sender, EventArgs e)
        {
            bool executeSuccessfully = true;
            if (MessageBox.Show("Are you sure want to accepct?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (lblTitle.Text == "Editting")
                {
                    Pet pet = new Pet();
                    pet.ID = txbID.Text;
                    pet.Type = cbbType.Text;
                    pet.CrateID = txbCrateID.Text;
                    pet.CustomerID = cbbCustomerID.Text;
                    pet.Description = txbDesc.Text;
                    pet.DateIn = dateTimePicker1.Value;
                    pet.DateOut = dateTimePicker2.Value;
                    pet.Size = cbbSize.Text;


                    executeSuccessfully = pet.Update();
                    if (executeSuccessfully == true)
                    {
                        MessageBox.Show("Editting is successful!");
                        LoadPetDataGridView();
                        FirstFormStatus();
                        SetClearAccepctButtonNotEnable();
                    }
                    else
                    {
                        MessageBox.Show("Editting is not successful!");
                        //LoadCustomerDataGridView();
                        //SetTextBoxClear();
                        SetClearAccepctButtonNotEnable();
                    }
                }
            }
        }

        private void dgvPet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetNotEnable();
            SetClearAccepctButtonNotEnable();
            DataGridView dataGridView = new DataGridView();
            dataGridView = dgvPet;

            txbID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            cbbType.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txbCrateID.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            cbbCustomerID.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            txbDesc.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();

            try
            {
                dateTimePicker2.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();

            }
            catch
            {
                dateTimePicker2.Text = DateTime.Now.ToString();
            }

            cbbSize.Text = dataGridView.CurrentRow.Cells[7].Value.ToString();

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

        
    }
}
