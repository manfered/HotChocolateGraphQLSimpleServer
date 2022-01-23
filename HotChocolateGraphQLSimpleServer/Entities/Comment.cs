namespace HotChocolateGraphQLSimpleServer.Entities;

/// <summary>
/// Blog post comment
/// </summary>
public class Comment
{
    /// <summary>
    /// Comment's text
    /// </summary>
    [Required]
    public string Text { get; set; } = string.Empty;

    /// <summary>
    /// The post the comment belongs to
    /// </summary>
    [Required]
    public Post Post { get; set; }
}
