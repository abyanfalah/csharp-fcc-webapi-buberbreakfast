namespace BuberBreakfast.Contracts;

public record CreateUserRequest(
	string Name,
	string Job,
	int Age,
	string Username,
	string Password
	);