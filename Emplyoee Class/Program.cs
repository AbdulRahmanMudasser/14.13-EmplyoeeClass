class Employee
{
    // declaring variables
    private string firstName;
    private string lastName;
    private decimal monthlySalary;

    // properties for each variables
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get => lastName;
        set => lastName = value;
    }

    public decimal MonthlySalary
    {
        get => monthlySalary;
        set => monthlySalary = value;
    }

    // constructor
    public Employee(string firstName, string lastName, decimal monthlySalary) 
    { 
        FirstName = firstName;
        LastName = lastName;
        MonthlySalary = monthlySalary;
    }
}
// end of Employee class

class EmployeeTest
{
    static void Main(string[] args)
    {
        Employee employee1 = new Employee("Abdul", "Rahman", 7800.75m);
        Employee employee2 = new Employee("Dua", "Fatima", 6300.30m);

        Console.WriteLine("Employee One \n\nName: {0} {1} \nMonthly Salary: {2} \nYearly Salary: {3}", employee1.FirstName, employee1.LastName, employee1.MonthlySalary, employee1.MonthlySalary * 12);
        Console.WriteLine("\nEmployee Two \n\nName: {0} {1} \nMonthly Salary: {2} \nYearly Salary: {3}", employee2.FirstName, employee2.LastName, employee2.MonthlySalary, employee2.MonthlySalary * 12);
    }
}
