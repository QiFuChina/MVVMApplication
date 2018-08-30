using MVVMApplication.Data;
using MVVMApplication.Models;
using MVVMApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MVVMApplication.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Show : Page
    {
        private ObservableCollection<Item> Item;
        public Show()
        {
            this.InitializeComponent();
            Organization = new OrganizationViewModel();
            Item = new ObservableCollection<Item>();
        }
        OrganizationViewModel Organization { get; set; }

        private void GridViewItemClick(object sender, ItemClickEventArgs e)
        {
            Frame.Navigate(typeof(Detail));
        }
    }
}
