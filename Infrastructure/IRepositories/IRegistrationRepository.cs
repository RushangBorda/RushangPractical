using Infrastructure.Model;

namespace Infrastructure.IRepositories
{
    public interface IRegistrationRepository
    {
        Task<List<Registration>> GetAllAsync();
        Task<Registration?> GetRegistrationById(int id);
        Task<Registration?> Create(Registration data);
        Task<Registration?> Update(Registration dto);
        Task<Registration?> Delete(int id);
    }
}
