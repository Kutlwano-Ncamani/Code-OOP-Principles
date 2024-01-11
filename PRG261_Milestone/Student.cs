using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_Milestone
{
    // Enum to represent student gender
    enum Gender
    {
        Male =1,
        Female
    }

    // Enum to represent student qualification
    enum Qualification
    {
        Degree =1 ,
        Diploma
    }

    // Class to represent a student
    class Student
    {
        public int StudentID;
        public string Name;
        public string Surname;
        public Gender Gender;
        public string Email;
        public DateTime DateOfBirth;
        public string PhoneNumber;
        public Qualification Qualification;
        public decimal Discount;

        public Student(int studentID, string name, string surname, Gender gender, string email, DateTime dateOfBirth, string phoneNumber, Qualification qualification)
        {
            StudentID = studentID;
            Name = name;
            Surname = surname;
            Gender = gender;
            Email = email;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Qualification = qualification;
            Discount = CalculateDiscount();
        }

        // Calculate the discount based on student's age and gender
        private decimal CalculateDiscount()
        {
            decimal discount = 0;

            int age = DateTime.Now.Year - DateOfBirth.Year;

            if (age > 25)
            {
                if (Gender == Gender.Female)
                    discount = 0.3m;
                else if (Gender == Gender.Male)
                    discount = 0.19m;
            }

            return discount;
        }

        // Calculate the total fees after applying the discount
        public decimal CalculateTotalFees()
        {
            decimal baseFee = (Qualification == Qualification.Degree) ? 85000 : 45000;
            decimal discountedFee = baseFee - (baseFee * Discount);
            return discountedFee;
        }
    }

    // Class to manage the student registration system
    class StudentManagementSystem
    {
        private List<Student> students;

        public StudentManagementSystem()
        {
            students = new List<Student>();
        }

        // Register a new student
        public void RegisterStudent(Student student)
        {
            students.Add(student);
        }

        // Display details of all registered students
        public void DisplayRegisteredStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine("Student ID: " + student.StudentID);
                Console.WriteLine("Name: " + student.Name + " " + student.Surname);
                Console.WriteLine("Gender: " + student.Gender);
                Console.WriteLine("Email: " + student.Email);
                Console.WriteLine("Date of Birth: " + student.DateOfBirth.ToShortDateString());
                Console.WriteLine("Phone Number: " + student.PhoneNumber);
                Console.WriteLine("Qualification: " + student.Qualification);
                Console.WriteLine("Discount: " + (student.Discount * 100) + "%");
                Console.WriteLine("Total Fees: R" + student.CalculateTotalFees());
                Console.WriteLine();
            }
        }
    }
}
