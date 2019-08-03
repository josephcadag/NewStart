using System;

//Part 28
//struct is like a class
//can have a
//private field
//public properties
//constructor
//method
class Structs
{
    public struct Costumer
    {
        private int _id;
        private string _name;

        public int Id
        {
            get { return _id; }
            set { this._id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { this._name = value; }
        }

        public Costumer(int Id, string Name)
        {
            this._id = Id;
            this._name = Name;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Id = {0} && Name = {1}", this._id, this._name);
        }
    }

    public static void Main()
    {
        Costumer C1 = new Costumer();
        C1.Id = 111;
        C1.Name = "Joseph";
        C1.PrintDetails();

        Costumer C2 = new Costumer(112, "jeff");
        C2.PrintDetails();

        //object initializer syntax
        Costumer C3 = new Costumer()
        {
            Id = 113,
            Name = "seph"
        };
        C3.PrintDetails();
    }
}
