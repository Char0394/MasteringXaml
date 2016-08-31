using System;
using MastetingXamlExamples.Controls;
using Xamarin.Forms;

namespace MastetingXamlExamples.Helpers.Behaviors
{
	public class EmptyEntryValidatorBehavior : Behavior<ExtendedEntry>
	{
		public static readonly BindableProperty DefaultPlaceHolderProperty =
			BindableProperty.Create (nameof (DefaultPlaceHolder), typeof (string), typeof (EmptyEntryValidatorBehavior), string.Empty);

		public string DefaultPlaceHolder {
			get { return (string)GetValue (DefaultPlaceHolderProperty); }
			set {
				SetValue (DefaultPlaceHolderProperty, value);
			}
		}

		public static readonly BindableProperty TextRequiredProperty =
			BindableProperty.Create (nameof (TextRequired), typeof (string), typeof (EmptyEntryValidatorBehavior), string.Empty);

		public string TextRequired {
			get { return (string)GetValue (TextRequiredProperty); }
			set {
				SetValue (TextRequiredProperty, value);
			}
		}
		protected override void OnAttachedTo (ExtendedEntry bindable)
		{
			bindable.TextChanged += HandleTextChanged;
			bindable.PropertyChanged += PropertyChange;
		}
		void PropertyChange (object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (e.PropertyName == ExtendedEntry.IsBorderVisibleProperty.PropertyName) {
				if (((ExtendedEntry)sender).IsBorderVisible) {
					((Entry)sender).Placeholder = TextRequired;
					((Entry)sender).PlaceholderColor = Color.Green;
				} else {
					((Entry)sender).Placeholder = DefaultPlaceHolder;
					((Entry)sender).PlaceholderColor = Color.Default;

				}
			}
		}
		void HandleTextChanged (object sender, TextChangedEventArgs e)
		{
			if (!string.IsNullOrEmpty (e.NewTextValue)) {
				((ExtendedEntry)sender).IsBorderVisible = false;
			}

		}

		protected override void OnDetachingFrom (ExtendedEntry bindable)
		{
			bindable.TextChanged -= HandleTextChanged;
			bindable.PropertyChanged -= PropertyChange;

		}
	}
}
