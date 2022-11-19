using BuberBreakfast.Models;

namespace BuberBreakfast.Service;

public interface IUserService
{
	Dictionary<Guid, User> GetAll();
	User? GetUser(Guid id);
	void CreateUser(User user);
	void UpdateUser(User user);
	void DeleteUser(Guid id);

}

public interface IUserServiceList
{
	List<User> GetAll();
	User? GetUser(Guid id);
	void CreateUser(User user);
	void UpdateUser(User user);
	void DeleteUser(Guid id);

}