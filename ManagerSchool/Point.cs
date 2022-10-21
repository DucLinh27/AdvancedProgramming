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
        public int PointID { get; set; }
        public double Mathpoint { get; set; }
        public double Chemistrypoint { get; set; }

        public double Physicspoint { get; set; }

        public Student Student { get; set; }


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
            return "PointID:" + PointID + " Mathpoint:" + Mathpoint + " Chemistrypoint:" + Chemistrypoint + " Physicspoint:" + Physicspoint;
        }
    }
}
