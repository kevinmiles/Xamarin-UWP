﻿//
//  Copyright © 2018 PSPDFKit GmbH. All rights reserved.
//
//  The PSPDFKit Sample applications are licensed with a modified BSD license.
//  Please see License for details. This notice may not be removed from this file.
//

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPDF.ViewModels;

namespace XamarinPDF.Views {
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AboutPage : ContentPage {
		public AboutPage () => InitializeComponent ();

		protected override async void OnAppearing ()
		{
			base.OnAppearing ();

			if (BindingContext is AboutPageViewModel bc)
				await bc.LoadLicense ();
		}
	}
}