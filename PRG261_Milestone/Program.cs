using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PRG_Milestone
{
    internal class Program
    {
        /*
         Kutlwano Ncamani 577489
         Zukhanye Lithemba Mavuso 577851
         Ayanda Shanelle Vungwana 577874
         */
        static void Main(string[] args)
        {
            string choice;
            // Create a student management system
            StudentManagementSystem managementSystem = new StudentManagementSystem();
            Console.WriteLine("Welcome To Belgium Campus (Stellenbosch Campus) Registration");
            do
            {
                // Ask the user to input values for a new student
                Console.WriteLine("Please enter your Student ID");
                int studentID = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter your Name");
                string name = Console.ReadLine();

                Console.WriteLine("Please enter your Surname");
                string surname = Console.ReadLine();

                Console.WriteLine("Gender (Please enter 1 for Male or 2 for Female)");
                Gender gender = (Gender)int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter your email");
                string email = Console.ReadLine();

                Console.WriteLine("Please enter your date of birth in this format (yyyy-mm-dd)");
                DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Please enter your Phone number ");
                string phoneNumber = Console.ReadLine();

                Console.WriteLine("Qualification (Please enter 1 for Degree or 2 for Diploma)");
                Qualification qualification = (Qualification)int.Parse(Console.ReadLine());

                // Create a new student object with the input values
                Student student = new Student(studentID, name, surname, gender, email, dateOfBirth, phoneNumber, qualification);


                // Register some sample students
                managementSystem.RegisterStudent(new Student(studentID, name, surname, gender, email, dateOfBirth, phoneNumber, qualification));


                Console.WriteLine("Would you like to add another student? (y/n)");
                choice = Console.ReadLine();
                Console.Clear();
            } while (choice == "y");

            Console.WriteLine("This is a list of all the registered students");
            Console.WriteLine("---------------------------------------------");
            managementSystem.DisplayRegisteredStudents();
            Console.WriteLine("------------PRESS ANY KEY TO EXIT------------");

            Console.ReadLine(); 
        }
    }
}
