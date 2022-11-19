namespace BuberBreakfast.Contracts;

public record UpdateUserRequest(
	string Name,
	string Job,
	int Age,
	string Username,
	string Password
	);