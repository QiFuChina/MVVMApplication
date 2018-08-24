using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using MVVMApplication.Models;


namespace MVVMApplication.ViewModels
{
    class OrganizationViewModel : NotificationBase
    {
        Organization organization;
        ObservableCollection<EventViewModel> _event = new ObservableCollection<EventViewModel>();
        int _SelectedIndex;

        public OrganizationViewModel()
        {
            organization = new Organization();
            _SelectedIndex = -1;
            foreach (var event in organization.events)
            {
                var ne = new EventViewModel(event);
                ne.PropertyChanged += events_OnNotifyPropertyChanged;
                _event.Add(ne);
            }
        }

        public ObservableCollection<EventViewModel> event{
            get { return _event; }
            set { SetProperty(ref _event, value); }
        }
}
}



    
}
