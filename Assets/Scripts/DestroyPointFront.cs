using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPointFront : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "gun" || other.tag == "rocket")
        {
            Debug.Log(other.gameObject.name+" touched");
            Destroy(other.gameObject);
        }
    }
}
