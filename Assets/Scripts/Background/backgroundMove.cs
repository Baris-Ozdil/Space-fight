using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMove : MonoBehaviour
{
    public float speed;
    public float topPoint;
    
    private void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed);
        if (transform.position.z <= -200)
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, topPoint);
        }
    }
    
}
