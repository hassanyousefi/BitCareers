using BitCareers.Shared.Dtos.Account;

namespace BitCareers.Web.Services.Contracts;

public interface IAuthenticationService
{
    Task SignIn(SignInRequestDto dto);

    Task SignOut();
}
