using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Extensions
{
    class Student
    {
        private string _fullname;
        private string _groupNo;
        public byte Age;
        public byte Point;

        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {

                if (CheckFullname(value))
                {
                    _fullname = value;
                }
            }
        }

        public string GroupNo
        {
            get
            {
                return _groupNo;
            }
            set
            {
                if (CheckGroupNo(value))
                {
                    _groupNo = value;
                }
            }
        }



        public Student(string fullname, byte age, string groupno,byte point)
        {
            Fullname = fullname;
            Age = age;
            GroupNo = groupno;
            Point = point;
        }

        public static bool CheckFullname(string fullname)
        {
            string[] strArr = fullname.Split();

            bool result = false;
            if (strArr.Length == 2)
            {
                foreach (string item in strArr)
                {
                    if (char.IsUpper(item[0]))
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                        break;
                    }
                }
                return result;
            }
            return false;

        }


        public static bool CheckGroupNo(string no)
        {
            if(no.Length == 4)
            {
                if (char.IsUpper(no[0]))
                {
                    for (int i = 1; i < no.Length; i++)
                    {
                        if (!char.IsDigit(no[i]))
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }

            return false;
        }
    }
}
