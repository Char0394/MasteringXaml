using System;
using PropertyChanged;
using Xamarin.Forms;

namespace MastetingXamlExamples.Controls
{
	[ImplementPropertyChanged]
	public class ExtendedEntry : Entry
	{
		public bool IsWhite { get; set; }

		public static readonly BindableProperty IsBorderVisibleProperty =
			BindableProperty.Create (nameof (IsBorderVisible), typeof (bool), typeof (ExtendedEntry), false, BindingMode.TwoWay);


		public bool IsBorderVisible {
			get { return (bool)GetValue (IsBorderVisibleProperty); }
			set {
				SetValue (IsBorderVisibleProperty, value);
			}
		}
	}
}

