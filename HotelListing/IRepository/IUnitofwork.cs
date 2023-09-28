using HotelListing.Data;

namespace HotelListing.IRepository
{
    public interface IUnitofwork : IDisposable
    {
        IGenericRepository<Country> Countries { get; }
        IGenericRepository<Hotel> Hotels { get; }
        Task Save();
    }
}
