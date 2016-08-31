using System;
using MastetingXamlExamples.Helpers;
using Xamarin.Forms;

namespace MastetingXamlExamples.ViewModels
{
	public class TriggerAvancedExampleViewModel: BaseViewModel
	{
		public bool IsItemMenuCheckOutSelected { get; set; } = true;
		public bool IsItemMenuSheetSelected { get; set; }
		public bool IsItemMenuSellerSelected { get; set; }

		public TriggerAvancedExampleViewModel ()
		{
		}

		public Command MenuSelectedCommand {
			get {
				return new Command ((param) => {

					IsItemMenuCheckOutSelected = (param.ToString () == FoodTypeEnum.Fruits.ToString ());
					IsItemMenuSheetSelected = (param.ToString () == FoodTypeEnum.Chicken.ToString ());
					IsItemMenuSellerSelected = (param.ToString () == FoodTypeEnum.Juices.ToString ());
				});
			}
		}
	}
}

