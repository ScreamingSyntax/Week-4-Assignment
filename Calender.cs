using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Calender {
    enum DaysOfWeek {Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday };
    public void PrintWeekDays()
    {
        Array values = Enum.GetValues(typeof(DaysOfWeek)); // So this gives me all the index of enums and output is 0 - 6
        foreach(int i in Enum.GetValues(typeof(DaysOfWeek) )){
            if (i != 0 && i != 6)
            {
                Console.WriteLine($" {Enum.GetName(typeof(DaysOfWeek), i)}");
                // Enum.getName gives me the element at that index so Since Saturday and Sunday are at index 0, 6 so we skip it
            }
        }
    }
}
