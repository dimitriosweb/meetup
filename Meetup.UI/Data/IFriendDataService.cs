using System.Collections.Generic;
using System.Threading.Tasks;
using Meetup.Model;

namespace Meetup.UI.Data
{
    public interface IFriendDataService
    {
        Task<List<Friend>> GetAllAsync();
    }
}