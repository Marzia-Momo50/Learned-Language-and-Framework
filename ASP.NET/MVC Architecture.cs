//----------categoryControllerController-------------//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace App.Model
{
[ApiController]
[Route("api/categories/")]
public class categoryController:ControllerBase
{
    private static List<Category>categories= new List<Category>();

    //GET:/api/categories => Read categories//
    [HttpGet]
   public IActionResult GetCategories([FromQuery] string searchValue=""){
    if(!string.IsNullOrEmpty(searchValue))
  {
    Console.WriteLine($"{searchValue}");
    var searchCategories=categories.Where(c=> c.Name.Contains
    (searchValue, StringComparison.OrdinalIgnoreCase)).ToList();
    return Ok(searchCategories);

    
  }

    return Ok(categories);

   }



   
    //POST:/api/categories => Createcategories//
    [HttpPost]
   public IActionResult CreateCategory([FromBody] Category categoryData){
    if(string.IsNullOrEmpty(categoryData.Name))
  {
    return BadRequest("Category Name Is Required,It can't be empty!");
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

  return Created($"/api/categories/{New_category.CategoryId}",New_category);

   }


//PUT:/api/categories => Updatecategories//
    [HttpPut("{id:guid}")]
   public IActionResult UpdateCategoryById(Guid id, [FromBody] Category categoryData){
   Console.WriteLine($"Received put request for ID: {id}");

  var foundCategory= categories.FirstOrDefault(category => category.CategoryId==id);

  if(foundCategory==null)
  {
    return NotFound($"Category with id: {id} not found");
   }

   foundCategory.Name=categoryData.Name ?? foundCategory.Name;
   foundCategory.Description=categoryData.Description ?? foundCategory.Description;
   return NoContent();

   }

   //DELETE:/api/categories => DELETEcategories//
    [HttpDelete("{id:guid}")]
   public IActionResult DeleteCategoryById(Guid id){

     var foundCategory= categories.FirstOrDefault(category => category.CategoryId==id);
    if(foundCategory==null)
    {
    return NotFound("Not Found");

    }
    categories.Remove(foundCategory);
    return NoContent();

   }
   

}
}



    
//----------Categoery.cs-------------------//


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Model
{
public class Category
{
   public Guid CategoryId {get;set;}
    public string Name {get;set;}
    public string? Description {get;set;} =string.Empty;
    public DateTime CreatedAt {get;set;}
}
    
}








//--------Program.cs-----------//



using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

//Add service to the controller//
builder.Services.AddControllers();


builder.Services.AddOpenApi();
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }


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


app.MapControllers();
app.Run();


//----------Rest Client API Calling--------------//

@App_HostAddress = http://localhost:5065


GET http://localhost:5065
###

GET http://localhost:5065/api/categories
###

POST http://localhost:5065/api/categories
Content-Type: application/json

{
    "name":"programming language",
    "description":"including C++,js,C#"
}
###

DELETE http://localhost:5065/api/categories/d7fd4949-6dba-437c-ab37-4bf285627241
###

PUT http://localhost:5065/api/categories/d7fd4949-6dba-437c-ab37-4bf285627241
Content-Type: application/json

 {
    "name":"programing language2",
    "description":"c,d,e,r"
 }

