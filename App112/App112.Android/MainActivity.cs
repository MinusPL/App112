﻿
using Android.App;
using Android.Content.PM;
using Android.OS;

namespace App112.Droid {
	[Activity(
	Label = "App112",
	Icon = "@drawable/icon",
	Theme = "@style/MainTheme",
	MainLauncher = true,
	ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation
	)]
#pragma warning disable 1591
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity {
#pragma warning restore 1591

		/// <inheritdoc />
		protected override void OnCreate(Bundle bundle) {
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);
			LoadApplication(new App());
		}
	}
}
