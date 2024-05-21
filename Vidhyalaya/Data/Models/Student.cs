using System;
using System.ComponentModel.DataAnnotations;
public class Student
{
    public int Id { get; set; }
    public String Name { get; set; }
    public string Address { get; set; }
    [Display(Name = "Gender")]
    public Gender Sex { get; set; }
    public DateTime Dob { get; set; }
    public byte[] Photo { get; set; }
    public string GuardianDetails { get; set; }

}

public enum Gender
{
    [Display(Name = "Male")]
    Male = 1,

    [Display(Name = "Female")]
    Female,

    [Display(Name = "Others")]
    Others
}