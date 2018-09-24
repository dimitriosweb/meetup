using Meetup.DataAccess;
using Meetup.Model;
using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Meetup.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        private Func<MeetupDbContext> _contextCreator;

        public FriendDataService(Func<MeetupDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        public async Task<Friend> GetByIdAsync(int friendId)
        {
            using (var ctx = _contextCreator())
            {
                var ret = await ctx.Friends.AsNoTracking()
                .SingleAsync(f => f.Id == friendId);
                return ret;
            }
        }
    }
}