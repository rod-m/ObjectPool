
using System.Runtime.CompilerServices;
using UnityEngine;
namespace SuperTools
{
    public class PoolItem
    {
        private IPoolAwake _poolAwake;
        public GameObject prefab;

        public PoolItem(GameObject o)
        {
            prefab = o;
            _poolAwake = o.GetComponent<IPoolAwake>();
            prefab.SetActive(false);
        }
        public void ReSpawn(Vector3 _position, Quaternion _rotation)
        {
            prefab.SetActive(true);
            if (_poolAwake != null)
            {
                _poolAwake.PoolAwake(_position, _rotation);
            }
        }
    }
}