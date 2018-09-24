using Meetup.Model;
using Meetup.UI.Data;
using Meetup.UI.Event;
using Prism.Events;
using System;
using System.Threading.Tasks;

namespace Meetup.UI.ViewModel
{
    public class FriendDetailViewModel : ViewModelBase, IFriendDetailViewModel
    {
        private Friend _friend;
        private IFriendDataService _friendDataService;
        private IEventAggregator _eventAggregator;

        public FriendDetailViewModel(IFriendDataService friendDataService, IEventAggregator eventAggregator)
        {
            _friendDataService = friendDataService;
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<OpenFriendDetailViewEvent>().Subscribe(OnOpenFriendDetailView);
        }

        private async void OnOpenFriendDetailView(int friendId)
        {
            await LoadAsync(friendId);
        }

        public Friend Friend
        {
            get
            {
                return _friend;
            }
            set
            {
                _friend = value;
                OnPropertyChange();
            }
        }

        public async Task LoadAsync(int friendId)
        {
            Friend = await _friendDataService.GetByIdAsync(friendId);
        }
    }
}
