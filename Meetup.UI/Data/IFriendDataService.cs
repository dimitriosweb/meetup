using System.Collections.Generic;
using Meetup.Model;

namespace Meetup.UI.Data
{
    public interface IFriendDataService
    {
        IEnumerable<Friend> GetAll();
    }
}