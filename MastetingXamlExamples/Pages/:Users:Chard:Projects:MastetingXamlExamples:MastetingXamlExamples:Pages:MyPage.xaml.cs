using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MastetingXamlExamples.Pages
{
	public partial class MyPage : ContentPage
	{
		public MyPage ()
		{
			InitializeComponent ();

			var label = new Label () { Text="Hello 1"};
			var label2 = new Label () { Text = "Hello 2" };

			Content = new StackLayout {
				Orientation = StackOrientation.Horizontal,
				Children =
				{
					label,
					label2
				}
			 };
		}
	}
}

