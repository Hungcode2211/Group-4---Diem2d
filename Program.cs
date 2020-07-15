using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemKhongGian
{
    class Program
    {
        static void Main(string[] args)
        {
            Diem2D diem2d = new Diem2D();
            diem2d.NhapDiem2D();
            
            
            Console.WriteLine("Diem 2D vua nhap: " + diem2d.ConvertToString());

            Diem2D diem2d1 = new Diem2D(3, -2);
            Console.WriteLine("Diem 2D thu 2: " + diem2d1.ConvertToString());

            Console.WriteLine("\nTong hai diem: " + diem2d.Cong(diem2d1).ConvertToString());
            Console.WriteLine("\nHieu hai diem: " + diem2d.Tru(diem2d1).ConvertToString());
            Console.WriteLine("\nKhoang cach diem {0} va {1} la: {2}" , diem2d.ConvertToString(), diem2d1.ConvertToString(), diem2d.TinhKhoangCach(diem2d1));
            Console.WriteLine("\nDoi xung cua diem {0} la: {1}", diem2d.ConvertToString(), diem2d.DoiXung().ConvertToString());
            Console.WriteLine("\nDoi xung cua diem {0} la: {1}", diem2d1.ConvertToString(), diem2d1.DoiXung().ConvertToString());

            Console.ReadLine();
        }
    }
}
