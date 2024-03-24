namespace BT_Buoi1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sochinhphuong dt =new Sochinhphuong();
            //dt.nhap();
            //dt.xuat();

            //Date dt = new Date();
            //dt.nhap();

            //int byear =0, bmonth = 0, bday = 0, ayear = 0, amonth = 0, aday = 0;
            //dt.result(ref byear, ref bmonth, ref bday, ref ayear, ref amonth, ref aday);


            //Console.WriteLine("Gia tri cua ngay thang nam truoc ngay duoc nhap la {0} {1} {2}", aday, amonth, ayear);
            //Console.WriteLine("Gia tri cua ngay thang nam sau ngay duoc nhap la {0} {1} {2}", bday, bmonth, byear);


            NumberArray dt = new NumberArray();
            dt.TaomangRandom(20);

            //Xuatmang
            dt.Xuatmang();


            // Daomang
            dt.Daomang();
            Console.WriteLine("Day so sau khi dao:");
            dt.Xuatmang();
            Console.WriteLine();

            // Tim so x
            Console.WriteLine("Nhap so can tim:");
            int x = int.Parse(Console.ReadLine());
            if (dt.Timso(x))
                Console.WriteLine($"Day so chua so {x}.");
            else
                Console.WriteLine($"Day so khong chua so{x}.");
            Console.WriteLine();

            // Xuat cac phan tu co 2 chu so
            List<int> phantu2chuso = dt.ptu2chuso();
            Console.WriteLine("Cac so co 2 chu so la:");
            foreach (var number in phantu2chuso)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            // xuat cac so chan
            List<int> phantusochan = dt.ptusochan();
            Console.WriteLine("Cac so chan:");
            foreach (var number in phantusochan)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine();


            // Xuat cac so nguyen to 
            List<int> phantusont = dt.ptusont();
            Console.WriteLine("Cac so nguyen to:");
            foreach (var number in phantusont)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            // Xoa cac phan tu le va boi cua 3
            dt.xoacacptlevaboi3();
            Console.WriteLine("Day so sau khi bi xoa so le va boi cua 3:");
            dt.Xuatmang();
            Console.WriteLine();

            // Tang gia tri cua cac so nho hon 2 so lien ke
            dt.Tanggiatri1();
            Console.WriteLine("Day so sau khi ang gia tri cua cac so nho hon 2 so lien ke:");
            dt.Xuatmang();
            Console.WriteLine();

            // Sap xep day so tang dan
            dt.SortAscending();
            Console.WriteLine("Day so sau khi sap xep tang dan:");
            dt.Xuatmang();
            Console.WriteLine();

            // Sap xep day so giam dan dan
            dt.SortDescending();
            Console.WriteLine("Day so sau khi sap xep giam dan:");
            dt.Xuatmang();
            Console.WriteLine();

        }
    }
}