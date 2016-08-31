using System;
using MastetingXamlExamples.Pages.ContentViewsExamples;
using PropertyChanged;
using Xamarin.Forms;

namespace MastetingXamlExamples.ViewModels
{
	[ImplementPropertyChanged]
	public class CustomHomeViewModel: BaseViewModel
	{
		public bool FirstNameRequired { get; set; }
		public string Email { get; set; }

		public bool FirstNameEntryIsVisible { get; set; } = true;
		public bool LasttNameEntryIsVisible { get; set; }

		public double TestNumber { get; set; } = 34;

		public CustomHomeViewModel ()
		{
			
		}

		public Command OnGotoProfileCommand {
			get {
				return new Command (() => {

					App.Current.MainPage.Navigation.PushAsync (new CustomProfilePage ());
				});
			}
		}
		public Command OnValidateEntryCommand {
			get {
				return new Command (() => {

					FirstNameRequired = string.IsNullOrEmpty (Email);
				});
			}
		}

		public Command OnNextCommand {
			get {
				return new Command (() => {

					FirstNameEntryIsVisible = false;
					LasttNameEntryIsVisible = true;
				});
			}
		}
	}
}

