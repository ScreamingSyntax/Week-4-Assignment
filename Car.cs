using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Car
{
    private String brand;
    private int year;
    private float price;
    public Car(String brand, int year, float price)
    {
        this.brand = brand;
        this.year = year;
        this.price = price;
    }
    public void Display()
    {
        Console.WriteLine($"The car brand is {this.brand}");
        Console.WriteLine($"The car year is {this.year}");
        Console.WriteLine($"The car price is {this.price}");
    }
}

