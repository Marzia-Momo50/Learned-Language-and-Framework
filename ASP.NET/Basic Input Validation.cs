//------------Basic Input Validation----------//


using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

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

app.MapGet("/api/categories",([FromQuery] string searchValue="") =>
{
  
  if(!string.IsNullOrEmpty(searchValue))
  {
    Console.WriteLine($"{searchValue}");
    var searchCategories=categories.Where(c=> c.Name.Contains
    (searchValue, StringComparison.OrdinalIgnoreCase)).ToList();
    return Results.Ok(searchCategories);

    
  }

    return Results.Ok(categories);
});


app.MapPost("/api/categories",([FromBody] Category categoryData)=>
{

  
  if(string.IsNullOrEmpty(categoryData.Name))
  {
    return Results.BadRequest("Category Name Is Required,It can't be empty!");
  }
  var New_category= new Category
  { 
  CategoryId= Guid.NewGuid(),
  Name = categoryData.Name,
  Description = categoryData.Description,
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




app.MapPut("/api/categories/{id}",(Guid id, [FromBody] Category categoryData) => 
{
  Console.WriteLine($"Received put request for ID: {id}");

  var foundCategory= categories.FirstOrDefault(category => category.CategoryId==id);

  if(foundCategory==null)
  {
    return Results.NotFound($"Category with id: {id} not found");
   }

   foundCategory.Name=categoryData.Name ?? foundCategory.Name;
   foundCategory.Description=categoryData.Description ?? foundCategory.Description;
   return Results.NoContent();
});

app.Run();

public record Category
{
   public Guid CategoryId {get;set;}
    public string Name {get;set;}
    public string? Description {get;set;} =string.Empty;
    public DateTime CreatedAt {get;set;}
}




//-----API Calling System Using Rest_Client------//



@App_HostAddress = http://localhost:5065


GET http://localhost:5065
###

GET http://localhost:5065/api/categories
###

POST http://localhost:5065/api/categories
Content-Type: application/json

{
    "name":"programming_language",
    "description":"including C++,js,c#"
}
###

DELETE http://localhost:5065/api/categories/f3211f3d-6be4-4dea-a0cd-76bc670029ae
###

PUT http://localhost:5065/api/categories/d4bcbc1f-20cf-406f-b525-c7f04181491e
Content-Type: application/json

 {
    "name":"",
    "description":"c,d,e,r"
 }


