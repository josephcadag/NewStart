using System;

//Part 26 Why properties (getter setter)
//ID should not equal to negative value
//Name should not null (default string "No name")
//Passing grade shold not edit
//to do that set all in private
class WhyProperties
{
    public class Student
    {
        private int _id;
        private string _name;
        private int _passingGrade = 70;

        //For ID
        public void SetId(int Id)
        {
            if (Id <= 0)
            {
                throw new Exception("Student Id should not negative number");
            }
            this._id = Id;
        }
     
        public int GetId()
        {
            return this._id;
        }

        //For Name
        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name should not empty");
            }
            this._name = Name;
        }

        public string GetName()
        {
            //Ternary Operator
            return string.IsNullOrEmpty(this._name) ? "No name" : this._name;

            //if (string.IsNullOrEmpty(this._name))
            //{
            //    return "No name";
            //}
            //else
            //{
            //    return this._name;
            //}
        }

        //for Passing Grade
        public int GetPassingGrade()
        {
            return this._passingGrade;
        }
    }

    public static void Main()
    {
        Student S1 = new Student();
        S1.SetId(190023);
        S1.SetName("joseph cadag");

        Console.WriteLine("ID = {0}", S1.GetId());
        Console.WriteLine("Name = {0}", S1.GetName());
        Console.WriteLine("Passing Grade = {0}", S1.GetPassingGrade());
    }
}