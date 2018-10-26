using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace XF.ControlesBasicos
{
	public partial class App : Application
	{
        public static ControleViewModel ControlesVM { get; set; }
		public App ()
		{
			InitializeComponent();

            if (ControlesVM == null) ControlesVM = new ControleViewModel();

            MainPage = new NavigationPage(MainPage = new MainPage() { BindingContext = App.ControlesVM});

        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
