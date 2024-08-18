using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hdelegates
{
    public class StudentinfoClass
    {
        public delegate long DelegateNumber(long number);
        public delegate string DelegateText(string txt);

        public static string firstname = " ";
        public static string lastname = " ";
        public static string middlename = " ";
        public static string address = " ";
        public static string progrma = " ";

        public static long age = 0;
        public static long contactno = 0;
        public static long studentno = 0;

        public static string getfname (string fname)
        {
            return fname;
        }
        public static string getlname (string lname)
        {
            return lname;
        }
        public static string getmname (string mname)
        {
            return mname;
        }
        public string getaddress(string address)
        {
            return address;
        }
        public string getprogram(string program)
        {
            return program;
        }
        public long getage(long age)
        {
            return age;    
        }
        public long getcontactno(long contactno)
        {
            return contactno;
        }
        public long getstudentno(long studentno)
        {
            return studentno;
        }

    }
}
