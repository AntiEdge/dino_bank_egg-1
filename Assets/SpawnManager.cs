using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager Instance;

    [SerializeField] private GameObject prefab;
    [SerializeField] private GameObject spawnPoint;
    
    private void Awake()
    {
        Instance = this;
    }
    

    public void SpawnDino()
    {
        var x = Random.Range(-.1f,.1f);
        var y = Random.Range(-.1f,.1f);
        var z = Random.Range(-.1f,.1f);
        
        Instantiate(prefab, spawnPoint.transform.position + new Vector3(x, y, z), spawnPoint.transform.rotation);
    }
}
