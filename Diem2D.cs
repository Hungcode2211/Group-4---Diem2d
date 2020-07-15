using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemKhongGian
{
  
    public class Diem2D
    {
        
        float hoanhDo;
        float tungDo;

        
        public Diem2D()
        {
            hoanhDo = tungDo = 0f;
        }

       
        public Diem2D(float x)
        {
            this.hoanhDo = x;
            tungDo = 0;
        }
        
        // hàm khởi tạo truyền vào hoành độ và tung độ
        public Diem2D(float x, float y)
        {
            this.hoanhDo = x;
            this.tungDo = y;
        }

        // hai thành phần trả về hoành độ và tung độ
        public float HoanhDo { get => hoanhDo; }
        public float TungDo { get => tungDo; }

        // phương thức cộng.
       
        public Diem2D Cong(Diem2D b)
        {
            return new Diem2D(b.hoanhDo + this.hoanhDo, b.tungDo + this.tungDo);
        }

        // phương thức trừ.
       
        public Diem2D Tru(Diem2D b)
        {
            return new Diem2D(this.hoanhDo - b.hoanhDo, this.tungDo - b.tungDo);
        }

        // tính khoảng cách của điểm hiện tại và điểm b bằng công thức: sqrt((a - c)^2 + (b - d)^2) với X(a, b), Y(c, d)
        public double TinhKhoangCach(Diem2D b)
        {
            double ketqua = (this.hoanhDo - b.hoanhDo) * (this.hoanhDo - b.hoanhDo) + (this.tungDo - b.tungDo) * (this.tungDo - b.tungDo);
            return Math.Sqrt(ketqua);
        }

        // tính điểm đối xứng qua tâm O(0, 0) bằng công thức: với Y(0 - a, 0 - b), với Y là điểm đối xứng của X(a, b).
        public Diem2D DoiXung()
        {
            return new Diem2D(0 - this.hoanhDo, 0 - this.tungDo);
        }

        // nhập điểm cho Diem2D
        public void NhapDiem2D()
        {
            Console.Write("\nDiem M(x, y), nhap x = ");
            while(!float.TryParse(Console.ReadLine(), out this.hoanhDo))
                Console.Write("Nhập lại x = ");

            Console.Write("\nDiem M({0}, y), nhap y = ", this.hoanhDo);
            while (!float.TryParse(Console.ReadLine(), out this.tungDo))
                Console.Write("Nhap lại y = ");
        }

        //kết quả dạng string, có dạng (x, y).
        public string ConvertToString()
        {
            return "(" + hoanhDo + ", " + tungDo + ")";
        }
    }
   
}

