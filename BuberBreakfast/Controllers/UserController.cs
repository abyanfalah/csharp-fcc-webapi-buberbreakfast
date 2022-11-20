using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using BuberBreakfast.Contracts;
using BuberBreakfast.Models;
using BuberBreakfast.Service;
using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
	private readonly IUserService _userService;

	public UserController(IUserService userService)
	{
		_userService = userService;
	}

	[HttpGet]
	public ActionResult<List<User>> GetAll() => _userService.GetAll();


	[HttpGet("{id:guid}")]
	public ActionResult<User> GetUser(Guid id)
	{
		var user = _userService.GetUser(id);
		if (user == null)
			return NotFound();

		return user;
	}

	[HttpPost]
	public IActionResult CreateUser(CreateUserRequest request)
	{
		var user = new User(
			Guid.NewGuid(),
			request.Name,
			request.Job,
			request.Age,
			request.Username,
			request.Password
		);

		// TODO: save to database
		_userService.CreateUser(user);

		var response = new UserResponse(
			user.Id,
			user.Name,
			user.Job,
			user.Age
		);

		return CreatedAtAction(
			nameof(GetUser),
			new { id = user.Id },
			response
		);

	}

	[HttpDelete("{id:guid}")]
	public IActionResult DeleteUser(Guid id)
	{
		var user = _userService.GetUser(id);
		if (user == null)
			return NotFound();

		_userService.DeleteUser(id);
		return NoContent();
	}

	[HttpPut("{id:guid}")]
	public Object UpdateUser(Guid id, User user)
	{
		var u = _userService.GetUser(id);
		if (u == null)
			return NotFound();

		user.Id = id;
		_userService.UpdateUser(user);
		return NoContent();

	}

}