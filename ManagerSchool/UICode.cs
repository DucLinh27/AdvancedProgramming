using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSchool
{
    class UICode
    {
        public static void Title()
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("** Welcom to Management  Students Point System **");
            Console.WriteLine("*********************************************");
        }
        public static void MenuForLogin()
        {
            Console.WriteLine();
            Console.WriteLine("1. Login as a School");
            Console.WriteLine("2. Login as a Student");
            Console.WriteLine("3. Exit");
            Console.WriteLine();
        }
        public static void MenuForSchool()
        {
            Console.WriteLine();
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Point");
            Console.WriteLine("3. View Student");
            Console.WriteLine("4. View Point");
            Console.WriteLine("5. UpdateStudentbyID");
            Console.WriteLine("6. UpdatePointbyID");
            Console.WriteLine("7. DeleteStudentID");
            Console.WriteLine("8. DeletePointID");
            Console.WriteLine("9. SearchStudentByID");
            Console.WriteLine("10. SearchPointByID");
            Console.WriteLine("11. Logout");
            Console.WriteLine();
            Console.WriteLine("Please choose your option");

        }
        public static void MenuForStudent()
        {
            Console.WriteLine();
            Console.WriteLine("1. View Student");
            Console.WriteLine("2. View Point");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Search Point");
            Console.WriteLine("5. Logout");
            Console.WriteLine();
            Console.WriteLine("Please choose your option");

        }
        public static int EnterPointID()
        {
            Console.Write("* Enter Point ID: ");
            return int.Parse(Console.ReadLine());
        }
        public static double EnterMathPoint()
        {
            Console.Write("* Enter Math Point: ");
            return double.Parse(Console.ReadLine());
        }
        public static double EnterChemistryPoint()
        {
            Console.Write("* Enter Chemistry Point: ");
            return double.Parse(Console.ReadLine());
        }
        public static double EnterPhysicsPoint()
        {
            Console.Write("* Enter Physics Point: ");
            return double.Parse(Console.ReadLine());
        }


        public static int EnterStudentID()
        {
            Console.Write("* Enter Student ID: ");
            return int.Parse(Console.ReadLine());
        }

        public static string EnterStudentName()
        {
            Console.Write("* Enter Student Name: ");
            return Console.ReadLine();
        }
        public static string EnterStudentEmail()
        {
            Console.Write("* Enter Student Email: ");
            return Console.ReadLine();
        }
        public static string EnterStudentAddress()
        {
            Console.Write("* Enter Student Address: ");
            return Console.ReadLine();
        }
        public static string EnterStudentPhone()
        {
            Console.Write("* Enter Student Phone: ");
            return Console.ReadLine();
        }



        public static void AddSuccessful()
        {
            Console.WriteLine("Add Successfully!!!");
        }
        public static void DeleteFail()
        {
            Console.WriteLine("Delete Fail!!!");
            Console.WriteLine("Please enter ID Again!!!");
        }
        public static void DeleteSuccessful()
        {
            Console.WriteLine("Delete successfully!!!");
        }
        public static void UpdateSuccessful()
        {
            Console.WriteLine("Update successfully!!!");
        }
        public static void UpdateFail()
        {
            Console.WriteLine("Update Fail!!!");
            Console.WriteLine("Please enter ID Again!!!");
        }
        public static void SearchFail()
        {
            Console.WriteLine("Search Fail!!!");
            Console.WriteLine("Please enter ID Again!!!");
        }
        public static void SearchSuccessful()
        {
            Console.WriteLine("Search successfully!!!");
        }



        public static void IdAlreadyExist()
        {
            Console.WriteLine("Id Already Exist. Please Enter Another ID !!!");
        }
        public static string TypeExitToFinish()
        {
            Console.WriteLine("Type Exit to Finish Option!!!");
            return Console.ReadLine();
        }

    }
}
