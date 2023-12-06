using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Student
    {
    private String name;
    private int age;
    private String major;
    public Student(string name, int age, string major)
    {
        this.name = name;
        this.age = age;
        this.major = major;
    }
    public void Introduce()
    {
        Console.WriteLine($"The student's name is {this.name}");
        Console.WriteLine($"The student's age is {this.age}");
        Console.WriteLine($"The student's major is {this.major}");
    }
}

