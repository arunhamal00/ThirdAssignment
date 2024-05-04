public class Student
{
    public int Id { get; set; }
    public String Name { get; set; }
    public string Address { get; set; }
    public Gender Sex { get; set; }
    public DateTime Dob { get; set; }
    public byte[] Photo { get; set; }
    public string GuardianDetails { get; set; }

}

public enum Gender
{
    Male,
    Female,
    Others

}