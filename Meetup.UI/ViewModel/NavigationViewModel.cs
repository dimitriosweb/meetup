using Meetup.Model;
using Meetup.UI.Data;
using Meetup.UI.Event;
using Prism.Events;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Meetup.UI.ViewModel
{
    public class NavigationViewModel : ViewModelBase, INavigationViewModel
    {
        private ILookupDataService _lookupDataService;
        private IEventAggregator _eventAggregator;

        public NavigationViewModel(ILookupDataService lookupDataService, IEventAggregator eventAggregator)
        {
            _lookupDataService = lookupDataService;
            _eventAggregator = eventAggregator;
            Friends = new ObservableCollection<LookupItem>();
        }

        public ObservableCollection<LookupItem> Friends { get; }

        private LookupItem _selectedFriend;

        public LookupItem SelectedFriend
        {
            get { return _selectedFriend; }
            set
            {
                _selectedFriend = value;
                OnPropertyChange();
                if (_selectedFriend != null)
                {
                    _eventAggregator.GetEvent<OpenFriendDetailViewEvent>().Publish(_selectedFriend.Id);
                }
            }
        }

        public async Task LoadAsync()
        {
            var lookup = await _lookupDataService.GetFriendLookupAsync();
            Friends.Clear();
            foreach (var item in lookup)
            {
                Friends.Add(item);
            }

        }
    }
}
