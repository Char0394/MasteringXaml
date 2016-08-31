using MastetingXamlExamples.Pages;
using MastetingXamlExamples.Pages.BehaviorsExamples;
using MastetingXamlExamples.Pages.ContentViewsExamples;
using MastetingXamlExamples.Pages.DataBindingExamples;
using MastetingXamlExamples.Pages.StylesExamples;
using MastetingXamlExamples.StylesExamples;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace MastetingXamlExamples
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent ();

			MainPage = new NavigationPage(new ExtraTricksInXamlPage ());
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

