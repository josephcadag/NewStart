using System;

//Part 27
//get set properties
//properties with set accessor is write only
//properties with get accessor is read only
class Properties
{
    public class Student
    {
        private int _id;
        private string _name;
        private int _passingGrade = 75;
        private string _email;

        //Manual or many function
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        //Auto implemented properties
        public string City { get; set; }

        //For ID
        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student Id should not negative number");
                }
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }

        //For Name
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name should not empty");
                }
                this._name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._name) ? "No name" : this._name;
            }
        }

        //for Passing Grade
        public int PassingGrade
        {
            get
            {
                return this._passingGrade;
            }
        }
    }

    public static void Main10()
    {
        Student S1 = new Student();
        S1.Id = 190023;
        S1.Name = "joseph cadag";
        S1.City = "Makati City";
        S1.Email = "newstartjeffcadag@gmail.com";

        Console.WriteLine("ID = {0}", S1.Id);
        Console.WriteLine("Name = {0}", S1.Name);
        Console.WriteLine("Passing Grade = {0}", S1.PassingGrade);
        Console.WriteLine("City = {0}", S1.City);
        Console.WriteLine("Email = {0}", S1.Email);
    }
}
    
