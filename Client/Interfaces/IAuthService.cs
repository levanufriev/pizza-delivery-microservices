using Client.Models;

namespace Client.Interfaces
{
    public interface IAuthService
    {
        Task<ResponseDto> LoginAsync(LoginRequest loginRequestDto);
        Task<ResponseDto> RegisterAsync(RegistrationRequest registrationRequestDto);
        Task<ResponseDto> AssignRoleAsync(RegistrationRequest registrationRequestDto);
    }
}
