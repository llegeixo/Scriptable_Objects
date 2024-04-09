using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Translation", menuName = "Translation")]
public class TranslationScriptableObject : ScriptableObject
{
    public string languageName;
    public string translatedText;

}

