
using BuberBreakfast.Models;
using BuberBreakfast.Service.Breakfasts;
namespace BuberBreakfast.Service.Breakfasts;

public class BreakfastService : IBreakfastService
{
	private static readonly Dictionary<Guid, Breakfast> _breakfast = new();
	public void CreateBreakfast(Breakfast breakfast)
	{
		_breakfast.Add(breakfast.Id, breakfast);
	}

	public Breakfast GetBreakfast(Guid id)
	{
		return _breakfast[id];
	}


	public void DeleteBreakfast(Guid id)
	{
		_breakfast.Remove(id);
	}


	public void UpsertBreakfast(Guid id, Breakfast breakfast)
	{
		if (_breakfast[id] != null)
		{
			_breakfast[id] = breakfast;
		}
		else
		{
			_breakfast.Add(id, breakfast);
		}

	}
}