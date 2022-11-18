namespace BuberBreakfast.Contracts.Breakfasts;

public record CreateBreakfastRequest(
	string Name,
	string Description,
	DateTime StartDateTime,
	DateTime EndDateTime,
	DateTime LastModifiedDateTime,
	List<string> Savory,
	List<string> Sweet
);