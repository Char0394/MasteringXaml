using System;
using Xamarin.Forms;

namespace MastetingXamlExamples.Helpers.Behaviors
{
	public class NumericValidationBehavior : Behavior<Entry>
	{
		protected override void OnAttachedTo (Entry entry)
		{
			entry.TextChanged += OnEntryTextChanged;
			base.OnAttachedTo (entry);
		}

		protected override void OnDetachingFrom (Entry entry)
		{
			entry.TextChanged -= OnEntryTextChanged;
			base.OnDetachingFrom (entry);
		}

		void OnEntryTextChanged (object sender, TextChangedEventArgs args)
		{
			double result;
			if (!string.IsNullOrEmpty (args.NewTextValue)) {
				bool isValid = Double.TryParse (args.NewTextValue, out result);
				if (!isValid)
					((Entry)sender).Text = args.NewTextValue.Substring (0, args.NewTextValue.Length - 1);
			}
		}
	}
}
