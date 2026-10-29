using System;
using System.Collections.Generic;
using UnityEngine;

namespace Anhertis.Localization
{
    [Serializable]
    public class LocalizedTextInline : ILocalizedText
    {
        [SerializeField] private List<LocalizedTextEntry> _entries;

        public IReadOnlyList<LocalizedTextEntry> Entries => _entries;
    }
}