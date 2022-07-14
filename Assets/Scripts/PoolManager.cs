using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{

    public GameObject prefab;
    public List<GameObject> poolList;

    public int amount = 20;

    public void Awake()
    {
        StartPool();
    }

    private void StartPool()
    {
        poolList = new List<GameObject>();
        for(int i = 0; i < amount; i++)
        {
            var obj = Instantiate(prefab, transform);
            obj.SetActive(false);
            poolList.Add(obj);
        }
    }

    public GameObject GetPoolList()
    {
        for (int i = 0; i < amount; i++)
        {
            if (!poolList[i].activeInHierarchy)
            {
                return poolList[i];
            }
        }
        return null;
    }


}
