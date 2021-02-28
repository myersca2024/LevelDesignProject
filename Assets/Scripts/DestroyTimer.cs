using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour
{
    public float time = 2f;

    void Start()
    {
        Destroy(gameObject, time);
    }
}
