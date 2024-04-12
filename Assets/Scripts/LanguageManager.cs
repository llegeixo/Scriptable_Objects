using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageManager : MonoBehaviour
{
    public Text _displayText;
    public Text _displayText1;
    public Text _displayText2;
    public Text _displayText3;
    public TranslationScriptableObject[] _translations;

    public void TranslateText(string language)
    {
        foreach (TranslationScriptableObject translation in _translations)
        {
            if (translation.languageName == language)
            {
                _displayText.text = translation.translatedText;
                _displayText1.text = translation.translatedText1;
                _displayText2.text = translation.translatedText2;
                _displayText3.text = translation.translatedText3;
                return;
            }
        }


    }
}
