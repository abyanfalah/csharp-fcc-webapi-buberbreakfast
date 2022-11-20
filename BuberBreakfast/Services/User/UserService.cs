using BuberBreakfast.Models;

namespace BuberBreakfast.Service;

public class UserService : IUserService
{
	private static readonly List<User> _users = new List<User> { };

	public void CreateUser(User user)
	{
		_users.Add(user);
	}

	public void DeleteUser(Guid id)
	{
		var user = GetUser(id);
		if (user is null)
			return;

		_users.Remove(user);
	}

	public List<User> GetAll() => _users;


	public User? GetUser(Guid id) => _users.FirstOrDefault(user => user.Id == id);

	public void UpdateUser(User user)
	{
		var index = _users.FindIndex(u => u.Id == user.Id);
		if (index == -1)
			return;

		_users[index] = user;
	}
}