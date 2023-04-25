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
        get { return monthlySalary; }
        set
        {
            if (monthlySalary >= 0)
            {
                monthlySalary = value;
            }
        }
    }

    // constructor
    public Employee(string firstName, string lastName, decimal monthlySalary) 
    { 
        FirstName = firstName;
        LastName = lastName;
        MonthlySalary = monthlySalary;
    }

    // yearly salary
    public decimal yearlySalary()
    {
        return MonthlySalary * 12;
    }

    // raise method
    public decimal raise()
    {
        return MonthlySalary += MonthlySalary / 10;
    }
}
// end of Employee class

class EmployeeTest
{
    static void Main(string[] args)
    {
        Employee employee1 = new Employee("Abdul", "Rahman", 7800.75m);
        Employee employee2 = new Employee("Dua", "Fatima", 6300.30m);

        Console.WriteLine("Employee One \n\nName: {0} {1} \nMonthly Salary: {2:C2} \nYearly Salary: {3:C2} \nMonthly Salary With 10% Raise: {4:C2} \nYearly Salary With 10% Raise: {5:C2}", employee1.FirstName, employee1.LastName, employee1.MonthlySalary, employee1.yearlySalary(), employee1.raise(), employee1.yearlySalary());
        Console.WriteLine("\nEmployee Two \n\nName: {0} {1} \nMonthly Salary: {2:C2} \nYearly Salary: {3:C2} \nMonthly Salary With 10% Raise: {4:C2} \nYearly Salary With 10% Raise: {5:C2}", employee2.FirstName, employee2.LastName, employee2.MonthlySalary, employee2.yearlySalary(), employee2.raise(), employee2.yearlySalary());
    }
}
