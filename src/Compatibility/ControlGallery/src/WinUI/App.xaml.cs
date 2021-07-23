﻿namespace Microsoft.Maui.Controls.Compatibility.ControlGallery.WinUI
{
	/// <summary>
	/// Provides application-specific behavior to supplement the default Application class.
	/// </summary>
	sealed partial class App : MauiWinUIApplication
	{
		public static bool RunningAsUITests { get; internal set; }

		/// <summary>
		/// Initializes the singleton application object.  This is the first line of authored code
		/// executed, and as such is the logical equivalent of main() or WinMain().
		/// </summary>
		public App()
		{
			InitializeComponent();
		}

		protected override MauiAppBuilder CreateAppBuilder() => WinUIMauiProgram.CreateAppBuilder();
	}
}
