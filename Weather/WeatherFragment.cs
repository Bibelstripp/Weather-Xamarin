using System;
using Android.App;
using Android.OS;
using Android.Views;

namespace Weather
{
	public class WeatherFragment : Android.Support.V4.App.Fragment
	{
		private Func<LayoutInflater, ViewGroup, Bundle, View> view;

		public WeatherFragment (Func<LayoutInflater, ViewGroup, Bundle, View> view)
		{
			this.view = view;
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			base.OnCreateView (inflater, container, savedInstanceState);
			return view (inflater, container, savedInstanceState);
		}
	}
}

