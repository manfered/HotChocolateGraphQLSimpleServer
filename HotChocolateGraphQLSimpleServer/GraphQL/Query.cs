using HotChocolateGraphQLSimpleServer.Entities;

namespace HotChocolateGraphQLSimpleServer.GraphQL;

/// <summary>
/// GraphQL query root type
/// </summary>
public class Query
{
    public Post ListPosts() =>
            new Post
            {
                Title = "Hot Chocolate GraphQL",
                Body = "This is a simple post about Hot Chocolate"
            };
}
