using System.Threading.Tasks;
using Meetup.Model;

namespace Meetup.UI.Data
{
    public interface IFriendDataService
    {
        Task<Friend> GetByIdAsync(int friendId);
    }
}