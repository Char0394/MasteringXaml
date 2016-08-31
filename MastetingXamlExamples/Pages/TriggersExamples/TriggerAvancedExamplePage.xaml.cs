using System;
using System.Collections.Generic;
using MastetingXamlExamples.ViewModels;
using Xamarin.Forms;

namespace MastetingXamlExamples.Pages
{
	public partial class TriggerAvancedExamplePage : ContentPage
	{
		public TriggerAvancedExamplePage ()
		{
			InitializeComponent ();
			BindingContext = new TriggerAvancedExampleViewModel ();
		}
	}
}

