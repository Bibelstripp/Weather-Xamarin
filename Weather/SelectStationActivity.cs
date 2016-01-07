using System;
using System.Linq;
using System.Threading;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Util;

using Weather.eklima.met.no;

using Newtonsoft.Json;

namespace Weather
{
	[Activity (Label = "Weather", Icon = "@drawable/icon")] //MainLauncher betyr at denne er hoved siden true/false
	public class SelectStationActivity : ListActivity
	{
		private StationAdapter adapter;
		protected override void OnCreate (Bundle bundle) //denne kjører når man starter appen føste gang //bundle er for å 
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.SelectStationLayout);

		}

		protected override void OnStart () //denne kjøres først hver gang appen startes
		{
			base.OnStart ();

			ThreadPool.QueueUserWorkItem (o => LoadStations());
		}

		private void LoadStations()
		{
			var service = new MetDataService ();
			var result = service.getStationsFromTimeserieType (TimeSeriesType.DailyValues, "");
			var stations = result.Select (s => new Station (s.stnr, s.name, s.department));

			RunOnUiThread (() => LoadStationsComplete (stations));
		}

		private void LoadStationsComplete(IEnumerable<Station> stations)
		{
			this.adapter = new StationAdapter(this, stations);
			this.ListAdapter = this.adapter;
			FindViewById<RelativeLayout> (Resource.Id.loadingPanel).Visibility = ViewStates.Gone;
		}

		protected override void OnListItemClick (ListView l, View v, int position, long id)
		{
			var station = adapter[position];
			var mainIntent = new Intent (this, typeof(MainActivity));
//			mainIntent.PutExtra ("station.name", station.Name); //PutExtra og GetExtra hører sammen, første parameter er nøkkelen
//			mainIntent.PutExtra ("station.number", station.Number);

			var json = JsonConvert.SerializeObject (station); //denne sender med hele station som et json object som da kan erstatte PutExtra
			//bli plukket opp i MainActivity -> OnActivityResult -> JsonConvert.DeserializeObject

			mainIntent.PutExtra ("station", json);
			SetResult (Result.Ok, mainIntent); //dette blir sendt tilbake til MainActivity -> OnActivityResult med de to siste parameterene

			Finish ();//Finish (); //brukes for å si ifra at nå er denne aktiviteten ferdig, du kan frigjøre ressursene og gå tilbake til den aktiviteten du var på før denne ble kalt
			//nå gjelder det å plukke opp denne informasjonen på andre siden ->MainActivity -> OnActivityResult
		}

		private void ShowToast(string text){
			var toast = Toast.MakeText (this, text, ToastLength.Short);
			toast.Show ();
		}
	}
}


