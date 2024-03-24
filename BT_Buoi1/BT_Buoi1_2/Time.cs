using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BT_Buoi1_2
{
    internal class Time
    {
        int hour;
        int minute;
        int second;
        string period;
        public void nhap24()
        {
            while (true)
            {
                Console.WriteLine("Nhap gio: ");
                int thour = int.Parse(Console.ReadLine());

                if (thour < 0 || thour >= 24)
                {
                    Console.WriteLine("Gio khong hop le. Vui long nhap lai.");
                    continue;
                }

                Console.WriteLine("Nhap phut: ");
                int tminute = int.Parse(Console.ReadLine());

                if (tminute < 0 || tminute >= 60)
                {
                    Console.WriteLine("Thang khong hop le. Vui long nhap lai.");
                    continue;
                }

                Console.WriteLine("Nhap giay: ");
                int tsecond = int.Parse(Console.ReadLine());

                if (tminute < 0 || tminute >= 60)
                {
                    Console.WriteLine("Ngay khong hop le. Vui long nhap lai.");
                    continue;
                }
                second = tsecond;
                minute = tminute;
                hour = thour;
                break;
            }
        }
        public void nhap12()
        {
            while (true)
            {
                Console.WriteLine("Nhap sang hay toi: ");
                string tday_night = Console.ReadLine();

                if (tday_night != "PM" && tday_night != "AM")
                {
                    Console.WriteLine("Gia tri khong hop le. Vui long nhap lai.");
                    continue;
                }

                Console.WriteLine("Nhap gio: ");
                int thour = int.Parse(Console.ReadLine());

                if (thour < 0 || thour >= 12)
                {
                    Console.WriteLine("Gio khong hop le. Vui long nhap lai.");
                    continue;
                }

                Console.WriteLine("Nhap phut: ");
                int tminute = int.Parse(Console.ReadLine());

                if (tminute < 0 || tminute >= 60)
                {
                    Console.WriteLine("Thang khong hop le. Vui long nhap lai.");
                    continue;
                }

                Console.WriteLine("Nhap giay: ");
                int tsecond = int.Parse(Console.ReadLine());

                if (tminute < 0 || tminute >= 60)
                {
                    Console.WriteLine("Ngay khong hop le. Vui long nhap lai.");
                    continue;
                }
                second = tsecond;
                minute = tminute;
                hour = thour;
                period = tday_night;
                break;
            }
        }

        public void xuat24()
        {
            if (period == "PM")
            {
                hour += 12;
            }
            Console.WriteLine("Thoi gian hien tai la {0}:{1}:{2}",hour,minute,second);
            Console.WriteLine();
        }
        public void xuat12()
        {
            string period = "";
            if (hour < 12)
            {
                period = "AM";
            }
            else
            {
                period = "PM";
            }
            updatePeriod();
            Console.WriteLine("Thoi gian hien tai la {0}:{1}:{2} ", hour, minute, second + period);
            Console.WriteLine();
        }
        public Time()
        {
            hour = minute = second = 0;
        }
        public Time (int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
            this.period = "AM";
        }
        public void Tanggio(int soGiay)
        {
            int psecond = soGiay % 60;
            int pminute = (soGiay / 60) % 60;
            int phour = soGiay / 3600;

            second += psecond;
            if (second >= 60)
            {
                second -= 60;
                minute++;
            }

            minute += pminute;
            if (minute >= 60)
            {
                minute -= 60;
                hour++;
            }

            hour += phour;
            if (hour >= 24)
            {
                hour %= 24;
            }
        }

        public void Giamgio(int soGiay)
        {
            int psecond = soGiay % 60;
            int pminute = (soGiay / 60) % 60;
            int phour = soGiay / 3600;

            second -= psecond;
            if (second < 0)
            {
                second += 60;
                minute--;
            }

            minute -= pminute;
            if (minute < 0)
            {
                minute += 60;
                hour--;
            }

            hour -= phour;
            if (hour < 0)
            {
                hour = 24 + (hour % 24);
            }
        }

        private void updatePeriod()
        {
            if (hour >= 12)
            {
                period = "PM";
                if (hour > 12)
                {
                    hour -= 12;
                }
            }
            else
            {
                period = "AM";
                if (hour == 0)
                {
                    hour = 12;
                }
            }
        }
    }
}
