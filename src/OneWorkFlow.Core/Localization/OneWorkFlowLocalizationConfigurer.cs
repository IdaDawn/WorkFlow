using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace OneWorkFlow.Localization
{
    public static class OneWorkFlowLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(OneWorkFlowConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(OneWorkFlowLocalizationConfigurer).GetAssembly(),
                        "OneWorkFlow.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
