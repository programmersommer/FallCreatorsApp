using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
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

namespace FallCreatorsApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class StartupPage : Page
    {
        public StartupPage()
        {
            this.InitializeComponent();
        }

        private async void btnStartup_Click(object sender, RoutedEventArgs e)
        {
            // Сначала проверяем состояние автозапуска. Получаем его в переменную startupTask
            StartupTask startupTask = await StartupTask.GetAsync("SomeIdThatIUseWithThisApp");
            switch (startupTask.State)
            {
                case StartupTaskState.Disabled:
                    // В случае если автозапуск просто выключен пробуем его включить
                    StartupTaskState newState = await startupTask.RequestEnableAsync();
                    // в переменной newState будет получен результат того было ли включение автозапуска благополучным
                    break;
                case StartupTaskState.DisabledByUser:
                    // Здесь автоматически включить автозапуск не получится. Раз выключено пользователем, то значит он автоматически его не хочет включать…
                    break;
                case StartupTaskState.DisabledByPolicy:
                    // автозапуск выключен групповыми политиками или не поддерживается устройством
                    break;
                case StartupTaskState.Enabled:
                    // все уже включено :)
                    break;
            }

        }
    }
}
