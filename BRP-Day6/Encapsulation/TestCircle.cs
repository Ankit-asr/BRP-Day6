using System;

namespace Encapsulation
{
    public class StudentEncapsulation
    {
        private String studentName;
        private int studentAge;
        public String Name
        {
            get
            {
                return studentName;
            }
            set
            {
                studentName = value;
            }
        }
        public int Age
        {
            get
            {
                return studentAge;
            }
            set
            {
                studentAge = value;
            }
        }
    }
    class GFG
    {
        static public void Main()
        {
            StudentEncapsulation obj = new StudentEncapsulation();
            obj.Name = "Ankit";
            obj.Age = 28;
            Console.WriteLine("Name: " + obj.Name);
            Console.WriteLine("Age: " + obj.Age);
        }
    }
}
