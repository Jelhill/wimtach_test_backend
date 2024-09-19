using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ProJeliliV1.Localization
{
    public static class ProJeliliV1LocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ProJeliliV1Consts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ProJeliliV1LocalizationConfigurer).GetAssembly(),
                        "ProJeliliV1.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
