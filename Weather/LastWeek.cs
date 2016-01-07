
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V4.View; //NuGet
using Android.Support.V4.App; //NuGet

using Weather.eklima.met.no;

namespace Weather
{
	[Activity (Label = "LastWeek")]			
	public class LastWeek : FragmentActivity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.WeatherLayout);
			ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;

			var pager = FindViewById<ViewPager> (Resource.Id.pager);
			var adapter = new WeatherFragmentPagerAdapter (SupportFragmentManager);

			var data = GetWeatherData ();

			foreach (var item in data) {
				adapter.AddFragmentView ((i, v, b) => {
					var view = i.Inflate (Resource.Layout.WeatherTab, v, false);

					var dayView = view.FindViewById<TextView> (Resource.Id.day);
					dayView.Text = item.Day.DayOfWeek.ToString () + " " + item.Day.ToString ("dd/MM");

					var temperatureView = view.FindViewById<TextView> (Resource.Id.temperature);
					temperatureView.Text = item.Temperature.ToString();

					return view;
				});
					
				var tab = ActionBar.NewTab ();
				var tabName = item.Day.DayOfWeek.ToString () + " " + item.Day.ToString ("dd/MM");// for å sette dato på tabbene
				tab.SetText (tabName);
				tab.TabSelected += (object sender, ActionBar.TabEventArgs e) => 
				{
					pager.SetCurrentItem (ActionBar.SelectedNavigationIndex, false);
				};

				ActionBar.AddTab (tab);// for å sette navn på tabbene
			}

			pager.Adapter = adapter;
			pager.AddOnPageChangeListener (new ViewPageListenerForActionBar (ActionBar));
		}

		private List<WeatherData> GetWeatherData()
		{
			var selectedStation = Intent.GetIntExtra ("station.number", -1).ToString();
			var timeseriesType = TimeSeriesType.DailyValues;
			var elements = Elements.GetString (Elements.Temperature);

			var service = new MetDataService ();
			var from = DateTime.Today.AddDays(-7).ToString ("yyyy-MM-dd");

			var metData = service.getMetData (timeseriesType, "", from, "", "18700", elements, "", "", "");
			var data = new List<WeatherData> ();
			foreach (var day in metData.timeStamp) 
			{
				var Location = day.location.First ();
				data.Add (new WeatherData{
					Temperature = double.Parse(Location.weatherElement.First().value),
					Day = day.from
				});
			}

			return data;
		}

		protected override void OnActivityResult (int requestCode, Result resultCode, Intent data)
		{
			base.OnActivityResult (requestCode, resultCode, data);
		}
	}

	public class TimeSeriesType{
		public const string DailyValues = "0";
	}

	public class Elements{
		public const string Temperature = "TAM";

		public static string GetString(params string[] elements){
			return string.Join(",", elements);
		}
	}

	public class ViewPageListenerForActionBar : ViewPager.SimpleOnPageChangeListener
	{
		private ActionBar _bar;

		public ViewPageListenerForActionBar(ActionBar bar)
		{
			_bar = bar;
		}

		public override void OnPageSelected(int position)
		{
			_bar.SetSelectedNavigationItem (position);
		}
	}
}

