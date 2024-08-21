using System;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.VisualBasic;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;
//using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;


[ApiController]
[Route("api/[controller]")] // api/users 


public class UsersController(DataContext context) : ControllerBase

{
    [HttpGet]
    public ActionResult<IEnumerable<AppUser>> GetUsers()
    {
        var users = context.Users.ToList();
        return users;
    }
    [HttpGet("{id:int}")] //api/users/3
    public ActionResult<AppUser> GetUser(int id)
    {
        var user = context.Users.Find(id);
        if (user == null) return NotFound(id);
        return user;
    }

}