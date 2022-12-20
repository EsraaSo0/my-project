using System;

namespace Section_9;
public abstract class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public abstract void Print();
}
public class Student : Person
{
    public int Year;
    public float Gpa;
    public Student(string name, int age, int year, float gpa) : base(name, age)
    {
        Year = year;
        Gpa = gpa;
    }
    public override void Print()
    {
        Console.WriteLine
        ($"Name: {Name}, Age: {Age}, Gpa: {Gpa}");
    }
}

public class Staff : Person
{
    public double Salary;
    public int JoinYear;
    public Staff(string name, int age, double salary, int joinyear) : base(name, age)
    {
        Salary = salary;
        JoinYear = joinyear;
    }
    public override void Print()
    {
        Console.WriteLine
        ($"Name: {Name}, Age: {Age}, Salary: {Salary} , JoinYear : {JoinYear}");
    }

}
public class Database
{
    private int _currentIndex;
    public Person[] People = new Person[50];
    public void AddStudent(Student student)
    {
        People[_currentIndex++] = student;
    }
    public void AddStaff(Staff staff)
    {
        People[_currentIndex++] = staff;
    }
    public void PrintAll()
    {
        foreach(var item in People){
            item?.Print();
        }

    }

}

public class Program
{
    private static void Main()
    {
        var database = new Database();

        string  name="";
        int  age=0;
        int year=0;
        float gpa= 0;
        //

        double salary=0;

        int joinyear=0;
        //
        var student = new Student(name, age, year, gpa);
        database.AddStudent(student);
        var staff = new Staff(name, age,salary ,joinyear );
        database.AddStaff(staff);
        Console.WriteLine("Enter option\n1--> add student: \n2--> to add staff :\n3--> to print all :\n0--> to stop:");
        var option = Convert.ToInt32(Console.ReadLine());
        while (true)
        {
            switch (option)
            {
                case 0:
                    Console.WriteLine("Done !");
                    return;
                case 1:
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.Write("Age: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Year: ");
                    year = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Gpa: ");
                    gpa = Convert.ToSingle(Console.ReadLine());
                    database.AddStudent(student);
                    Console.WriteLine("Enter option\n1--> add student: \n2--> to add staff :\n3--> to print all :\n0--> to stop:");
                    option = Convert.ToInt32(Console.ReadLine());
                    break;
                case 2:
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.Write("Age: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Slary: ");
                    salary = Convert.ToInt32(Console.ReadLine());
                    Console.Write("JoinYear: ");
                    joinyear = Convert.ToInt32(Console.ReadLine());
                    database.AddStaff(staff);
                    Console.WriteLine("Enter option\n1--> add student: \n2--> to add staff :\n3--> to print all :\n0--> to stop:");
                    option = Convert.ToInt32(Console.ReadLine());
                    break;
                case 3:
                    database.PrintAll();

                    break;
                default:
                    return;

            }
        }
            
    }
}
