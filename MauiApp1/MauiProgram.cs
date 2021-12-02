using Microsoft.AspNetCore.Components.WebView.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using MauiApp1.Data;
using Blazorise;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;

namespace MauiApp1
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.RegisterBlazorMauiWebView()
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				});

			builder.Services.AddBlazorWebView();
			builder.Services.AddSingleton<WeatherForecastService>();

			builder.Services.AddBlazorise(options =>
				   {
					   options.ChangeTextOnKeyPress = true; // optional
				   })
			  .AddBootstrap5Providers()
			  .AddFontAwesomeIcons();

			return builder.Build();
		}
	}
}