using UnityEngine;

namespace SuperTools
{
    [CreateAssetMenu(fileName = "SpawnSetting", menuName = "Spawn Setting", order = 0)]
    public class ParticleSpawnSetting : ScriptableObject
    {
        public float upForce = 1f;
        public float sideForce = .2f;
    }
}