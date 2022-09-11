using Application.Features.Auths.Constants;
using Application.Services.Repositories;
using Core.CrossCuttingConcerns.Exceptions;
using Core.Security.Entities;
using Core.Security.Hashing;

namespace Application.Features.Auths.Rules;

public class UserBusinessRules
{
    private readonly IUserRepository _userRepository;

    public UserBusinessRules(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public async Task UserEmailAddressCanNotBeDuplicated(string requestEmail)
    {
        var user = await _userRepository.GetAsync(x => x.Email == requestEmail);
        if (user is not null)
            throw new BusinessException(UserMessages.UserEmailAlreadyExists);
    }
    
    public void CheckIfUserExists(User user)
    {
        if (user is null)
            throw new BusinessException(UserMessages.UserNotFound);
    }
    
    public void CheckIfPasswordIsCorrect(string requestPassword, byte[] userPasswordHash, byte[] userPasswordSalt)
    {
        if (!HashingHelper.VerifyPasswordHash(requestPassword, userPasswordHash, userPasswordSalt))
            throw new BusinessException(UserMessages.PasswordIsNotCorrect);
    }
}