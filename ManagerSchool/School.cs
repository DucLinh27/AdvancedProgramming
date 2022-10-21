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
        public List<Student> Students = new List<Student>();
        List<Point> points = new List<Point>();

        private int schoolID;
        public int SchoolID
        {
            get { return schoolID; }
            set { schoolID = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
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
        public void AddPoints(Point points)
        {
           
            Points.Add(points);
        }
        public void PrintInformationOfStudent()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" -----------------Students-List-----------------");
            /*ConsoleTable.From<Student>(Students).Write()*/;
            foreach(var student in Students)
            {
                Console.WriteLine("Student: "+student.StudentID+" "+"Name: "+ student.Name+" "+"Email:"+ student.Email+" "+"Address: "+ student.Address+" "+"PhoneNumber:"+ student.PhoneNumber);
                
            }

            Console.ForegroundColor = ConsoleColor.White;
            /*if (!Students.Any())
            {
                Console.WriteLine("Invalid result, Please Do Select 1");
                Console.WriteLine("*****************");
                
            }*/
        }
        public void PrintInformationOfPoint()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" -----------------Point-List-----------------");
            /*ConsoleTable.From<Student>(Students).Write()*/
            foreach (var point in Points)
            {
                Console.WriteLine("PointID: " + point.PointID + " "+"Stuent:"
                    + point.Student.Name + "Mathpoint: "
                    + point.Mathpoint + " " + "Chemistrypoint:" 
                    + point.Chemistrypoint + " " + "Physicspoint: "
                    + point.Physicspoint);

            }

            Console.ForegroundColor = ConsoleColor.White;
            /*if (!Students.Any())
            {
                Console.WriteLine("Invalid result, Please Do Select 1");
                Console.WriteLine("*****************");
                
            }*/
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
        public bool UpdatePointByID(int idPointToUpdate, double newMathPoint, double newChemistryPoint, double newPhysicsPoint)
        {
            var pointInList = Points.FirstOrDefault(n => n.PointID.Equals(idPointToUpdate));
            pointInList.Mathpoint = newMathPoint;
            pointInList.Chemistrypoint = newChemistryPoint;
            pointInList.Physicspoint = newPhysicsPoint;
            return true;
        }
       /* public bool UpdateStudentByID(int idStudentToUpdate, string name, string email, string address, string phonenumber)
        {
            var studentInList = Points.FirstOrDefault(n => n.PointID.Equals(idStudentToUpdate));
            studentInList.Name = name;
            studentInList.Email = email;
            studentInList.Address = address;
            studentInList.PhoneNumber = phonenumber;
            return true;
        }*/
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
        public void AddInformationStudent()
        {
            Student newStudent = new Student();
            newStudent.StudentID = UICode.EnterStudentID();
            newStudent.InputInformation();

            Students.Add(newStudent);
            
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
        public Point SearchObjectPoint(int idBookToSearch)
        {
            var pointInList = Points.FirstOrDefault(n => n.PointID.Equals(idBookToSearch));
            return pointInList;
        }
        public bool UpdateStudentByID(int idBookToUpdate, string newName, string newEmail, string newAddress, string newPhone)
        {
            var newStudent = Students.FirstOrDefault(n => n.StudentID.Equals(idBookToUpdate));
            newStudent.Name = newName;
            newStudent.Email = newEmail;
            newStudent.Address = newAddress;
            newStudent.PhoneNumber = newPhone;

            Console.WriteLine("Update successfully");
            return true;
        }


    }
}
