using System;
using System.Collections.Generic;
using System.Diagnostics;
using MastetingXamlExamples.ViewModels;
using Xamarin.Forms;

namespace MastetingXamlExamples.Pages
{
	public partial class ExtraTricksInXamlPage : ContentPage
	{
		public ExtraTricksInXamlPage ()
		{
			InitializeComponent ();
			BindingContext = new CustomHomeViewModel ();

		}
	}
}

