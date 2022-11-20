using BuberBreakfast.Models;
using Microsoft.OpenApi.Any;

namespace BuberBreakfast.Service;

public interface IUserService
{
	// Dictionary<Guid, User> GetAll();

	List<User> GetAll();
	User? GetUser(Guid id);
	void CreateUser(User user);
	void UpdateUser(User user);
	void DeleteUser(Guid id);


}