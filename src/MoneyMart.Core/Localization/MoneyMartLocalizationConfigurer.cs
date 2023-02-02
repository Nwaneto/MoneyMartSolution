using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace MoneyMart.Localization
{
    public static class MoneyMartLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(MoneyMartConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(MoneyMartLocalizationConfigurer).GetAssembly(),
                        "MoneyMart.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
