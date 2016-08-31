using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MastetingXamlExamples.Pages.StylesExamples
{
	public partial class UseDynamicStyleExamplePage : ContentPage
	{
		bool continueCounter;
		int cont = 0;
		public UseDynamicStyleExamplePage ()
		{
			InitializeComponent ();
		}

		protected override void OnAppearing ()
		{
			continueCounter = true;
			Device.StartTimer (TimeSpan.FromSeconds (1),
				() => {
					Resources ["currectCounter"] = cont++;
					return continueCounter;
				});
			base.OnAppearing ();
		}

		protected override void OnDisappearing ()
		{
			continueCounter = false;
			base.OnDisappearing ();
		}

	}
}

