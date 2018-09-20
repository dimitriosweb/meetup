using Meetup.Model;
using System.Collections.Generic;

namespace Meetup.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            yield return new Friend { FirstName = "Galini", LastName = "Vogiatzi", Email = "galini.vogiatzi@gmail.com" };
            yield return new Friend { FirstName = "Dimitrios", LastName = "Metozis", Email = "dimitrios.metozis@gmail.com" };
            yield return new Friend { FirstName = "Vasileios", LastName = "Katsimalis", Email = "vasileios.katsimalis@gmail.com" };
            yield return new Friend { FirstName = "Konstantinos", LastName = "Kontogiorgos", Email = "Konstantinos.Kontogiorgos@gmail.com" };
        }
    }
}
