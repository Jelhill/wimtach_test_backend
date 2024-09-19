using ProJeliliV1.Debugging;

namespace ProJeliliV1
{
    public class ProJeliliV1Consts
    {
        public const string LocalizationSourceName = "ProJeliliV1";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = false;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "9941dd3d21b44cc19ccd6a8586ea7d55";
    }
}
