using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunEnemy1 : MonoBehaviour
{
    public int enemyHealth;
    public float speed;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.velocity = -Vector3.forward * speed;
    }

}
