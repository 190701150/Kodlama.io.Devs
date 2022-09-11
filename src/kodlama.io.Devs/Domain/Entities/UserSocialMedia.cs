using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace Domain.Entities;

public class UserSocialMedia:Entity
{
    public int UserId { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public virtual User? User { get; set; }

    public UserSocialMedia()
    {
        
    }

    public UserSocialMedia(int userId, string name, string url)
    {
        UserId = userId;
        Name = name;
        Url = url;
    }
}