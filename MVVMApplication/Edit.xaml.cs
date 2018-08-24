using MVVMApplication.Models;
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

namespace MVVMApplication
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Edit : Page
    {
        private ObservableCollection<SavingData> SavingofData;
        public Edit()
        {
            this.InitializeComponent();
            SavingofData = new ObservableCollection<SavingData>();
        }


        private void Submit_Tapped(object sender, TappedRoutedEventArgs e)
        {
            SavingofData.Add(new SavingData {  Title = Title.Text });
            Title.Text = "";
            Title.Focus(FocusState.Programmatic);

        }

        private void FlyoutButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MyFlyout.Hide();
        }

        private void CalendarChanging(CalendarView sender, CalendarViewDayItemChangingEventArgs e)
        {
            var selectedDates = sender.SelectedDates.Select(p => p.Date.Month.ToString() + "/" + p.Date.Day.ToString()).ToArray();
            var values = string.Join(", ", selectedDates);

        }

        private void GridViewItemClick(object sender, ItemClickEventArgs e)
        {
            Frame.Navigate(typeof(Detail));
        }
    }
}
