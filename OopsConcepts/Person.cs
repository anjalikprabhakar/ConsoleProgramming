

class Person
{
    //public Person(string FisrstName, string lastName, double salary)
    //{
    //    FirstName = FisrstName;
    //    lastName = lastName;
    //    salary = salary;

    //}
    public int age { get; set; }
    public string FirstName { get; set; }
    public string lastName { get; set; }
    private double _salary;
    public void SetSalary(double salary)
    {
        _salary = salary;
    }
    public double GetSalary(double salary)
    {
        return _salary;
    }
    public string FullName(double salary)
    {
        return FirstName + "" + lastName;
    }
    public string FullName(string middleName)
    {
        return FirstName + "" + middleName + "" + lastName;
    }

}

