// See https://aka.ms/new-console-template for more information
namespace BT_Buoi1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hinhchunhat dt = new Hinhchunhat(5,10);
            //dt.changesize(6, 11, 0);
            //dt.xuat();
            Time time = new Time();
            time.nhap12();
            time.xuat24();

            Console.WriteLine("Nhap so giay ban muon them: ");
            int n = int.Parse(Console.ReadLine());
            time.Tanggio(n);
            Console.WriteLine("Dong ho sau khi duoc them {0} giay",n);
            time.xuat12();

            Console.WriteLine();

            Console.WriteLine("Nhap so giay ban muon giam: ");
            int m = int.Parse(Console.ReadLine());
            time.Giamgio(m);
            Console.WriteLine("Dong ho sau khi duoc them {0} giay", m);
            time.xuat12();

        }
    }
}
