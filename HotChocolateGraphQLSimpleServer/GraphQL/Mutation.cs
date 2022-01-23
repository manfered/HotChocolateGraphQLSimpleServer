using HotChocolateGraphQLSimpleServer.Entities;

namespace HotChocolateGraphQLSimpleServer.GraphQL;

/// <summary>
/// GraphQL mutation root type
/// </summary>
public class Mutation
{
    /// <summary>
    /// Create a post mutation
    /// </summary>
    /// <param name="post"></param>
    /// <returns></returns>
    public async Task<Post> CreatePost(string title, string body) => await Task.Run(() => new Post
    {
        Title = title,
        Body = body
    });
}
