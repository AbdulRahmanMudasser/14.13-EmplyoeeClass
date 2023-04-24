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
}
