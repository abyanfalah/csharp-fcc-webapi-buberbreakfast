using BuberBreakfast.Contracts.Breakfasts;
using BuberBreakfast.Models;

namespace BuberBreakfast.Service.Breakfasts;

public interface IBreakfastService
{
	Dictionary<Guid, Breakfast> GetAll();
	Breakfast? GetBreakfast(Guid id);
	void CreateBreakfast(Breakfast breakfast);
	void UpsertBreakfast(Breakfast breakfast);
	void DeleteBreakfast(Guid id);
}