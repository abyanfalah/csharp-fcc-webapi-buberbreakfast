using BuberBreakfast.Contracts.Breakfasts;
using BuberBreakfast.Models;

namespace BuberBreakfast.Service.Breakfasts;

public interface IBreakfastService
{
	Breakfast GetBreakfast(Guid id);
	void CreateBreakfast(Breakfast breakfast);
	void UpsertBreakfast(Guid id, Breakfast breakfast);
	void DeleteBreakfast(Guid id);
}