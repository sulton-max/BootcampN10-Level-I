using N33_T1.Services.Accounts.Interfaces;

namespace N33_T1.Services.Accounts;

public class AccountService
{
    private readonly IUserService _userService;

    public AccountService(IUserService userService)
    {
        _userService = userService;
    }
}