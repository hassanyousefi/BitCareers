using BitCareers.Api.Models.Account;
using BitCareers.Shared.Dtos.Account;

namespace BitCareers.Api.Services.Contracts;

public interface IJwtService
{
    Task<SignInResponseDto> GenerateToken(User user);
}
