using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Simulator.ViewModels;
using System.Windows;

namespace Simulator
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
            => Ioc.Default.ConfigureServices(
                new ServiceCollection()
                .AddSingleton(this)
                .AddSingleton<MainWindow>()
                .AddSingleton<MainWindowViewModel>()
                .BuildServiceProvider());

        protected override void OnStartup(StartupEventArgs e)
        {
            Ioc.Default.GetService<MainWindowViewModel>();
            Ioc.Default.GetRequiredService<MainWindow>().Show();
            base.OnStartup(e);
        }
    }
}
