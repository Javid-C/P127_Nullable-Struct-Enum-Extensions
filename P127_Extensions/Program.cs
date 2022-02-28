using System;

namespace P127_Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework
            //string fullname;

            //string groupNo;

            //do
            //{
            //    Console.WriteLine("Please write fullname");

            //    fullname = Console.ReadLine();
            //} while (!Student.CheckFullname(fullname));


            //do
            //{
            //    Console.WriteLine("Please choose group no");
            //    groupNo = Console.ReadLine();
            //} while (!Student.CheckGroupNo(groupNo));


            //Student student = new Student(fullname, 20, groupNo);

            //Console.WriteLine(student.Fullname + " " + student.GroupNo + " " + student.Age);
            #endregion

            // Nullable

            //string name = null;

            //if(name == null)
            //{
            //    Console.WriteLine("Null deyer menimsedilib");
            //}
            //else
            //{
            //    Console.WriteLine(name);
            //}


            //bool? number = null;
            //Console.WriteLine(number == null);


            //string str = Console.ReadLine();
            //int num;
            //bool result = int.TryParse(str, out num);


            //if (result)
            //{
            //    switch (num)
            //    {
            //        case (int)MyEnum.Monday:
            //            Console.WriteLine(MyEnum.Monday);
            //            break;
            //        case (int)MyEnum.Tuesday:
            //            Console.WriteLine(MyEnum.Tuesday);
            //            break;
            //        case (int)MyEnum.Wednesday:
            //            Console.WriteLine(MyEnum.Wednesday);
            //            break;
            //        case (int)MyEnum.Thursday:
            //            Console.WriteLine(MyEnum.Thursday);
            //            break;
            //        case (int)MyEnum.Friday:
            //            Console.WriteLine(MyEnum.Friday);
            //            break;
            //        case (int)MyEnum.Saturday:
            //            Console.WriteLine(MyEnum.Saturday);
            //            break;
            //        case (int)MyEnum.Sunday:
            //            Console.WriteLine(MyEnum.Sunday);
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Reqem daxil edin");
            //}


            //foreach (string item in Enum.GetNames(typeof(MyEnum)))
            //{
            //    if (item.Contains("Fri"))
            //    {
            //        Console.WriteLine(item);
            //    }
            //}


            //Struct

            MySturct mySturct = new MySturct(2,3);
            
            Console.WriteLine(mySturct.Space(2,3));

            string name = "luTFiyAR";

            Console.WriteLine(name.isCapitalized());


            //string name = "Avaz";
            //Console.WriteLine(name.Contains("a"));

            Student student = new Student("Rabil Elekberov",21,"P127",49);

            Console.WriteLine(student.Passed());

            Console.WriteLine(name.ToCapitalized());

        }
    }
}
