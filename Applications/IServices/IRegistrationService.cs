using Applications.Dtos;

namespace Applications.IServices
{
    public interface IRegistrationService
    {
        Task<List<RegistrationDto>> GetAllRegistration();
        Task<RegistrationDto> GetRegistrationById(int id);
        Task<RegistrationDto> addRegistrationDto(RegistrationDto dto);
        Task<RegistrationDto> updateRegistrationDto(RegistrationDto dto);
        Task<RegistrationDto> deleteRegistrationDto(int id);
    }
}
