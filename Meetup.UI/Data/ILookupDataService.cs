using Meetup.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meetup.UI.Data
{
    public interface ILookupDataService
    {
        Task<IEnumerable<LookupItem>> GetFriendLookupAsync();
    }
}