using AuthAPI.Dtos;

namespace AuthAPI.Interfaces
{
    public interface IAuthService
    {
        Task<string> Register(RegistrationRequest registrationRequestDto);
        Task<LoginResponse> Login(LoginRequest loginRequestDto);
        Task<bool> AssignRole(string email, string roleName);
    }
}
