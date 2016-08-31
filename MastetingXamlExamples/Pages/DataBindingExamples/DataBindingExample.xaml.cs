using System;
using System.Collections.Generic;
using MastetingXamlExamples.ViewModels;
using Xamarin.Forms;

namespace MastetingXamlExamples.Pages.DataBindingExamples
{
	public partial class DataBindingExample : ContentPage
	{
		public DataBindingExample ()
		{
			InitializeComponent ();
			BindingContext = new CustomHomeViewModel ();
		}

		void Handle_Clicked (object sender, System.EventArgs e)
		{
			nameEntry.IsVisible = false;
			lastNameEntry.IsVisible = true;
		}
	}
}

