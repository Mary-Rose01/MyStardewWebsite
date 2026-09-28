namespace MyWebsite.Models;

public class FeedbackModel
{
    public string Name { get; set; } = string.Empty;
    public int Stars { get; set; } = 5;
    public string Comment { get; set; } = string.Empty;
    public DateTime SubmittedAt { get; set; } = DateTime.Now;
}