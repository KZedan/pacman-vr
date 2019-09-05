using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    { 
        Destroy(this.gameObject);
        SumScore.Add(10);
    }
}

