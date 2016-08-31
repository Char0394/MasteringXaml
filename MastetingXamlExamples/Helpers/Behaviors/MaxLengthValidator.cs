using System;
using Xamarin.Forms;

namespace MastetingXamlExamples.Helpers.Behaviors
{
	public class MaxLengthValidator : Behavior<Entry>
	{
		public static readonly BindableProperty MaxLengthProperty = BindableProperty.Create ("MaxLength", typeof (int), typeof (MaxLengthValidator), 0);

		static readonly BindablePropertyKey IsValidPropertyKey = BindableProperty.CreateReadOnly ("IsMax", typeof (bool), typeof (MaxLengthValidator), false);

		public static readonly BindableProperty IsValidProperty = IsValidPropertyKey.BindableProperty;

		public bool IsMax {
			get { return (bool)base.GetValue (IsValidProperty); }
			private set { base.SetValue (IsValidPropertyKey, value); }
		}
		public int MaxLength {
			get { return (int)GetValue (MaxLengthProperty); }
			set { SetValue (MaxLengthProperty, value); }
		}

		protected override void OnAttachedTo (Entry bindable)
		{
			bindable.TextChanged += bindable_TextChanged;
		}

		private void bindable_TextChanged (object sender, TextChangedEventArgs e)
		{
			if (e != null && e.NewTextValue != null) {
				if (e.NewTextValue.Length > 0 && e.NewTextValue.Length > MaxLength) {
					((Entry)sender).Text = e.NewTextValue.Substring (0, MaxLength);
					IsMax = true;
				} else
					IsMax = false;
			}
		}

		protected override void OnDetachingFrom (Entry bindable)
		{
			bindable.TextChanged -= bindable_TextChanged;

		}
	}
}


