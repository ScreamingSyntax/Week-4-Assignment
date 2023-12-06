
 
class Program
    {
    public static void Main(String[] args)
    {
        BankAccount account = new BankAccount("191991x");
        Car car = new Car("dadada", 1900, 1000f);
        account.Display();
        car.Display();
        Rectangle rectangle = new Rectangle(100, 200);
        rectangle.Display();
        Circle circle = new Circle();
        Console.WriteLine($"The Area is {circle.CalculateArea(2)}");
        Student student = new Student("John Doe", 20, "Computer Science");
        student.Introduce();
        Stack<int> stack = new Stack<int>();
        Console.WriteLine(stack.isEmpty());
        stack.Push(10);
        stack.Push(20);
        Console.WriteLine(stack.isEmpty());
        stack.getItems();
        Calender calender = new Calender();
        calender.PrintWeekDays();
        Point2D p1 = new Point2D(5f,2f);
        Point2D p2 = new Point2D(7f, 5f);
        AnotherClassThatUsesPoint2D ac = new AnotherClassThatUsesPoint2D();
        ac.CalculateDistance(p1, p2);
    }
}
