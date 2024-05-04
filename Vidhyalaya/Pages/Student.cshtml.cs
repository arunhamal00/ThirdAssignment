using Microsoft.AspNetCore.Mvc.RazorPages;

public class StudentModel: PageModel
{    
    public List<Students> Students { get; set; }
    public void OnGet()
    {
        VidhyalayaDbContext db = new();
        Student = db.Student.ToList();
    }
}