using System.Collections.Generic;
using System;
using UnityEngine;

namespace Anhertis.Localization
{
    [Serializable]
    public class LocalizedTextScriptableObjectWrapper : ILocalizedText
    {
        [SerializeField] private LocalizedTextScriptableObject _asset;

        public LocalizedTextScriptableObjectWrapper(LocalizedTextScriptableObject asset)
        {
            _asset = asset;
        }

        public IReadOnlyList<LocalizedTextEntry> Entries =>
            _asset != null ? _asset.Entries : null;
    }
}