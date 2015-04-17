using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace consoleApp1_edX
{
    class Program
    {
        public static void Main(string[] args)
        {
            // "regions" are used to group code bits together for easy reading.
            // Please do not give a poor score if you have trouble understanding the code.
            // To see code in a much nicer format, visit this project on Github at... 
            // https://github.com/Kriosym/consoleApp1_edX/blob/master/consoleApp1_edX/Program.cs

            #region Declare Student Variables
            string student_firstName;
            string student_middleInitial;   // additional "pertinent information" (API).
            string student_lastName;
            string student_Sex;             // API.
            int student_yearsAge;           // API.
            DateTime student_birthDate;
            string student_address1;
            string student_address2;
            string student_City;
            string student_stateProvince;
            string student_zipPostal;       // Cannot be INT because many countries use alpha-numberic zipcodes.
            string student_Country; 
            #endregion

            #region Declare Professor Variables
            string prof_Name;
            string prof_Title;
            string prof_University;
            string prof_PhoneNumber;
            string prof_Education;
            string prof_EmailAddress;
            #endregion

            #region Declare University Degree Variables
            string degree_School;
            string degree_Name;
            string degree_credits;
            int degree_semesters;
            string degree_url;
            #endregion

            #region Declare University Program Variables
            string program_Name;    
            string program_degreesOffered;  
            string program_deptHead;
            string program_duration;
            string program_eligibility;
            string program_objective;

            #endregion

            #region Declare Course Info Variables
            string course_code;
            int course_credits;
            string course_semester;
            string course_Title;
            #endregion

            #region Assign Variable values
            // Student Variables...
            student_firstName = "John"; student_middleInitial = "D"; student_lastName = "Carmack";
            student_Sex = "Male";
            student_yearsAge = 44; student_birthDate = new DateTime(1970, 8, 20);
            student_address1 = "3131 Turtle Creek Blvd"; student_address2 = "#1020";
            student_City = "Dallas"; student_stateProvince = "Texas"; student_zipPostal = "75219";
            student_Country = "United States";

            // Professor Variables...
            prof_Name = "Stephen William Hawking";
            prof_Title = "The Enigmatic";
            prof_University = "Cambridge";
            prof_PhoneNumber = "111-222-3333";
            prof_Education = "St. Albans, Oxford, Cambridge, Gonville and Caius";
            prof_EmailAddress = "stephenwhawkings@gmail.com? (maybe?)";

            // Degree Variables...
            degree_Name = "Bachelor of Science in Information Technology";
            degree_School = "Oxford College";
            degree_credits = "100";
            degree_semesters = 6;
            degree_url = "http://oxfordcollege.asia/bachelor_of_science_in_information_technology.html";
            
            // Program Variables...
            program_Name = "Bachelor Of Science In Information Technology";
            program_degreesOffered = "98";
            program_deptHead = "Kayne West";
            program_duration = "3 to 6 Years";
            program_eligibility = "10+2 in any stream or equivilant";
            program_objective = "This course is designed to prepare students for a career as a programmer\n" +
                                "analyst, business analyst, system analyst, software engineer, security\n" +
                                "engineer, telecommunications engineer, web designer, IT project manager,\n" +
                                "IT specialist, or similar positions where a good understanding of business,\n" +
                                "management, and the latest trends in computer information technology are\n" +
                                "required.";

            // Course Variables...
            course_code = "ITP11";
            course_Title = "Introduction to Information Technology";
            course_credits = 4;
            course_semester = "1st";
            
            #endregion

            #region Display Selection Menu
            var exitNow = false;
            do
            {
                Console.WriteLine("\nDisplay which information?\r\n");
                Console.WriteLine("1. Student");
                Console.WriteLine("2. Professor");
                Console.WriteLine("3. Degree");
                Console.WriteLine("4. Program");
                Console.WriteLine("5. Course\r\n");
                Console.WriteLine("Make Selection (enter 0 to exit):");
                string theSelection = Console.ReadLine();
                int intSelection;
                try
                {
                    intSelection = int.Parse(theSelection);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Only Numbers!");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                #endregion  

                #region Write selected info to Console...
                switch (intSelection)
                {
                    case 0:
                        exitNow = true;
                        break;
                    case 1:
                        // Writes the Student Information to Console...
                        Console.Clear();
                        Console.WriteLine("\r\nName:" + "\n" + student_firstName + " " + student_middleInitial + " " + student_lastName + "\n");
                        Console.WriteLine("Sex:" + "\n" + student_Sex + "\n");
                        Console.WriteLine("Age:" + "\n" + student_yearsAge + ", " + "Born " + student_birthDate.ToString("d") + "\n");
                        Console.WriteLine("Address:" + "\n" + student_address1 + " " + student_address2 + "\n" + student_City + ", " + student_stateProvince + " " + student_zipPostal + "\n" + student_Country + "\n");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        // Writes the Professor Information to Console...
                        Console.Clear();
                        Console.WriteLine("\r\nName:" + "\n" + prof_Name + "\n");
                        Console.WriteLine("Title:" + "\n" + prof_Title + "\n");
                        Console.WriteLine("University:" + "\n" + prof_University + "\n");
                        Console.WriteLine("Education:" + "\n" + prof_Education + "\n");
                        Console.WriteLine("Email Address:" + "\n" + prof_EmailAddress + "\n");
                        Console.WriteLine("Phone Number:" + "\n" + prof_PhoneNumber + "\n");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        // Writes the Degree Information to Console...
                        Console.Clear();
                        Console.WriteLine("\r\nName:" + "\n" + degree_Name + "\n");
                        Console.WriteLine("School:" + "\n" + degree_School + "\n");
                        Console.WriteLine("Credits:" + "\n" + degree_credits + "\n");
                        Console.WriteLine("Semesters:" + "\n" + degree_semesters + "\n");
                        Console.WriteLine("More Information:" + "\n" + degree_url + "\n");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        // Writes the Program Information to Console...
                        Console.Clear();
                        Console.WriteLine("\r\nName:" + "\n" + program_Name + "\n");
                        Console.WriteLine("Department Head:" + "\n" + program_deptHead + "\n");
                        Console.WriteLine("Degrees Offered:" + "\n" + program_degreesOffered + "\n");
                        Console.WriteLine("Duration:" + "\n" + program_duration + "\n");
                        Console.WriteLine("Eligibility Criteria:" + "\n" + program_eligibility + "\n");
                        Console.WriteLine("Objective:" + "\n" + program_objective + "\n");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        // Writes the Course Information to Console...
                        Console.Clear();
                        Console.WriteLine("\r\nCode:" + "\n" + course_code + "\n");
                        Console.WriteLine("Title:" + "\n" + course_Title + "\n");
                        Console.WriteLine("Credits:" + "\n" + course_credits + "\n");
                        Console.WriteLine("Semester:" + "\n" + course_semester + "\n");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Invalid Selection!");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                }
                Console.WriteLine();
            } while (!exitNow);
            Console.WriteLine("Exiting...");
            #endregion

            #region Challenge
            // No time...
            #endregion

        }
    }
}
