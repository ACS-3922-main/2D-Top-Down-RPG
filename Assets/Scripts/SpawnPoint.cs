using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private GameObject _prefabToSpawn;
    [SerializeField] private float _repeatInterval;
    [SerializeField] private float _enemyCount;

    public void Start() {
        
        if (_repeatInterval > 0) {
            InvokeRepeating("SpawnObject", 0.0f, _repeatInterval);
        }
    }

    public GameObject SpawnObject() {
        _enemyCount++;
        if (_prefabToSpawn != null && _enemyCount<6) {
            return Instantiate(_prefabToSpawn, transform.
            position, Quaternion.identity);
        }
        return null;
    }
}
