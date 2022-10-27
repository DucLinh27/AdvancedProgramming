using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ManagerSchool
{
    public class Point
    {
        private int pointID;
        public int PointID
        {
            get { return pointID; }
            set { pointID = value; }
        }
        private double mathpoint;
        public double Mathpoint
        {
            get { return mathpoint; }
               set { mathpoint = value; }
        }
        private double chemistrypoint;
        public double Chemistrypoint
        {
            get { return chemistrypoint; }
            set { chemistrypoint = value; }
        }

        private double physicspoint;
        public double Physicspoint
        {
            get { return physicspoint; }
            set { physicspoint = value; }
        }

        private Student student;
        public Student Student
        {
            get { return student; }
            set { student = value; }
        }


        public Point(int pointID, Student student,  double mathpoint, double chemistrypoint, double physicspoint)
        {
            PointID = pointID;
            Student = student;
            Mathpoint = mathpoint;
            Chemistrypoint = chemistrypoint;
            Physicspoint = physicspoint;
        }
        public Point()
        {
        }
        internal static void Add(Point points)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "PointID:"  + PointID+ 
                " StudentID:" + Student.StudentID +
                " Mathpoint:" + Mathpoint + 
                " Chemistrypoint:" + Chemistrypoint + 
                " Physicspoint:" + Physicspoint;
        }
    }
}
