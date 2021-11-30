using UnityEngine;

namespace SaveGameState
{
    public class SavePlayer
    {
        private const string nameKey = "PlayerName";
        public string Name
        {
            get
            {
                return PlayerPrefs.GetString(nameKey);
                
            }
            set
            {
                PlayerPrefs.SetString(nameKey, value);
                
            }
        }

        private const string level = "Level";
        public int Level
        {
            get { return PlayerPrefs.GetInt(level);}
            set{ PlayerPrefs.SetInt(level, value);}
        }
        public float Money;

        public void Save(int slot)
        {
            PlayerPrefs.SetString($"saveslot_{slot}_{nameKey}", Name);
        }

        public void Load(int slot)
        {
            Name = PlayerPrefs.GetString($"saveslot_{slot}_{nameKey}");
        }
    }
}