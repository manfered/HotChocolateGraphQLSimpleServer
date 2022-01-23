using HotChocolateGraphQLSimpleServer.GraphQL;

var builder = WebApplication.CreateBuilder(args);

// Add Hot Chocolate GraphQL server and define the root query type
builder.Services
        .AddGraphQLServer()
        .AddDefaultTransactionScopeHandler() // create transaction scopes for mutation requests to wrap these in a transaction that we can control
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
