using AvalonDock.Themes;
using AvalonDockSample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AvalonDockSample.ViewModels
{
	internal class Workspace : ViewModelBase
	{
		#region fields

		private static Workspace _this = new Workspace();
		private Tuple<string, Theme> _selectedTheme;

		#endregion fields

		#region constructors

		/// <summary>
		/// Class constructor
		/// </summary>
		public Workspace()
		{
			SelectedTheme = Themes.First();
		}

		#endregion constructors

		#region properties

		public static Workspace This => _this;

		public List<Tuple<string, Theme>> Themes { get; set; } = new List<Tuple<string, Theme>>
		{
			new Tuple<string, Theme>(nameof(Vs2013DarkTheme),new Vs2013DarkTheme()),
			new Tuple<string, Theme>(nameof(Vs2013LightTheme),new Vs2013LightTheme()),
			new Tuple<string, Theme>(nameof(Vs2013BlueTheme),new Vs2013BlueTheme())
		};

		public Tuple<string, Theme> SelectedTheme
		{
			get { return _selectedTheme; }
			set
			{
				_selectedTheme = value;
				SwitchExtendedTheme();
				RaisePropertyChanged(nameof(SelectedTheme));
			}
		}

		#endregion properties

		#region methods

		private void SwitchExtendedTheme()
		{
/*			switch (_selectedTheme.Item1)
			{
				case "Vs2013DarkTheme":
					Application.Current.Resources.MergedDictionaries[0].Source = new Uri("pack://application:,,,/MLib;component/Themes/DarkTheme.xaml");
					Application.Current.Resources.MergedDictionaries[1].Source = new Uri("pack://application:,,,/VS2013Test;component/Themes/DarkBrushsExtended.xaml");
					break;
				case "Vs2013LightTheme":
					Application.Current.Resources.MergedDictionaries[0].Source = new Uri("pack://application:,,,/MLib;component/Themes/LightTheme.xaml");
					Application.Current.Resources.MergedDictionaries[1].Source = new Uri("pack://application:,,,/VS2013Test;component/Themes/LightBrushsExtended.xaml");
					break;
				case "Vs2013BlueTheme":
					//TODO: Create new color resources for blue theme
					Application.Current.Resources.MergedDictionaries[0].Source = new Uri("pack://application:,,,/MLib;component/Themes/LightTheme.xaml");
					Application.Current.Resources.MergedDictionaries[1].Source = new Uri("pack://application:,,,/VS2013Test;component/Themes/BlueBrushsExtended.xaml");
					break;
				default:
					break;
			}*/
		}

		#region OpenCommand

		private bool CanOpen(object parameter) => true;

		#endregion OpenCommand

		#region NewCommand

		private bool CanNew(object parameter)
		{
			return true;
		}

		#endregion NewCommand

		#endregion methods
	}
}
