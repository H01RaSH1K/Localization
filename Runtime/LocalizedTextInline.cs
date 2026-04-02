using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class LocalizedTextInline : ILocalizedText
{
    [SerializeField] private List<LocalizedTextEntry> _entries;

    public IReadOnlyList<LocalizedTextEntry> Entries => _entries;
}