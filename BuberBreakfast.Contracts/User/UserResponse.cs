namespace BuberBreakfast.Contracts;

public record UserResponse(
	Guid Id,
	string Name,
	string Job,
	int Age
);