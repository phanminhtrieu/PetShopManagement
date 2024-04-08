using PetShopManagement.DAO;
using PetShopManagement.Interface;
using PetShopManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopManagement.View
{
    public partial class CrateForm : Form
    {
        public CrateForm()
        {
            InitializeComponent();

            LoadCrateList();

            LoadTypeService();

            

        }


        #region Methods

        void LoadTypeService()
        {
            Service service = new Service();
            List<string> typeNames = service.GetListOfServiceType();
            cbbType.DataSource = typeNames;
        }

        void LoadServiceListByTypeName(string typeName)
        {
            switch (typeName)
            {
                case "Play":
                    cbbName.DataSource = PlayDAO.Instance.GetAll();
                    cbbName.DisplayMember = "Name";
                    break;
                case "Grooming":
                    cbbName.DataSource = GroomingDAO.Instance.GetAll();
                    cbbName.DisplayMember = "Name";
                    break;
                case "Pamper":
                    cbbName.DataSource = PamperDAO.Instance.GetAll();
                    cbbName.DisplayMember = "Name";
                    break;
                default:
                    break;
            }
        }

        void LoadCrateList()
        {
            flwListOfCrate.Controls.Clear();

            List<Crate> crates = CrateDAO.Instance.GetAll();

            foreach (var item in crates)
            {
                Button btnCrateIcon = new Button() { Width = CrateDAO.BtnCrateWidth, Height = CrateDAO.BtnCrateHeight };

                // Set the infomation in a button 
                btnCrateIcon.Text = item.ID + Environment.NewLine + item.StatusToString();

                // Show info bill_serivce
                btnCrateIcon.Click += BtnCrateIcon_Click;

                btnCrateIcon.Tag = item;

                switch (item.Status)
                {
                    case 0:
                        btnCrateIcon.BackColor = Color.Tan;
                        break;
                    default:
                        btnCrateIcon.BackColor = Color.White;
                        break;
                }

                flwListOfCrate.Controls.Add(btnCrateIcon);
            }
        }

        void LoadBillService(string crateID) // Show bill dự vào id của crate 
        {
            lsvBill.Items.Clear();
            decimal totalPrice = 0;
            // List này là kết quả của 3 table: bill_ser, bill_Ser_Details và Service nhưng chỉ hiện 2 cột
            // Tên dịch vụ và giá dịch vụ
            // Nên sử dụng một class trung gian có 2 properties là tên dv và giá dv để hiển thị
            List<MenuService> listBillServiceDetails = MenuServiceDAO.Instance.GetListMenuByCrateID(crateID);

            foreach (var item in listBillServiceDetails)
            {
                // Tạo một cột trong ListView ( một cột trong ListView là ListViewItem)
                // Trong một ListView, cột đầu tiên là cột chính, mấy cột sau đều là cột con của cột đầu (SubItmes)
                ListViewItem lvsItem = new ListViewItem(item.ID.ToString());
                lvsItem.SubItems.Add(item.Name.ToString());
                lvsItem.SubItems.Add(item.Price.ToString());
                totalPrice += item.Price;

                // Thêm dòng đó vào ListView
                lsvBill.Items.Add(lvsItem);
            }
            // Chỉnh cấu hình culture thành vnđ
            //CultureInfo culture = new CultureInfo("vi-VN");

            //txbTotal.Text = totalPrice.ToString("c", culture); // format language 

            txbTotal.Text = totalPrice.ToString();
        }

        void RefreshLabelAdd()
        {
            txbPetID.Text = string.Empty;
            cbbName.Text = string.Empty;
            cbbType.Text = string.Empty;
        }

        #endregion



        #region Event

        private void BtnCrateIcon_Click(object sender, EventArgs e)
        {
            bool petDoNotExit = true;
            string crateID = ((sender as Button).Tag as Crate).ID;
            txbCrateID.Text = crateID;

            // Khi bấm vào cái chuồng thì sẽ có một cái lsvBill được tag (lưu chuồng vào bill) 
            lsvBill.Tag = (sender as Button).Tag;

            // Đây là đối tượng pet được tìm được khi bấm vào button crate ( thông qua crateID )
            Pet pet = ((sender as Button).Tag as Crate).GetPetByCrateID(crateID);
            petDoNotExit = pet == null;

            if (petDoNotExit)
            {
                txbPetID.Text = string.Empty;
                btnAddPet.Visible = true;
                btnAdd.Visible = false;
            }
            else
            {
                txbPetID.Text = pet.ID;
                btnAddPet.Visible = false;
                btnAdd.Visible = true;

            }

            //string crateID = ((sender as Button).Tag as Crate).ID;
            LoadBillService(crateID);// Lấy crate ID từ button được bấm vào 
        }

        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string typeName = "";

            string selectedTypeName = (sender as ComboBox).SelectedItem as string;

            typeName = selectedTypeName;

            // Khi một lần cái type thay đổi thì danh sách name thay đổi theo (theo Type ID)
            // Sau này sẽ nâng lên bằng databinding

            LoadServiceListByTypeName(typeName);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Crate crate = lsvBill.Tag as Crate;

            string idBillService = Bill_ServiceDAO.Instance.GetUncheckBillServiceIDByCrateID(crate.ID);
            string serviceID = (cbbName.SelectedItem as Service).ID;


            // Trường hợp chuồng chưa có bill service
            if (idBillService == null)
            {
                // Ta sẽ tạo một bill_service chỉ có ID và CrateID được chọn
                Bill_Service bill_Service = new Bill_Service();
                bill_Service.CreateID();
                bill_Service.CrateID = crate.ID;
                // Đẩy lên database
                Bill_ServiceDAO.Instance.InsertBillServiceWithIDAndCrateID(bill_Service);
                Bill_Service_DetailsDAO.Instance.InsertBillServiceDetails(bill_Service.ID, serviceID);


                //Bill_ServiceDAO.Instance.InsertBillServiceIntoCrateByCrateID( crate.ID);
                //Bill_Service_DetailsDAO.Instance.InsertBillServiceDetails(Bill_ServiceDAO.Instance.GetTheLastIDFromDatabaseByTable(),serviceID);
            }
            else
            {
                Bill_Service_DetailsDAO.Instance.InsertBillServiceDetails(idBillService, serviceID);
            }
            LoadBillService(crate.ID);
            // Mỗi lần cập nhật gì đó thì lại load lại đống crate
            LoadCrateList();
        }


        private void btnAddPet_Click(object sender, EventArgs e)
        {
            string crateID = txbCrateID.Text;
            CrateAddPetForm addPetListForm = new CrateAddPetForm(crateID);
            addPetListForm.StartPosition = FormStartPosition.CenterScreen;
            addPetListForm.ShowDialog();
            // Mỗi lần cập nhật gì đó thì lại load lại đống crate
            LoadCrateList();
            RefreshLabelAdd();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Crate crate = lsvBill.Tag as Crate;
            string billServiceID = Bill_ServiceDAO.Instance.GetUncheckBillServiceIDByCrateID(crate.ID);

            if (billServiceID != null)
            {
                if (MessageBox.Show($"Are you sure want to pay the bill at {crate.ID}", "Attention", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    // Cập nhật ngày check out và tổng tiền cho bill service
                    Bill_Service bill_Service = Bill_ServiceDAO.Instance.GetBillServiceByBillServiceID(billServiceID);

                    //// Chuyển lại culture để ép về decimal
                    //string input = txbTotal.Text;

                    //// Định rõ CultureInfo là vi-VN
                    //CultureInfo cultureInfo = new CultureInfo("vi-VN");

                    //// Loại bỏ dấu phân tách hàng nghìn (nếu có)
                    //input = input.Replace(cultureInfo.NumberFormat.NumberGroupSeparator, "");

                    //// Thay thế dấu thập phân bằng dấu chấm
                    //input = input.Replace(cultureInfo.NumberFormat.NumberDecimalSeparator, ".");
                    //bill_Service.TotalMoney = Decimal.Parse(input, cultureInfo);

                    bill_Service.TotalMoney = Convert.ToDecimal(txbTotal.Text);


                    Bill_ServiceDAO.Instance.CheckOut(bill_Service);

                    // Reset lại chỗ hiện pet id và thuộc tính status với set date checkout của pet
                    txbPetID.Text = "";

                    // Lấy pet id từ crate và sau đó biến nó thành đã thanh toán
                    string petID = PetDAO.Instance.GetPetByCrateID(crate.ID).ID;
                    PetDAO.Instance.UpdatePetToPaid(petID);

                    LoadBillService(crate.ID);
                    // Mỗi lần cập nhật gì đó thì lại load lại đống crate
                    LoadCrateList();
                    RefreshLabelAdd();
                }
            }
        }

        private void txbTitleWaitingBill_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete all of this crate?", "Attention", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Crate crate = lsvBill.Tag as Crate;
                CrateDAO.Instance.DeletePetAndBillServiceByCrateID(crate.ID);
                LoadCrateList();
                LoadBillService(crate.ID);
                RefreshLabelAdd();
            }
        }

        private void lsvBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvBill.SelectedItems.Count > 0)
            {
                btnDeleteRow.Visible = true;
            }
            else
            {
                btnDeleteRow.Visible = false;   
            }
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            Crate crate = lsvBill.Tag as Crate; 
            Bill_Service_Details billDetails = new Bill_Service_Details();
            if (lsvBill.SelectedItems.Count > 0)
            {
                string idBillDetails = lsvBill.SelectedItems[0].SubItems[0].Text;
                Bill_Service_DetailsDAO.Instance.DeleteBillServiceDetailsByID(idBillDetails);
                LoadBillService(crate.ID);
                btnDeleteRow.Visible = false;
            }
            else
            {
                MessageBox.Show("Please choose only one row!");
            }
            
        }





        #endregion


    }
}
