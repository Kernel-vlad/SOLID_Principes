using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System;

class Program
{

    static void Main()
    {
        var notificationService = new NotificationService(new EmailSender());
        notificationService.Notify("Hello via Email!");

        var SmsNotificationService = new NotificationService(new SmsSender());
        SmsNotificationService.Notify("Hello via SMS!");
    }
}


// S — Single Responsibility Principle (Принцип єдиної відповідальності)
public class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }
}
public class SalaryCalculator
{
    public decimal CalculatePay(Employee employee)
    {

        return employee.Salary * 0.1m;
    }
}

public class EmployeeRepository
{
   public void Save(Employee employee)
    {
       Console.WriteLine($"Employee {employee.Name} with salary {employee.Salary} saved to the database.");
    }
}

public class EmployeeReportService
{
    public void GenerateReport(Employee employee)
    {
        Console.WriteLine($"Generating report for employee {employee.Name} with salary {employee.Salary}.");
    }
}

// O — Open/Closed Principle (Принцип відкритості/закритості)
public abstract class Shape
{
    public abstract double CalculateArea();
}
public class Circle : Shape
{
    public double Radius { get; set; }
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangles : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public override double CalculateArea()
    {
        return Width * Height;
    }
}

public class Triangle : Shape
{
    public double Base { get; set; }
    public double Height { get; set; }
    public override double CalculateArea()
    {
        return 0.5 * Base * Height;
    }
}
public class AreaCalculator
{
    public double CalculateArea(Shape shape)
    {
        return shape.CalculateArea();
    }
}
// L — Liskov Substitution Principle (Принцип підстановки Барбари Лісков)
public class Rectangle
{
    public virtual double Width { get; set; }
    public virtual double Height { get; set; }

    public double GetArea()
    {
        return Width * Height;
    }
}

public class Square : Rectangle
{
    public override double Width
    {
        get { return base.Width; }
        set { base.Width = value; base.Height = value; }
    }
    public override double Height
    {
        get { return base.Height; }
        set { base.Height = value; base.Width = value; }
    }
    public interface IShape
    {
        double GetArea();
    }
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double GetArea()
        {
            return Width * Height;
        }
    }
}
// I — Interface Segregation Principle (Принцип розділення інтерфейсів)
public interface IWorkable
{
    void Work();
}
public interface IEat
{
    void Eat();
}

public class HumanWorker : IWorkable, IEat
{
    public void Work()
    {
        Console.WriteLine("Human is working.");
    }
    public void Eat()
    {
        Console.WriteLine("Human is eating.");
    }
}
public class RobotWorker : IWorkable
{
    public void Work()
    {
        Console.WriteLine("Robot is working.");
    }
}
// D — Dependency Inversion Principle (Принцип інверсії залежностей)
public interface IMessageSender
{
    void SendMessage(string message);
}
public class EmailSender : IMessageSender
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending email: {message}");
    }
}
public class SmsSender : IMessageSender
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending SMS: {message}");
    }
}
public class NotificationService
{
    private readonly IMessageSender _messageSender;
    // залежність "вприскується" ззовні (Dependency Injection)
    public NotificationService(IMessageSender messageSender)
    {
        _messageSender = messageSender;
    }
    public void Notify(string message)
    {
        _messageSender.SendMessage(message);
    }
}



