using System;
using PropertyChanged;

namespace MastetingXamlExamples.ViewModels
{
	[ImplementPropertyChanged]
	public class BaseViewModel
	{
		public bool IsBusy { get; set; }
	}
}

