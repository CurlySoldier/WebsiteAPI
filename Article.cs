namespace WebsiteAPI;

public class Article
{
    public string? Heading { get; set; }
    public string? Author { get; set; }
    public string? Contents { get; set; }
    public DateTime? UploadedOn { get; set; }

    public Article(string heading, string author, string contents, DateTime uploadedOn)
    {
        Heading = heading;
        Author = author;
        Contents = contents;
        UploadedOn = uploadedOn;
    }
    
}