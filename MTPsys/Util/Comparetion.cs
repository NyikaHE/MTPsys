using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MTPsys.Util
{
    class Comparetion
    {
        public struct Time
        {
            public int m;       //分
            public int s;       //秒
            public int ms;      //毫秒
        }
        //6段表
        public string getGroup(int age)
        {
            if (age <= 24)
            {
                return "M0";
            }
            else if (age >= 25 && age <= 29)
            {
                return "M1";
            }
            else if (age >= 30 && age <= 39)
            {
                return "M2";
            }
            else if (age >= 40 && age <= 49)
            {
                return "M3";
            }
            else if (age >= 50 && age <= 59)
            {
                return "M4";
            }
            else
            {
                return "M5";
            }
        }
        //13段表
        public string getGroup1(int age)
        {
            if (age <= 24)
            {
                return "M0";
            }
            else if (age >= 25 && age <= 27)
            {
                return "M1";
            }
            else if (age >= 28 && age <= 30)
            {
                return "M2";
            }
            else if (age >= 31 && age <= 33)
            {
                return "M3";
            }
            else if (age >= 34 && age <= 36)
            {
                return "M4";
            }
            else if (age >= 37 && age <= 39)
            {
                return "M5";
            }
            else if (age >= 40 && age <= 42)
            {
                return "M6";
            }
            else if (age >= 43 && age <= 45)
            {
                return "M7";
            }
            else if (age >= 46 && age <= 48)
            {
                return "M8";
            }
            else if (age >= 49 && age <= 51)
            {
                return "M9";
            }
            else if (age >= 52 && age <= 54)
            {
                return "M10";
            }
            else if (age >= 55 && age <= 57)
            {
                return "M11";
            }
            else
            {
                return "M12";
            }
        }
        //时间比较,第一段时间大于第二段时间返回true；
        public Boolean Compare(string r1, string r2)
        {
            Time t1, t2;
            t1 = GetTime(r1);
            t2 = GetTime(r2);
            if (t1.m > t2.m)
            {
                return true;
            }
            else if (t1.m == t2.m && t1.s > t2.s)
            {
                return true;
            }
            else if (t1.m == t2.m && t1.s == t2.s && t1.ms >= t2.ms * 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean Compare1(string r1, string r2)
        {
            Time t1, t2;
            t1 = GetTime(r1);
            t2 = GetTime(r2);
            if (t1.m < t2.m)
            {
                return true;
            }
            else if (t1.m == t2.m && t1.s < t2.s)
            {
                return true;
            }
            else if (t1.m == t2.m && t1.s == t2.s && t1.ms <= t2.ms * 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //字符串切割；
        public Time GetTime(string t)
        {
            Time gol;
            int[] num = new int[3];
            int j = 2;
            string[] sArray = t.Split(new char[6] { '“', '”', '’', '‘', '\u0027', '"' });
            for (int i = sArray.Length - 1; i >= 0; i--)
            {
                if (sArray[i] != "")
                {
                   
                    try
                    {
                        num[j] = Convert.ToInt32(sArray[i]);
                    }
                    catch (Exception ex)
                    {
                        num[j] = 0;
                        
                        MessageBox.Show(ex.Message, t);
                    }

                }
                j--;
            }
            gol.m = num[0];
            gol.s = num[1];
            gol.ms = num[2];
            return gol;
        }
    }
}
