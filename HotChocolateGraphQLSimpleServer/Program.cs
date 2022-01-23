using HotChocolateGraphQLSimpleServer.GraphQL;

var builder = WebApplication.CreateBuilder(args);

// Add Hot Chocolate GraphQL server and define the root query type
builder.Services
        .AddGraphQLServer()
        .AddQueryType<Query>()
        .AddMutationType<Mutation>();

var app = builder.Build();

// Attach and define the GraphQL endpoint at default /graphql route
app.UseRouting()
   .UseEndpoints(endpoints =>
   {
       endpoints.MapGraphQL();
   });

app.Run();
