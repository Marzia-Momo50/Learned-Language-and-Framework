using System.ComponentModel;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddOpenApi();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

//Start here//
app.MapGet("/", () =>
{
    return "App is working Well!!";
});

List<Category>categories= new List<Category>();

app.MapGet("/api/categories",() =>
{
  return Results.Ok(categories);
});


app.MapPost("/api/categories",()=>
{
  var New_category= new Category
  { 
  CategoryId= Guid.Parse("f8d3c6e0-a927-4b5a-83a5-bf019fcb7f14"),
  Name = "Electronics",
  Description = "This is a type of Electronics Device",
  CreatedAt = DateTime.UtcNow,
  };

  categories.Add(New_category);
  //return Results.Created($"/api/categories/{New_category.CategoryId}", New_category);

  return Results.Created($"/api/categories/{New_category.CategoryId}",New_category);
});



app.MapDelete("/api/categories/{id}",(Guid id)=>
{
  var foundCategory= categories.FirstOrDefault(category => category.CategoryId==id);
  if(foundCategory==null)
  {
    return Results.NotFound("Not Found");

  }
  categories.Remove(foundCategory);
  return Results.NoContent();
});




app.MapPut("/api/categories/{id}",(Guid id) => 
{
  Console.WriteLine($"Received put request for ID: {id}");

  var foundCategory= categories.FirstOrDefault(category => category.CategoryId==id);

  if(foundCategory==null)
  {
    return Results.NotFound($"Category with id: {id} not found");
   }

   foundCategory.Name="Samsung";
   foundCategory.Description="This is a type of android phone";
   return Results.NoContent();
});

app.Run();

public record Category
{
   public Guid CategoryId {get;set;}
    public string? Name {get;set;}
    public string? Description {get;set;}
    public DateTime CreatedAt {get;set;}
}

