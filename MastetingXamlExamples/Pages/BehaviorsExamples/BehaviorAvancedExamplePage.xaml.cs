using System;
using System.Collections.Generic;
using MastetingXamlExamples.ViewModels;
using Xamarin.Forms;

namespace MastetingXamlExamples.Pages.BehaviorsExamples
{
	public partial class BehaviorAvancedExamplePage : ContentPage
	{
		public BehaviorAvancedExamplePage ()
		{
			InitializeComponent ();
			BindingContext = new CustomHomeViewModel ();
		}
	}
}

