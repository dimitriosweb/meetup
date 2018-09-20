using Meetup.DataAccess;
using Meetup.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Meetup.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        private MeetupDbContext _contextCreator;

        public FriendDataService(MeetupDbContext contextCreator )
        {
            _contextCreator = contextCreator;
        }
        public async Task<List<Friend>> GetAllAsync()
        {
            using (var ctx = _contextCreator)
            {
                return await ctx.Friends.AsNoTracking().ToListAsync();
            }
        }
    }
}
