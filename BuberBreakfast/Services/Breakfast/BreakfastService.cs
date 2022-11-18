
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

	public Breakfast? GetBreakfast(Guid id)
	{
		// return _breakfast[id];
		try
		{
			return _breakfast[id];
		}
		catch
		{
			return null;
		}
	}


	public void DeleteBreakfast(Guid id)
	{
		_breakfast.Remove(id);
	}


	public void UpsertBreakfast(Breakfast breakfast)
	{
		_breakfast[breakfast.Id] = breakfast;

	}

	public Dictionary<Guid, Breakfast> GetAll()
	{
		return _breakfast;
	}
}