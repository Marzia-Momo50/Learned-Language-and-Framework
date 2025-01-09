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
  //   if(!string.IsNullOrEmpty(searchValue))
  // {
  //   Console.WriteLine($"{searchValue}");
  //   var searchCategories=categories.Where(c=> c.Name.Contains
  //   (searchValue, StringComparison.OrdinalIgnoreCase)).ToList();
  //   return Ok(searchCategories);

    
  // }

  var categoryList=categories.Select(c=> new CategoryReadDto
  {
    CategoryId=c.CategoryId,
    Name=c.Name,
    Description=c.Description,
    CreatedAt=c.CreatedAt
  }).ToList();

    return Ok(categoryList);

   }



   
    //POST:/api/categories => Createcategories//
    [HttpPost]
   public IActionResult CreateCategory([FromBody] CategoryCreateDto categoryData){
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

  var categoryReadDto= new CategoryReadDto{
   CategoryId=New_category.CategoryId,
   Name=New_category.Name,
   Description=New_category.Description,
   CreatedAt=New_category.CreatedAt

  };

 
  //return Results.Created($"/api/categories/{New_category.CategoryId}", New_category);

  return Created($"/api/categories/{New_category.CategoryId}",categoryReadDto);

   }


//PUT:/api/categories => Updatecategories//
    [HttpPut("{id:guid}")]
   public IActionResult UpdateCategoryById(Guid id, [FromBody] CategoryUpdateDto categoryData){
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



//-------------------------------CategoryReadDto.cs-----------------------------------//



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Model
{
public class CategoryReadDto
{
   
   public Guid CategoryId {get;set;}
    public string Name {get;set;}
    public string? Description {get;set;} =string.Empty;
    public DateTime CreatedAt {get;set;}
}
    
}

//Model works at Database side and DTOS works at client site//


//-----------------------CategoryUpdateDto.cs--------------------------------//




using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Model
{
public class CategoryUpdateDto
{
    public string Name {get;set;}
    public string? Description {get;set;} =string.Empty;
}
    
}



//---------------------------CategoryCreateDto.cs------------------------------//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Model
{
public class CategoryCreateDto
{
   
    public string Name {get;set;}
    public string? Description {get;set;} =string.Empty;
}
    
}

//Model works at Database side and DTOS works at client site//








//-------------------Progrma.cs------------------//


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



//---------------------Category.cs-----------------------//

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





    
