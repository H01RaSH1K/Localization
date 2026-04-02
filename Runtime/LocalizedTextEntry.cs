using System;
using UnityEngine;

[Serializable]
public class LocalizedTextEntry 
{ 
    [SerializeField] private string _languageCode;
    [SerializeField] private string _text;

    public LocalizedTextEntry(string languageCode, string text)
    {
        _languageCode = languageCode;
        _text = text;
    }

    public string LanguageCode => _languageCode;
    public string Text => _text;
}
