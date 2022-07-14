using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject sphere;
    public Transform spawnPoint;

    public PoolManager poolManager; 

    private void SpawnObject()
    {
        var obj = poolManager.GetPoolList();
        obj.SetActive(true);
        obj.GetComponent<RepeatingObj>().StartObj();
        obj.transform.position = spawnPoint.transform.position;
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            SpawnObject();
        }
    }
}
