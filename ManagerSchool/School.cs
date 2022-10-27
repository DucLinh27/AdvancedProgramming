using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace ManagerSchool
{
    public class School : ILogin
    {
        List<Student> Students = new List<Student>();
        List<Point> points = new List<Point>();
        private int schoolID;
        public int SchoolID
        {
            get { return schoolID; }
            set { schoolID = value; }
        }
        public List<Point> Points { get => points; set => points = value; }
        public School(int schoolID)
        {
            SchoolID = schoolID;
        }
        public School()
        {
        }
        public bool Login(string usernameToCheck, string passwordToCheck)
        {
            string usernameCorrect = "School";
            string passwordCorrect = "School";
            if (usernameToCheck == usernameCorrect && passwordToCheck == passwordCorrect)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AddPoint(Point points)
        {
            Points.Add(points);
        }
        public void AddInformationStudent()
        {
            Student newStudent = new Student();
            newStudent.StudentID = UICode.EnterStudentID();
            newStudent.InputInformation();
            Students.Add(newStudent);

        }
        public void PrintInformationOfStudent()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" -----------------Students-List-----------------");
            foreach(var student in Students)
            {
                Console.WriteLine("Student: "+student.StudentID+" "+"Name: "
                    + student.Name+" "+"Email:"
                    + student.Email+" "+"Address: "
                    + student.Address+" "+"PhoneNumber:"
                    + student.PhoneNumber);
                
            }

            Console.ForegroundColor = ConsoleColor.White;
            
        }
        public void PrintInformationOfPoint()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" -----------------Point-List-----------------");
            foreach (var point in Points)
            {
                Console.WriteLine("PointID: " + point.PointID + " "+"StuentID:"
                    + point.Student.StudentID +" "+ "Mathpoint: "
                    + point.Mathpoint + " " + "Chemistrypoint:" 
                    + point.Chemistrypoint + " " + "Physicspoint: "
                    + point.Physicspoint);

            }

            Console.ForegroundColor = ConsoleColor.White;
        }
        
        public bool UpdatePointByID(int idPointToUpdate, double newMathPoint, double newChemistryPoint, double newPhysicsPoint)
        {
            var pointInList = Points.FirstOrDefault(n => n.PointID.Equals(idPointToUpdate));
            pointInList.Mathpoint = newMathPoint;
            pointInList.Chemistrypoint = newChemistryPoint;
            pointInList.Physicspoint = newPhysicsPoint;
            return true;
        }
        public bool UpdateStudentByID(int idStudentToUpdate, string newName, string newEmail, string newAddress, string newPhone)
        {
            var newStudent = Students.FirstOrDefault(n => n.StudentID.Equals(idStudentToUpdate));
            newStudent.Name = newName;
            newStudent.Email = newEmail;
            newStudent.Address = newAddress;
            newStudent.PhoneNumber = newPhone;

            Console.WriteLine("Update successfully");
            return true;
        }

        public bool DeletePointByID(int idPointToDelete)
        {
            var pointInList = Points.FirstOrDefault(n => n.PointID.Equals(idPointToDelete));
            Points.Remove(pointInList);
            return true;
        }
        public bool DeleteStudentByID(int idStudentToDelete)
        {
            var studentsInList = Students.FirstOrDefault(n => n.StudentID.Equals(idStudentToDelete));
            Students.Remove(studentsInList);
            return true;
        }
        public Point GetPointByID(int idPointToSearch)
        {
            var pointInList = Points.FirstOrDefault(x => x.PointID.Equals(idPointToSearch));
            return pointInList;
        }
        public Student GetStudentByID(int idStudentToSearch)
        {
            var studentInList = Students.FirstOrDefault(x => x.StudentID.Equals(idStudentToSearch));
            return studentInList;
        }
        
        public Student SearchStudentObject(int idStudentToSearch)
        {
            var studentInList = Students.FirstOrDefault(n => n.StudentID.Equals(idStudentToSearch));
            return studentInList;
        }


        public bool SearchStudentID(int idStudentToSearch)
        {
            var studentInList = Students.FirstOrDefault(n => n.StudentID.Equals(idStudentToSearch));
            if (studentInList == null)
            {
                return false;
            }
            return true;
        }
        public Point SearchObjectPoint(int idPointToSearch)
        {
            var pointInList = Points.FirstOrDefault(n => n.PointID.Equals(idPointToSearch));
            return pointInList;
        }
        public bool SearchPointID(int idPointToSearch)
        {
            var pointInList = Points.FirstOrDefault(n => n.PointID.Equals(idPointToSearch));
            if (pointInList == null)
            {
                return false;
            }
            return true;
        }
        


    }
}
