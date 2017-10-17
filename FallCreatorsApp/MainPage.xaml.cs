using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FallCreatorsApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string loadParams = e.Parameter as string;
            ContentFrame.Navigate(typeof(HomePage), loadParams);
        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                ContentFrame.Navigate(typeof(SettingsPage));
            }
            else
            {
                switch (args.InvokedItem)
                {
                    case "Home":
                        ContentFrame.Navigate(typeof(HomePage));
                        break;

                    case "Автозагрузка":
                        ContentFrame.Navigate(typeof(StartupPage));
                        break;

                    case "Перезапуск":
                        ContentFrame.Navigate(typeof(RestartPage));
                        break;

                    case "Color picker":
                        ContentFrame.Navigate(typeof(ColorPickerPage));
                        break;

                    case "Parallax":
                        ContentFrame.Navigate(typeof(ParallaxPage));
                        break;

                    case "Другие контролы":
                        ContentFrame.Navigate(typeof(VariousControlsPage));
                        break;

                }
            }
        }


    }
}
