using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btOOP
{
    class Sales
    {
        private string MedicineCode;
        private string QuantitySold;
        private int PlannedSales;
        private int ActualSales;
        private string Region;

        public string MedicineCode1 { get => MedicineCode; set => MedicineCode = value; }
        public string QuantitySold1 { get => QuantitySold; set => QuantitySold = value; }
        public int PlannedSales1 { get => PlannedSales; set => PlannedSales = value; }
        public int ActualSales1 { get => ActualSales; set => ActualSales = value; }
        public string Region1 { get => Region; set => Region = value; }

        public Sales()
        {
            MedicineCode = "";
            QuantitySold = "";
            PlannedSales = 0;
            ActualSales = 0;
            Region = "";

        }



        public void Accept()
        {
            Console.WriteLine("Nhập mã loại thuốc : ");
            MedicineCode = Console.ReadLine();

            Console.WriteLine("Nhập số lượng thuốc kho sẵn có : ");
            QuantitySold = Console.ReadLine();

            Console.WriteLine("Nhập số lượng kế hoạch bán : ");
            PlannedSales = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập số lượng bán thực tế : ");
            ActualSales = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập khu vực : ");
            Region = Console.ReadLine();
        }


        public void Display()
        {
            Console.WriteLine($"Mã loại thuốc : {MedicineCode1}");
            Console.WriteLine($"Số lượng thuốc kho sẵn có : {QuantitySold1}");
            Console.WriteLine($"Số lượng kế hoạch bán : {PlannedSales1}");
            Console.WriteLine($"Số lượng bán thực tế : {ActualSales1}");
            Console.WriteLine($"Khu vực : {Region1}");

        }

        public void Display(int ActualSales)
        {
            Console.WriteLine($"Chênh lệch số lượng bán: {PlannedSales - ActualSales}");
        }
    }
}
