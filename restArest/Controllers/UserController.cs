using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Npgsql;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace restArest.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{

		// GET: api/<UserController>
		[HttpGet]
		public List<User> Get()
		{
			List<User> users = new List<User>();
			UsersBdContext context = new UsersBdContext();
			users = context.Users.ToList();
			return users;
		}

		// GET api/<UserController>/5
		[HttpGet("{id}")]
		public User Get(int id)
		{
			List<User> users = new List<User>();
			UsersBdContext context = new UsersBdContext();
			users = context.Users.ToList();
			User user = users.Find(f => f.Id == id);
			return user;
		}

		// POST api/<UserController>
		[HttpPost]
		public void Post([FromBody] User user)
		{
			UsersBdContext context = new UsersBdContext();
			context.Users.Add(user);
			context.SaveChanges();
		}

		// PATCH api/<UserController>/5
		[HttpPatch("{id}")]
		public void Put(int id, [FromBody] string value)
		{
			UsersBdContext context = new UsersBdContext();
			List<User> users = new List<User>();
			users = context.Users.ToList();
			User user = users.Find(f => f.Id == id);
			user.Password = value;
			context.Users.Update(user);
			context.SaveChanges();
		}

		// DELETE api/<UserController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			List<User> users = new List<User>();
			UsersBdContext context = new UsersBdContext();
			users = context.Users.ToList();
			User user = users.Find(f => f.Id == id);
			context.Users.Remove(user);
			context.SaveChanges();
		}
	}
}
