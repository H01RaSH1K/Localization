using System.Collections.Generic;

namespace Localization
{
    public interface ILocalizedText
    {
        public IReadOnlyList<LocalizedTextEntry> Entries { get; }

        public string GetText(string languageCode)
        {
            if (string.IsNullOrEmpty(languageCode))
                return string.Empty;

            foreach (LocalizedTextEntry localizedText in Entries)
            {
                if (localizedText.LanguageCode == languageCode)
                    return localizedText.Text;
            }

            return string.Empty;
        }
    }
}