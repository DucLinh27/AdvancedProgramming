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
        private int studentID;
        public int StudentID
        {
            get { return studentID; }   
            set
            {
                studentID = value;
            }
        }
        public List<Point> Points { get => points; set => points = value; }


        public Student(int studentID)
        {
            StudentID = studentID;
        }
        public Student()
        {

        }

        public Student(int studentID, string name, string email, string address, string phoneNumber) : this(studentID)
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
        

        public override string ToString()
        {
            return "Student ID:" + StudentID +
                " Name:" + Name +
                " Email:" + Email +
                " Address:" + Address +
                " Phone:" + PhoneNumber;
                
        }

        
    }
}
