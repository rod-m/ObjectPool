using UnityEditor;
using UnityEngine;

namespace SaveGameState.Editor
{
    public class ClearPlayerPrefs
    {
        [MenuItem("Tools/Clear Prefs")]
        private static void NewMenuOption()
        {
            PlayerPrefs.DeleteAll();
        }
        
    }
}