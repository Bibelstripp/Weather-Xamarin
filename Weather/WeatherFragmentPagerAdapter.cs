using System;
using System.Collections.Generic;
using Android.Support.V4.App;
using Android.Views;
using Android.OS;

namespace Weather
{
	public class WeatherFragmentPagerAdapter : Android.Support.V4.App.FragmentPagerAdapter
	{
		private List<Android.Support.V4.App.Fragment> fragments = new List<Android.Support.V4.App.Fragment> ();

		public WeatherFragmentPagerAdapter (Android.Support.V4.App.FragmentManager fm) : base(fm)
		{
		}

		public override int Count
		{
			get{ return fragments.Count; }
		}

		public override Android.Support.V4.App.Fragment GetItem (int position)
		{
			return fragments [position];
		}

		public void AddFragment (WeatherFragment fragment)
		{
			fragments.Add (fragment);
		}

		public void AddFragmentView(Func<LayoutInflater, ViewGroup, Bundle, View> view)
		{
			fragments.Add(new WeatherFragment(view));
		}
	}
}

