using Microsoft.Maui.Controls.Compatibility.Hosting;

namespace VersalityApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("Poppins-Bold.ttf", "PoppinsBold");
				fonts.AddFont("Poppins-ExtraLight.ttf", "PoppinsExtraLight");
				fonts.AddFont("Poppins-Medium.ttf", "PoppinsMedium");
			});
			//.ConfigureMauiHandlers(handler =>
			//{
			//	handler.AddCompatibilityRenderer(typeof(PdfWebView), typeof(PdfWebViewRenderer));
			//});

		return builder.Build();
	}
}
