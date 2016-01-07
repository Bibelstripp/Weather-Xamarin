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

using Newtonsoft.Json;

namespace Weather
{
	[Activity (Label = "Main", MainLauncher = true)]			
	public class MainActivity : Activity
	{
		private int selectedStationNumber;
		private string selectedStationName;
		private Station selectedStation;

		protected override void OnCreate (Bundle savedInstanceState) //OnCreate: 1  //bundle is for passing state information.. her kan man da lagre hvilken aktivitet som kjøres slik at når man snur skjermen beholder den der du var
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.MainLayout);

			//kalle denne metoden for å lagre info om valgt stasjon hvis bruker har avsluttet appen
			//settes etter at layouten/viewet er satt
			LoadSelectedStation ();

			Button selectStation = FindViewById<Button> (Resource.Id.selectStation);
			selectStation.Click += delegate {
				StartActivityForResult(new Intent(this, typeof(SelectStationActivity)), 0); //StartActivityForResult er for å få med verdien tilbake til et annet view, bruker kun StartActivity hvis vi ikke skal ha med noen verdier tilbake
//			     den andre parameteren 0 er en requestCode, koden identifiserer hva slags type resultet det forventer..det brukes også når man skal ta imot
//				 når denne activiteten eksisterer; OnActivityResult (under) er kalt med den gjeldene requestCode
			};

			Button lastWeek = FindViewById<Button> (Resource.Id.lastWeek);
			lastWeek.Click += delegate {
				var intent = new Intent(this, typeof(LastWeek)); //intent brukes for å sende mellom views
				intent.PutExtra("station.number", selectedStation.Number);
				StartActivity(intent);
			};
		}

		protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
		//this is called when finish() method (SelectStationActivity -> OnListItemClick)
		//request code= 0 (StartActivityForResult, andre parameter (se over))
		//resultCode = enum fra SelectStationActivity -> onListItemClick -> SetResult (Result.Ok, mainIntent)
		//data = intenten fra SelectStationActivity -> onListItemClick -> SetResult (Result.Ok, mainIntent)
		{
			base.OnActivityResult(requestCode, resultCode, data);
			if (resultCode == Result.Ok) {
				var json = data.GetStringExtra ("station");
				var station = JsonConvert.DeserializeObject<Station> (json);

				var selectedStationLabel = FindViewById<TextView> (Resource.Id.selectedStationLabel);
				//selectedStationName = data.GetStringExtra("station.name"); //denne ble brukt førvi laget et json objekt som sender med både inten og stringen altså hele objektet
				selectedStationLabel.Text = station.Name;
				//selectedStationNumber = data.GetIntExtra ("station.number", -1); //denne ble brukt førvi laget et json objekt som sender med både inten og stringen altså hele objektet
				SaveSelectedStation (station);

			}
		}

		//metode for å skrive til en database der vi skal,i dette tilfellet, lagre staten for at vi vil beholde 
		//stasjonen vi har valgt selv om vi bruker back knappen på mobilen og appen lukkes
		//dette er det vi trenger for å skrive data til sharedPreferences
		private void SaveSelectedStation (Station station)
		{
			//var contextPreferences = Application.Context.GetSharedPreferences("WeatherApp", FileCreationMode.Private); //FileCreationMode.Private betyr at det ikke er noen andre apper som får lov til å bruke den
			//var editableContextPreferences = contextPreferences.Edit();

			var json = JsonConvert.SerializeObject (station); //denne sender med hele station som et json object som da kan erstatte PutExtra
			//bli plukket opp i SelectStationActivity -> OnActivityResult -> JsonConvert.DeserializeObject

			editableContextPreferences.PutString("selectedStation", json);
			editableContextPreferences.Commit();
		}

		//så trenger vi en metode for å hente dataen ut på
		private void LoadSelectedStation()
		{
			var contextPreferences = Application.Context.GetSharedPreferences("WeatherApp", FileCreationMode.Private); //FileCreationMode.Private betyr at det ikke er noen andre apper som får lov til å bruke den


			//var json = contextPreferences.GetString("selectedStation", null);
			if (json == null) { //hvis det ikke finnes noe lagret data (altså det er første gang man kjører appen) skal man bare returnere fra metoden og fortsette
				return;
			}
			selectedStation = JsonConvert.DeserializeObject<Station> (json);

			var selectedStationLabel = FindViewById<TextView> (Resource.Id.selectedStationLabel);
			selectedStationLabel.Text = selectedStation.Name;
		}

		protected override void OnSaveInstanceState (Bundle outState)
		{
			var json = JsonConvert.SerializeObject (selectedStation);
			outState.PutString ("selectedStation", json);

			base.OnSaveInstanceState (outState);
		}

		protected override void OnRestoreInstanceState (Bundle savedInstanceState)
		{
			var selectedStationLabel = FindViewById<TextView> (Resource.Id.selectedStationLabel);
			var json = savedInstanceState.GetString("selectedStation");
			this.selectedStation = JsonConvert.DeserializeObject<Station> (json);

			selectedStationLabel.Text = this.selectedStation.Name;

			base.OnRestoreInstanceState (savedInstanceState);
		}
	}
}

