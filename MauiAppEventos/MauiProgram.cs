using Microsoft.Extensions.Logging;

namespace MauiAppEventos
{
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
                    //fonte padrão

                    fonts.AddFont("Caveat-Bold.ttf", "CaveatBold");
                    fonts.AddFont("Caveat-Medium.ttf", "CaveatMedium");
                    fonts.AddFont("Caveat-Regular.ttf", "CaveatRegular");
                    fonts.AddFont("Caveat-SemiBold.ttf", "CaveatSemiBold");
                    fonts.AddFont("Caveat-VariableFont_wght.ttf", "CaveatVariableFontwght");
                    //fonte Caveat (google fontes)
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
