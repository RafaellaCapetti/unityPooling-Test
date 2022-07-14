using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMovement : MonoBehaviour
{

    public float speed = 2.5f;

    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * speed, 2), transform.position.y, transform.position.z);
    }
}
