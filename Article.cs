namespace WebsiteAPI;

public class Article
{
    public string Id { get; set; }
    public string? Heading { get; set; }
    public string? Author { get; set; }
    public string? Contents { get; set; }
    public DateTime? UploadedOn { get; set; }

    public Article(string id, string heading, string author, string contents, DateTime uploadedOn)
    {
        Id = id;
        Heading = heading;
        Author = author;
        Contents = contents;
        UploadedOn = uploadedOn;
    }
    
}