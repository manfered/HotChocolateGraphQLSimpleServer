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
    public async Task<Post> CreatePost(Post input) => await Task.Run(() => new Post
    {
        Title = input.Title,
        Body = input.Body
    });
}
