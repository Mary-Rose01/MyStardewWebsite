using MyWebsite.Models;

namespace MyWebsite.Services;

public class FeedbackService
{
    public List<FeedbackModel> Reviews { get; private set; } = new()
    {
        new FeedbackModel
        {
            Name = "Robin",
            Stars = 5,
            Comment = "Loved finding out Sebastian was my best friend match! Stardew theme looks cozy.",
            SubmittedAt = DateTime.Now.AddDays(-2)
        },
        new FeedbackModel
        {
            Name = "Mayor Lewis",
            Stars = 4,
            Comment = "A very fine community project for Pelican Town. Keep up the good work!",
            SubmittedAt = DateTime.Now.AddDays(-1)
        }
    };

    public void AddFeedback(FeedbackModel feedback)
    {
        Reviews.Insert(0, feedback);
    }
}