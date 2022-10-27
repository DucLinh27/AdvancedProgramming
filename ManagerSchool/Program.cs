
using ManagerSchool;

class Program
{
    private static School school = new School();
    private static Student student = new Student();

    private static char isEndApp;

    static void Main(string[] args)
    {
        do
        {


            UICode.Title();
        MenuCommand:
            UICode.MenuForLogin();
            try
            {
                int optionForLogin = int.Parse(Console.ReadLine());
                do
                {
                    switch (optionForLogin)
                    {
                        case 1:
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("School-Login-----------");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("Enter Username of School: ");
                                string EnterUserName = Console.ReadLine();
                                Console.Write("Enter Password of School: ");
                                string EnterPassword = Console.ReadLine();
                                if (school.Login(EnterUserName, EnterPassword))
                                {
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Login Successfully");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    UICode.MenuForSchool();
                                    do
                                    {
                                        int optionForMenuSchool = int.Parse(Console.ReadLine());
                                        switch (optionForMenuSchool)
                                        {
                                            case 1:

                                                // Add Student
                                                school.AddInformationStudent();
                                                UICode.AddSuccessful();
                                                UICode.MenuForSchool();
                                                break;

                                            case 2:
                                                // Add Point
                                                try
                                                {
                                                    // Not genarate ID
                                                    Console.WriteLine("Enter point ID: ");
                                                    int pointID = int.Parse(Console.ReadLine());

                                                    // Enter student ID
                                                    Student newStudent = new Student();
                                                    newStudent.StudentID = UICode.EnterStudentID();

                                                    while (!school.SearchStudentID(newStudent.StudentID))
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine("Student ID not Exist. Please Enter Student ID again");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        newStudent.StudentID = UICode.EnterStudentID();
                                                    }
                                                    
                                                    Student studentObject = school.SearchStudentObject(newStudent.StudentID);


                                                    // Enter the rest of info

                                                    Console.WriteLine("Enter Mathpoint: ");
                                                    double Mathpoint = double.Parse(Console.ReadLine());
                                                    Console.WriteLine("Enter Chemistrypoint: ");
                                                    double Chemistrypoint = double.Parse(Console.ReadLine());
                                                    Console.WriteLine("Enter Physicspoint: ");
                                                    double Physicspoint = double.Parse(Console.ReadLine());
                                                    Point newPoint = new Point(pointID, studentObject, Mathpoint, Chemistrypoint, Physicspoint);


                                                    // Add new point to point list in student 
                                                    school.Points.Add(newPoint);
                                                    UICode.AddSuccessful();                                                  
                                                    UICode.MenuForSchool();
                                                    
                                                }
                                                catch (FormatException ex)
                                                {
                                                    Console.WriteLine("Please enter the number\n" + ex.Message);
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine("Error " + ex.Message);
                                                }
                                                break;

                                            case 3:
                                                // View Student
                                                school.PrintInformationOfStudent();
                                                UICode.MenuForSchool();
                                                break;


                                            case 4:
                                                // View Point
                                                school.PrintInformationOfPoint();
                                                UICode.MenuForSchool();
                                                break;

                                            case 5:
                                                //Update Student
                                                try
                                                {
                                                    int idStudentToUpdate = UICode.EnterStudentID();

                                                    while (!school.SearchStudentID(idStudentToUpdate))
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        UICode.UpdateFail();
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        idStudentToUpdate = UICode.EnterStudentID();
                                                    }

                                                    string NewName = UICode.EnterStudentName();
                                                    string NewEmail = UICode.EnterStudentEmail();
                                                    string NewAddress = UICode.EnterStudentAddress();
                                                    string NewPhone = UICode.EnterStudentPhone();

                                                    school.UpdateStudentByID(idStudentToUpdate, NewName, NewEmail, NewAddress, NewPhone);
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    UICode.UpdateSuccessful();
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    UICode.MenuForSchool();
                                                }
                                                catch (FormatException ex)
                                                {
                                                    Console.WriteLine("Please enter the number\n" + ex.Message);
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine("Error " + ex.Message);
                                                }
                                                break;

                                                
                                            case 6:
                                                // Update Point
                                                try
                                                {
                                                    int idPointToUpdate = UICode.EnterPointID();
                                                    while (!school.SearchPointID(idPointToUpdate))
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        UICode.UpdateFail();
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        idPointToUpdate = UICode.EnterPointID();
                                                    }
                                                    double Mathpoint = UICode.EnterMathPoint();
                                                    double Chemistrypoint = UICode.EnterChemistryPoint();
                                                    double Physicspoint = UICode.EnterPhysicsPoint();
                                                    school.UpdatePointByID(idPointToUpdate, Mathpoint, Chemistrypoint, Physicspoint);
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    UICode.UpdateSuccessful();
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    UICode.MenuForSchool();
                                                }
                                                catch (FormatException ex)
                                                {
                                                    Console.WriteLine("Please enter the number\n" + ex.Message);
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine("Error " + ex.Message);
                                                }
                                                break;
                                            case 7:
                                                // Delete Student
                                                try
                                                {
                                                    int idToDelete = UICode.EnterStudentID();
                                                    while (!school.SearchStudentID(idToDelete))
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        UICode.DeleteFail();
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        idToDelete = UICode.EnterStudentID();
                                                    }
                                                    school.DeleteStudentByID(idToDelete);
                                                    school.DeletePointByID(idToDelete);
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    UICode.DeleteSuccessful();
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    UICode.MenuForSchool();
                                                }
                                                catch (FormatException ex)
                                                {
                                                    Console.WriteLine("Please enter the number\n" + ex.Message);
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine("Error " + ex.Message);
                                                }
                                                break;
                                            case 8:
                                                // Delete Point
                                                try
                                                {
                                                    int idToDelete = UICode.EnterPointID();
                                                    while (!school.SearchPointID(idToDelete))
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        UICode.DeleteFail();
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        idToDelete = UICode.EnterPointID();
                                                    }
                                                    school.DeletePointByID(idToDelete);
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    UICode.DeleteSuccessful();
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    UICode.MenuForSchool();
                                                }
                                                catch (FormatException ex)
                                                {
                                                    Console.WriteLine("Please enter the number\n" + ex.Message);
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine("Error " + ex.Message);
                                                }
                                                break;
                                            case 9:
                                                //Search Student
                                                try
                                                {
                                                    int enterID = UICode.EnterStudentID();
                                                    while (!school.SearchStudentID(enterID))
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        UICode.SearchFail();
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        enterID = UICode.EnterPointID();
                                                    }
                                                    var studentInListBorrow = school.GetStudentByID(enterID);
                                                    Console.WriteLine(studentInListBorrow.ToString());
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    UICode.SearchSuccessful();
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    UICode.MenuForSchool();
                                                }
                                                catch (FormatException ex)
                                                {
                                                    Console.WriteLine("Please enter the number\n" + ex.Message);
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine("Error " + ex.Message);
                                                }
                                                break;
                                                
                                            case 10:
                                                //Search Point
                                                try
                                                {
                                                    int enterpointID = UICode.EnterStudentID();
                                                    while (!school.SearchStudentID(enterpointID))
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        UICode.SearchFail();
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        enterpointID = UICode.EnterPointID();
                                                    }
                                                    var pointInListBorrow = school.GetPointByID(enterpointID);
                                                    Console.WriteLine(pointInListBorrow.ToString());
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    UICode.SearchSuccessful();
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    UICode.MenuForSchool();
                                                }
                                                catch (FormatException ex)
                                                {
                                                    Console.WriteLine("Please enter the number\n" + ex.Message);
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine("Error " + ex.Message);
                                                }
                                                break;
                                               
                                            case 11:
                                                goto MenuCommand;
                                        }
                                    } while (true);
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Login Fail");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    UICode.MenuForLogin();
                                }
                            }
                            while (optionForLogin != 3);
                            break;
                        case 2:
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Student-Login-----------");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("Enter Username of Student: ");
                                string EnterUserName = Console.ReadLine();
                                Console.Write("Enter Password of Student: ");
                                string EnterPassword = Console.ReadLine();
                                student.Login(EnterUserName, EnterPassword);
                                if (student.Login(EnterUserName, EnterPassword))
                                {
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Login Successfully");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    UICode.MenuForStudent();
                                    do
                                    {
                                        int optionForMenuStudent = int.Parse(Console.ReadLine());
                                        switch (optionForMenuStudent)
                                        {
                                            case 1:
                                                //View Student
                                                school.PrintInformationOfStudent();
                                                UICode.MenuForStudent();
                                                break;
                                                
                                            case 2:
                                                // View Point
                                                school.PrintInformationOfPoint();
                                                UICode.MenuForStudent();
                                                break;
                                            case 3:
                                                //Search Student
                                                try
                                                {
                                                    int enterID = UICode.EnterStudentID();
                                                    while (!school.SearchStudentID(enterID))
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        UICode.SearchFail();
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        enterID = UICode.EnterPointID();
                                                    }
                                                    var studentInListBorrow = school.GetStudentByID(enterID);
                                                    Console.WriteLine(studentInListBorrow.ToString());
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    UICode.SearchSuccessful();
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    UICode.MenuForStudent();
                                                }
                                                catch (FormatException ex)
                                                {
                                                    Console.WriteLine("Please enter the number\n" + ex.Message);
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine("Error " + ex.Message);
                                                }
                                                break;
                                            case 4:
                                                //Search Point
                                                try
                                                {
                                                    int enterpointID = UICode.EnterStudentID();
                                                    while (!school.SearchStudentID(enterpointID))
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        UICode.SearchFail();
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        enterpointID = UICode.EnterPointID();
                                                    }
                                                    var pointInListBorrow = school.GetPointByID(enterpointID);
                                                    Console.WriteLine(pointInListBorrow.ToString());
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    UICode.SearchSuccessful();
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    UICode.MenuForStudent();
                                                }
                                                catch (FormatException ex)
                                                {
                                                    Console.WriteLine("Please enter the number\n" + ex.Message);
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine("Error " + ex.Message);
                                                }
                                                break;
                                            case 5:
                                                goto MenuCommand;
                                        }
                                    }
                                    while (true);
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Login Fail");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    UICode.MenuForLogin();
                                }
                            }
                            while (optionForLogin != 3);
                            break;
                        case 3:
                            Console.WriteLine("Thank you for using Library Management");
                            break;
                    }
                }
                while (optionForLogin < 3);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter the number\n" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
            Console.ReadLine();
            Console.WriteLine("Enter Y TO continue and N to stop");
            isEndApp = char.Parse(Console.ReadLine());
        } while (isEndApp == 'Y' || isEndApp == 'y');
        Console.WriteLine("Goood Bye!!!");
    }
}
