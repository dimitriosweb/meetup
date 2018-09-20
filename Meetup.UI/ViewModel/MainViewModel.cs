using Meetup.Model;
using Meetup.UI.Data;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Meetup.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {

        public MainViewModel(IFriendDataService friendDataService)
        {
            Friends = new ObservableCollection<Friend>();
            _friendDataService = friendDataService;
        }

        public void Load()
        {
            var friends = _friendDataService.GetAll();
            Friends.Clear();
            foreach (var friend in friends)
            {
                Friends.Add(friend);
            }
        }
        public ObservableCollection<Friend> Friends { get; set; }

        public Friend SelectedFriend
        {
            get { return _selectedFriend; }
            set
            {
                _selectedFriend = value;
                OnPropertyChange();
            }
        }


        private Friend _selectedFriend;
        private IFriendDataService _friendDataService;
        

        
    }
}
