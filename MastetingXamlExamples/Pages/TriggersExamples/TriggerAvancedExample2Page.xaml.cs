using System;
using System.Collections.Generic;
using MastetingXamlExamples.ViewModels;
using Xamarin.Forms;

namespace MastetingXamlExamples.Pages
{
	public partial class TriggerAvancedExample2Page : ContentPage
	{
		public TriggerAvancedExample2Page ()
		{
			InitializeComponent ();
			BindingContext = new TriggerAvancedExampleViewModel ();
		}
	}
}

