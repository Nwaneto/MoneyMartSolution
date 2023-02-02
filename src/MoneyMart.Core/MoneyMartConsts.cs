using MoneyMart.Debugging;

namespace MoneyMart
{
    public class MoneyMartConsts
    {
        public const string LocalizationSourceName = "MoneyMart";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "ad6d189e61b94bf696e72cab839b63b8";
    }
}
