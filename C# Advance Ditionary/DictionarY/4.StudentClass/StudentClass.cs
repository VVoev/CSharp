using System;
using System.Collections.Generic;
using System.Text;

namespace TestStudents
{
    class Student
    {
        static int numberOfStudents = 0;
        private string firstName;
        private string middleName;
        private string lastName;
        private int course;
        private string specialty;
        private string university;
        private string eMail;
        private string phoneNumber;

        public Student(string firstName, string middleName, string lastName, int course, string specialty,
            string university, string eMail, string phoneNumber)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.course = course;
            this.specialty = specialty;
            this.university = university;
            this.eMail = eMail;
            this.phoneNumber = phoneNumber;
            numberOfStudents++;
        }

        public Student(string firstName, string lastName)
            : this(firstName, null, lastName, 0, null, null, null, null)
        {
        }

        public Student(string firstName, string lastName, string university)
            : this(firstName, null, lastName, 0, null, university, null, null)
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("First Name: " + firstName);
            sb.Append(System.Environment.NewLine);
            sb.Append("Middle Name: " + middleName);
            sb.Append(System.Environment.NewLine);
            sb.Append("Last Name: " + lastName);
            sb.Append(System.Environment.NewLine);
            sb.Append("Course: " + course);
            sb.Append(System.Environment.NewLine);
            sb.Append("Specialty: " + specialty);
            sb.Append(System.Environment.NewLine);
            sb.Append("University: " + university);
            sb.Append(System.Environment.NewLine);
            sb.Append("eMail: " + eMail);
            sb.Append(System.Environment.NewLine);
            sb.Append("Phone Number: " + phoneNumber);


            return sb.ToString();
        }
        public static int NumberOfStudents
        {
            get { return Student.numberOfStudents; }
            set { Student.numberOfStudents = value; }
        }
    }


    class Program
    {
        static List<Student> students = new List<Student>();
        static StringBuilder result = new StringBuilder();
        static void Main(string[] args)
        {
            StartTesting();
            PrintOutput();
        }

        static void StartTesting()
        {

            string line = Console.ReadLine();
            while (line != "End.")
            {
                string[] separators = { ",", "(", ")" };
                string[] expectedComand = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < expectedComand.Length; i++)
                {
                    expectedComand[i] = expectedComand[i].Trim();
                }
                ComandExecutes(expectedComand);
                line = Console.ReadLine();
            }
        }

        private static void ComandExecutes(string[] expectedComand)
        {
            switch (expectedComand[0])
            {
                case "AddStudent":
                    {
                        if (expectedComand.Length == 3)
                        {
                            students.Add(new Student(expectedComand[1], expectedComand[2]));
                            result.Append("Student added." + System.Environment.NewLine);
                        }
                        if (expectedComand.Length == 4)
                        {
                            students.Add(new Student(expectedComand[1], expectedComand[2], expectedComand[3]));
                            result.Append("Student added." + System.Environment.NewLine);
                        }
                        if (expectedComand.Length == 10)
                        {
                            students.Add(new Student(expectedComand[1], expectedComand[2], expectedComand[3],
                                int.Parse(expectedComand[4]), expectedComand[5],
                                expectedComand[6], expectedComand[7], expectedComand[8]));
                            result.Append("Student added." + System.Environment.NewLine);
                        }
                        break;
                    }
                case "PrintNumberOfStudents":
                    {
                        result.Append(Student.NumberOfStudents + System.Environment.NewLine);
                        break;
                    }
                case "PrintStudentsInfo":
                    {
                        foreach (var item in students)
                        {
                            result.Append(item.ToString() + System.Environment.NewLine);
                        }
                        break;
                    }
                default:
                    {
                        result.Append("Invalid Comand.");
                        break;
                    }

            }
        }

        static void ReadInput()
        {
            string line = Console.ReadLine();
            while (line != "End.")
            {
                string[] separators = { ",", "(", ")" };
                string[] expectedComand = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);


                line = Console.ReadLine();
            }
        }

        static void PrintOutput()
        {
            Console.WriteLine(result);
        }
    }
}

