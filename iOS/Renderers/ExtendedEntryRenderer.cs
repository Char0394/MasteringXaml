using System;
using MastetingXamlExamples.Controls;
using MastetingXamlExamples.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer (typeof (ExtendedEntry), typeof (ExtendedEntryRenderer))]
namespace MastetingXamlExamples.iOS.Renderers
{
	public class ExtendedEntryRenderer : EntryRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.Entry> e)
		{
			base.OnElementChanged (e);

			if (Control == null || e.NewElement == null) return;

			if (((ExtendedEntry)this.Element).IsBorderVisible) {
				this.Control.Layer.BorderColor = UIColor.Green.CGColor;
				this.Control.Layer.BorderWidth = new nfloat (0.5);
				this.Control.Layer.CornerRadius = 5;
			} else {
				this.Control.Layer.BorderColor = UIColor.LightGray.CGColor;
				this.Control.Layer.CornerRadius = 5;
				this.Control.Layer.BorderWidth = new nfloat (0.5);

			}
		}
		protected override void OnElementPropertyChanged (object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged (sender, e);

			if (Control == null) return;

			if (((ExtendedEntry)this.Element).IsBorderVisible) {
				this.Control.Layer.BorderColor = UIColor.Green.CGColor;
				this.Control.Layer.BorderWidth = new nfloat (0.5);
				this.Control.Layer.CornerRadius = 5;
			} else {
				this.Control.Layer.BorderColor = UIColor.LightGray.CGColor;
				this.Control.Layer.CornerRadius = 5;
				this.Control.Layer.BorderWidth = new nfloat (0.5);
			}
		}
	}
}
