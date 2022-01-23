namespace HotChocolateGraphQLSimpleServer.Entities;

/// <summary>
/// Blog Post 
/// </summary>
public class Post
{
    /// <summary>
    /// Post Title
    /// </summary>
    [Required]
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Post body
    /// </summary>
    [Required]
    public string Body { get; set; } = string.Empty;
}
