using PetShopManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopManagement.DAO
{
    internal class MenuServiceDAO
    {
        private static MenuServiceDAO instance;

        public static MenuServiceDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MenuServiceDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private MenuServiceDAO() { }

        public List<MenuService> GetListMenuByCrateID(string crateID)
        {
            List<MenuService> listMenu = new List<MenuService>();

            // Dùng câu query để tìm tên dịch vụ và giá dịch vụ của một chuồng thông qua id của chuồng.
            // --> Kết hợp 3 table Bill_Service, Bill_Service_Details, Service
            // Trong đó đảm bảo rằng Bill_Service chưa được thanh toán ( status = 1)
            string query = "SELECT billDetails.ID, service.Name, service.Price FROM Bill_Service AS bill, Bill_Service_Details AS billDetails, Service AS service"
                         + " " + "WHERE bill.ID = billDetails.BillID AND billDetails.ServiceID = service.ID AND bill.Status = 1 AND bill.CrateID = @crateID";

            //  data ở đây là kết quả của quá trình kết nối tự nhiên ba bảng lại với nhau
            //  ----> thế nên không có đối tượng của lớp nào có đủ các thuộc tính để lưu trữ.
            // -----> Tạo một lớp trung gian để thể hiện những cột cần được hiển thị (tên dịch vụ và giá dịch vụ)
            // -----> Đây là lý do tồn tại lớp MenuService và MenuServiceDAO

            List<MenuService> data = DataProvider.Instance.Query<MenuService>(query, new { crateID = crateID});

            foreach (var record in data)
            {
                MenuService menuService = new MenuService(record);
                listMenu.Add(menuService);
            }

            return listMenu;
        }
    }
}
