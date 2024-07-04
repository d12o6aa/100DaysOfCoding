namespace ConsoleApp1;

public class Employee
{
    private int ID { get; set; }
    private double Salary { get; set; }
    private Gender Gender { get; set; }
    private SecurityLevel SecurityLevel { get; set; }
    private HireDate HireDate { get; set; }

    public Employee(int id, double salary, Gender gender, SecurityLevel level, HireDate hireDate)
    {
        this.ID = id;
        this.Salary = salary;
        this.Gender = gender;
        this.SecurityLevel = level;
        this.HireDate = hireDate;
    }
    
    public override string ToString()
    {
        return $"ID: {ID}, Security Level: {SecurityLevel}, Salary: {Salary:C}, Hire Date: {HireDate}, Gender: {Gender}";
    }
}
