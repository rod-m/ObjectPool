using System.Collections;
using System.Collections.Generic;
using SuperTools;
using UnityEngine;

[RequireComponent(typeof(ObjectPoolTool))]
public class ParticleSpawner : MonoBehaviour
{
    private ObjectPoolTool _objectPool;
  
    void Start()
    {
        _objectPool = GetComponent<ObjectPoolTool>();
    }

    // Update is called once per frame
    void Update()
    {
        PoolItem _poolItem = _objectPool.SpawnFromPool("Cube", transform.position, transform.rotation);
    }
}
