using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingObj : MonoBehaviour
{
    public float timeToReset = 5f;

    public void StartObj()
    {
        Invoke(nameof(FinishUsage), timeToReset);
    }

    private void FinishUsage()
    {
        gameObject.SetActive(false);
    }

}
