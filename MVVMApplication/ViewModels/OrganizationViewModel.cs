using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using MVVMApplication.Models;

namespace MVVMApplication.ViewModels
{
    class OrganizationViewModel : NotificationBase
    {
        Organization organization;
        ObservableCollection<ItemViewModel> _Item = new ObservableCollection<ItemViewModel>();
        int _SelectedIndex;

        public OrganizationViewModel()
        {
            organization = new Organization();
            _SelectedIndex = -1;
            // Load the database
            foreach (var item in organization.Items)
            {
                var ni = new ItemViewModel(item);
                ni.PropertyChanged += Item_OnNotifyPropertyChanged;
                _Item.Add(ni);
            }
        }

    

        public ObservableCollection<ItemViewModel> Item
        {
            get { return _Item; }
            set { SetProperty(ref _Item, value); }
        }

        String _Name;
        public String Name
        {
            get { return organization.Name; }
        }


        public int SelectedIndex
        {
            get { return _SelectedIndex; }
            set { if (SetProperty(ref _SelectedIndex, value)) { RaisePropertyChanged(nameof(SelectedItem)); } }
        }

        public ItemViewModel SelectedItem => (_SelectedIndex >= 0) ? _Item[_SelectedIndex] : null;

        public void Add()
        {
            var item = new ItemViewModel();
            item.PropertyChanged += Item_OnNotifyPropertyChanged;
            Item.Add(item);
            organization.Add(item);
            SelectedIndex = Item.IndexOf(item);
        }

        public void Delete()
        {
            if (SelectedIndex != -1)
            {
                var item = Item[SelectedIndex];
                Item.RemoveAt(SelectedIndex);
                organization.Delete(item);
            }
        }

        void Item_OnNotifyPropertyChanged(Object sender, PropertyChangedEventArgs e)
        {
            organization.Update((ItemViewModel)sender);
        }
    }
}
