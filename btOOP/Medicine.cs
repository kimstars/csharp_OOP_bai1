using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;



namespace btOOP
{
    class Medicine
    {
        private string MedicineCode;
        private string MedicineName;
        private string ManufacturerName;
        private int UnitPrice;
        private string QuantityOnHand;
        //ctrl r e
        private DateTime ManufacturedDate;
        private DateTime ExpiryDate;
        private int BatchNumber;


        public string MedicineCode1 { get => MedicineCode; set => MedicineCode = value; }
        public string MedicineName1 { get => MedicineName; set => MedicineName = value; }
        public string ManufacturerName1 { get => ManufacturerName; set => ManufacturerName = value; }
        public int UnitPrice1 { get => UnitPrice; set => UnitPrice = value; }
        public string QuantityOnHand1 { get => QuantityOnHand; set => QuantityOnHand = value; }
        public DateTime ManufacturedDate1 { get => ManufacturedDate; set => ManufacturedDate = value; }
        public DateTime ExpiryDate1 { get => ExpiryDate; set => ExpiryDate = value; }
        public int BatchNumber1 { get => BatchNumber; set => BatchNumber = value; }

        public Medicine()
        {
            MedicineCode = "";
            MedicineName = "";
            ManufacturerName = "";
            UnitPrice = 0;
            QuantityOnHand1 = "";
            BatchNumber = 0;
        }

        public void Accept()
        {
            Console.WriteLine("Nhập thông tin của loại thuốc : ");
            Console.WriteLine("Nhập mã loại thuốc : ");
            MedicineCode = Console.ReadLine();

            Console.WriteLine("Nhập tên thuốc : ");
            MedicineName = Console.ReadLine();

            Console.WriteLine("Nhập tên nhà sản xuất thuốc : ");
            ManufacturerName = Console.ReadLine();

            Console.WriteLine("Nhập đơn giá thuốc : ");
            UnitPrice = int.Parse(Console.ReadLine());

            Console.WriteLine($"Nhập số lượng thuốc {MedicineName} sẵn có : ");
            QuantityOnHand = Console.ReadLine();
            string date;
            string patten = @"^([0-2][0-9]|(3)[0-1])(\/)(((0)[0-9])|((1)[0-2]))(\/)\d{4}";
            Regex validate = new Regex(patten);

            Console.WriteLine($"Nhập ngày sản xuất (dd/mm/yyyy) : ");
            do
            {
                date = Console.ReadLine();
                if (!validate.IsMatch(date))
                {
                    Console.WriteLine("Nhập không đúng định dạng (dd/mm/yyyy).\nVui lòng nhập lại");
                }
                else
                {
                    ManufacturedDate = Convert.ToDateTime(date, new CultureInfo("en-US"));
                }
            } while (!validate.IsMatch(date));

            Console.WriteLine($"Nhập hạn sử dụng (dd/mm/yyyy) : ");
            do
            {
                date = Console.ReadLine();
                if (!validate.IsMatch(date))
                {
                    Console.WriteLine("Nhập không đúng định dạng (dd/mm/yyyy).\nVui lòng nhập lại");
                }
                else
                {
                    ExpiryDate = Convert.ToDateTime(date, new CultureInfo("en-US"));
                }
            } while (!validate.IsMatch(date));

            Console.WriteLine("Nhập số lô thuốc : ");
            BatchNumber = int.Parse(Console.ReadLine());

        }
        public void Print1()
        {
            Console.WriteLine($"Thông tin của thuốc : ");
            Console.WriteLine($"Mã loại thuốc : {MedicineCode}");
            Console.WriteLine($"Tên thuốc : {MedicineName}");
            Console.WriteLine($"Tên nhà sản xuất thuốc : {ManufacturerName} ");
            Console.WriteLine($"Đơn giá thuốc : {UnitPrice}");
            Console.WriteLine($"Số lượng thuốc {MedicineName} sẵn có : {QuantityOnHand1} ");
            Console.WriteLine($"Ngày sản xuất (dd/mm/yyyy) : {ManufacturedDate.Day}/{ManufacturedDate.Month}/{ManufacturedDate.Year}");
            Console.WriteLine($"Nhập hạn sử dụng (dd/mm/yyyy) : {ExpiryDate.Day}/{ExpiryDate.Month}/{ExpiryDate.Year}");
            Console.WriteLine($"Số lô thuốc : {BatchNumber}");
        }

        public void Print2()
        {
            Console.WriteLine($"Số lượng thuốc {MedicineName} sẵn có : {QuantityOnHand1} ");
        }

        public void Print3()
        {
            Console.WriteLine($"Ngày sản xuất (dd/mm/yyyy) : {ManufacturedDate.Day}/{ManufacturedDate.Month}/{ManufacturedDate.Year}");
            Console.WriteLine($"Nhập hạn sử dụng (dd/mm/yyyy) : {ExpiryDate.Day}/{ExpiryDate.Month}/{ExpiryDate.Year}");
        }
    }

}
