using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Buoi1
{
    internal class Date
    {
        public int year;
        public int month;
        public int day;
        public void nhap()
        {
            while (true)
            {
                Console.WriteLine("Nhap nam: ");
                int tyear = int.Parse(Console.ReadLine());

                if (tyear <= 0)
                {
                    Console.WriteLine("Nam khong hop le. Vui long nhap lai.");
                    continue;
                }

                Console.WriteLine("Nhap thang: ");
                int tmonth = int.Parse(Console.ReadLine());
                if (tmonth <= 0 || tmonth > 12)
                {
                    Console.WriteLine("Thang khong hop le. Vui long nhap lai.");
                    continue;
                }

                Console.WriteLine("Nhap ngay: ");
                int tday = int.Parse(Console.ReadLine());

                if (tday <= 0 || tday > 31)
                {
                    Console.WriteLine("Ngay khong hop le. Vui long nhap lai.");
                    continue;
                }

                if (tday > 28 && tmonth == 2)
                {

                    if ((tyear % 4 == 0 && tyear % 100 != 0) || (tyear % 400 == 0))
                    {
                        Console.WriteLine("Nam nhuan.");
                    }
                    else
                    {
                        Console.WriteLine("Nam khong nhuan.");
                        continue;
                    }
                }

                if (tday == 31  && (tmonth == 2 || tmonth == 4 || tmonth == 6 || tmonth == 9 || tmonth == 11))
                {
                    Console.WriteLine("Ngay khong hop le. Vui long nhap lai");
                    continue;

                }
                day = tday;
                month = tmonth;
                year = tyear;
                break;
            }
        }

        public void result(ref int byear, ref int bmonth, ref int bday, ref int ayear, ref int amonth, ref int aday)
        {
            if (day == 1)
            {
                if (month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                {
                    bday = 31;
                    bmonth = month - 1;
                    byear = year;
                    aday = 2;
                    amonth = month;
                    ayear = year;

                }
                else if (month == 1)
                {
                    bday = 31;
                    bmonth = 12;
                    byear = year - 1;
                    aday = 2;
                    amonth = month;
                    ayear = year;
                }
                else if (month == 3)
                {
                    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                    {
                        bday = 29;
                        bmonth = month - 1;
                        byear = year;
                        aday = 2;
                        amonth = month;
                        ayear = year;
                    }
                    else
                    {
                        bday = 28;
                        bmonth = month - 1;
                        byear = year;
                        aday = 2;
                        amonth = month;
                        ayear = year;
                    }

                }
                else
                {
                    bday = 30;
                    bmonth = month - 1;
                    byear = year;
                    aday = 2;
                    amonth = month;
                    ayear = year;
                }
            }
            else if (day == 28)
            {
                if (month == 2 && (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    bday = day - 1;
                    bmonth = month;
                    byear = year;
                    aday = 29;
                    amonth = month;
                    ayear = year;
                }
                else
                {
                    bday = day - 1;
                    bmonth = month;
                    byear = year;
                    aday = 1;
                    amonth = month+1;
                    ayear = year;
                } 
            }
            else if (day == 29)
            {
                if (month == 2)
                {
                    bday = day - 1;
                    bmonth = month;
                    byear = year;
                    aday = 1;
                    amonth = month+1;
                    ayear = year;
                }
                else
                {
                    bday = day - 1;
                    bmonth = month;
                    byear = year;
                    aday = 30;
                    amonth = month;
                    ayear = year;
                }
            }    
            else if (day == 30) 
            {
                if (month == 4 || month == 6 || month == 9 || month == 11 )
                {
                    bday = day - 1;
                    bmonth = month;
                    byear = year;
                    aday = 1;
                    amonth = month + 1;
                    ayear = year;
                }
                else
                {
                    bday = 29;
                    bmonth = month;
                    byear = year;
                    aday = 31;
                    amonth = month;
                    ayear = year;
                } 
                    
            }
            else if (day == 31)
            {
                if (month == 12)
                {
                    bday = 30;
                    bmonth = month;
                    byear = year;
                    aday = 1;
                    amonth = 1;
                    ayear = year+1;
                }
                else
                {
                    bday = 30;
                    bmonth = month;
                    byear = year;
                    aday = 1;
                    amonth = month + 1;
                    ayear = year;
                }
            }
            else
            {
                bday = day - 1;
                bmonth = month;
                byear = year;
                aday = day + 1;
                amonth = month;
                ayear = year;
            }
        }
    }
}
