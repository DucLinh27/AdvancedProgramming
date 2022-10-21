using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSchool
{
    public class Student : Person, ILogin
    {
        List<Point> points = new List<Point>();
        public int StudentID { get; set; }
        public List<Point> Points { get => points; set => points = value; }


        public Student(int studentID)
        {
            StudentID = studentID;
        }
        public Student()
        {

        }
        public bool Login(string usernameToCheck, string passwordToCheck)
        {
            string usernameCorrect = "Student";
            string passwordCorrect = "Student";
            if (usernameToCheck == usernameCorrect && passwordToCheck == passwordCorrect)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void InputInformation()
        {
            this.Name = UICode.EnterStudentName();
            this.Email = UICode.EnterStudentEmail();
            this.Address = UICode.EnterStudentAddress();
            this.PhoneNumber = UICode.EnterStudentPhone();
            
        }



        public string PrintListPoint()
        {
            string x = "";
            foreach (var points in Points)
            {
                x += points.ToString();
            }
            return x;
        }
        public void AddPoint(Point point)
        {
            Point.Add(point);
        }

        public override string ToString()
        {
            return "Student ID:" + StudentID + " Name:" + Name + " Age:" + Email + " Address:" + Address + " Phone:" + PhoneNumber + "\n" + $"{PrintListPoint()}\n";
        }

        
    }
}
