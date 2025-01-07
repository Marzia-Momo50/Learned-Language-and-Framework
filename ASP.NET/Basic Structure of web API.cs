var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddEndpointsApiExplorer();


var app = builder.Build();



app.UseHttpsRedirection();

// app.MapGet("/", () =>
// {
//     return "I am Root";
// });


app.MapGet("/hello", () =>
{
    return "Hello";
});

app.MapGet("/hafiz", () =>
{
    return "HI am Hafiz";
});

app.MapPost("/hello",() =>
{
  return "Post Method";
});
app.MapPut("/hello",() =>
{
  return "Put Method";
});





app.Run();



/*
CRUD=
Create
Read
Update
Delete
*/



