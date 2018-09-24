using System.Threading.Tasks;

namespace Meetup.UI.ViewModel
{
    public interface IFriendDetailViewModel
    {
        Task LoadAsync(int friendId);
    }
}