using UnityEngine;
using System.Collections.Generic;

namespace Anhertis.Localization
{
    [CreateAssetMenu(fileName = "LocalizedTextSO", menuName = "Game/Localization/LocalizedTextSO")]
    public class LocalizedTextScriptableObject : ScriptableObject, ILocalizedText
    {
        [SerializeField] private List<LocalizedTextEntry> _entries = new();

        public IReadOnlyList<LocalizedTextEntry> Entries => _entries;
    }
}