using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MastetingXamlExamples.Views
{
	public partial class CustomTestView : ContentView
	{
		public CustomTestView (string param1, double param2)
		{
			InitializeComponent ();
			testLabel.Text = $"{param1} {param2}";
		}
	}
}

