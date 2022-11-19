namespace BuberBreakfast.Models;

public class User
{
	public Guid Id { get; }
	public string Name { get; }
	public string Job { get; }
	public int Age { get; }

	public string Username { get; }
	public string Password { get; }

	public User(Guid id, string name, string job, int age, string username, string password)
	{
		Id = id;
		Name = name;
		Job = job;
		Age = age;
		Username = username;
		Password = password;
	}
}