using MVVMApplication.Data;
using MVVMApplication.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public sealed partial class Edit : Page
    {
        public Edit()
        {
            this.InitializeComponent();
        }

        //private void CalendarChanging(CalendarView sender, CalendarViewDayItemChangingEventArgs e)
        //{
        //    //string date = CalendarDatePicker.Date.Value.Day.ToString() + "/" +
        //    //                  CalendarDatePicker.Date.Value.Month.ToString() + "/" +
        //    //                  CalendarDatePicker.Date.Value.Year.ToString();
        //}

        private void Submit_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string titleText = Title.Text;
            string localationText = Location.Text;
            string eventsText = Events.Text;
            string date = CalendarDateValue.Date.Value.Day.ToString() + "/" +
                   CalendarDateValue.Date.Value.Month.ToString() + "/" +
                   CalendarDateValue.Date.Value.Year.ToString();
            var Item = new Item() { Title = titleText, Location = localationText, Events = eventsText,Date=date };
            Debug.WriteLine("Get Item on the Edit page:" + " " + titleText + " " + localationText + " " + eventsText + " " + date);
        }

        private void FlyoutButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MyFlyout.Hide();
        }

        private void View_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Show));
        }
    }
}
