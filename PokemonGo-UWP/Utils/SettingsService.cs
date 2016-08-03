using Template10.Services.SettingsService;

namespace PokemonGo_UWP.Utils
{
    public class SettingsService
    {
        public static readonly SettingsService Instance;

        private readonly SettingsHelper _helper;

        static SettingsService()
        {
            Instance = Instance ?? new SettingsService();
        }

        private SettingsService()
        {
            _helper = new SettingsHelper();
        }

        public string PtcAuthToken
        {
            get { return _helper.Read(nameof(PtcAuthToken), string.Empty); }
            set { _helper.Write(nameof(PtcAuthToken), value); }
        }

        public int LastLevelAwardReceived
        {
            // we're defaulting the base value to 1 because you don't get any awards for the first level
            get { return _helper.Read(nameof(LastLevelAwardReceived), 1) ; }
            set { _helper.Write(nameof(LastLevelAwardReceived), value);}
        }
    }
}