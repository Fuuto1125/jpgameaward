using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    private Vector3 firepos;

    void Start()
    {
        firepos = transform.position;
    }


    void Update()
    {
        transform.position = new Vector3(firepos.x, Mathf.Sin(Time.time) * 0.8f + firepos.y, firepos.z);
    }
}