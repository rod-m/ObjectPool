using System.Collections;
using System.Collections.Generic;
using SuperTools;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class ParticleSpawn : MonoBehaviour, IPoolAwake
{
    private Rigidbody rb;
    public ParticleSpawnSetting particleSpawnSetting;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    

    public void PoolAwake(Vector3 _pos, Quaternion _rot)
    {
        float xForce = Random.Range(-particleSpawnSetting.sideForce, particleSpawnSetting.sideForce);
        float yForce = Random.Range(particleSpawnSetting.upForce / 2, particleSpawnSetting.upForce);
        float zForce = Random.Range(-particleSpawnSetting.sideForce, particleSpawnSetting.sideForce);
        gameObject.SetActive(true);
        transform.position = _pos;
        transform.rotation = _rot;
        rb.velocity = new Vector3(xForce, yForce, zForce);
    }
}
