using System.Collections.Generic;
using UnityEngine;

namespace SuperTools
{
    public class ObjectPoolTool : MonoBehaviour
    {
        // A public list to allow the queues to by configured
        public List<PoolInfo> poolList;

        // A private dictionary to store the queued objects in tagged queues
        private Dictionary<string, Queue<PoolItem>> poolDictionary;


        public void Start()
        {
            poolDictionary = new Dictionary<string, Queue<PoolItem>>();
            foreach (var _pool in poolList)
            {
                Queue<PoolItem> objectPool = new Queue<PoolItem>();
                for (int i = 0; i < _pool.size; i++)
                {
                    GameObject obj = Instantiate(_pool.prefab);
                    obj.transform.parent = transform;
                    PoolItem poolItem = new PoolItem(obj);
                    objectPool.Enqueue(poolItem);
                    
                }
                poolDictionary.Add(_pool.tag, objectPool);
            }
        }

        public PoolItem SpawnFromPool(string _tag, Vector3 _pos, Quaternion _rot)
        {
            if (!poolDictionary.ContainsKey(_tag))
            {
                Debug.LogWarning($"Cant find this {_tag}");
                return null;
            }

            PoolItem _poolItem = poolDictionary[_tag].Dequeue();
            _poolItem.ReSpawn(_pos, _rot);
            poolDictionary[_tag].Enqueue(_poolItem); // add him back to the end of the line
            return _poolItem;
        }
        
    }
}