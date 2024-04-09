using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageManager : MonoBehaviour
{
    public Text _displayText;
    public TranslationScriptableObject[] _translations;

    public void TranslateText(string language)
    {
        foreach (TranslationScriptableObject translation in _translations)
        {
            if (translation.languageName == language)
            {
                _displayText.text = translation.translatedText;
                return;
            }
        }


    }
}
