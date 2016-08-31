using System;
using System.Collections.Generic;
using MastetingXamlExamples.ViewModels;
using Xamarin.Forms;

namespace MastetingXamlExamples.Pages.ContentViewsExamples
{
	public partial class CustomHomePage : ContentPage
	{
		public CustomHomePage ()
		{
			InitializeComponent ();
			BindingContext = new CustomHomeViewModel ();
		}
	}
}

