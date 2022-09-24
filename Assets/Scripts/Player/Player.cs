using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // add movement joistic finder


    public Joistic joistic;
    public float speed;
    private Rigidbody rb;
    private Vector3 lookPos;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if ((this.gameObject.transform.position.z >= 13 && joistic.joysticVec.y > 0 && (this.gameObject.transform.position.x >= 33.5 && joistic.joysticVec.x > 0 || this.gameObject.transform.position.x <= -33.5 && joistic.joysticVec.x < 0)) || (this.gameObject.transform.position.z <= -57 && joistic.joysticVec.y < 0 && (this.gameObject.transform.position.x >= 33.5 && joistic.joysticVec.x > 0 || this.gameObject.transform.position.x <= -33.5 && joistic.joysticVec.x < 0)))
        {
            rb.velocity = new Vector3(0, 0,0);
        }
        else if (this.gameObject.transform.position.z >= 13 && joistic.joysticVec.y > 0 || this.gameObject.transform.position.z <= -57 && joistic.joysticVec.y < 0)
        {
            rb.velocity = new Vector3(joistic.joysticVec.x * speed,0, 0);
        }
        else if (this.gameObject.transform.position.x >= 33.5 && joistic.joysticVec.x > 0 || this.gameObject.transform.position.x <= -33.5 && joistic.joysticVec.x < 0)
        {
            rb.velocity = new Vector3(0,0, joistic.joysticVec.y * speed);
        }
        else if (joistic.joysticVec != Vector2.zero)
        {
            rb.velocity = new Vector3(joistic.joysticVec.x * speed,0, joistic.joysticVec.y * speed);
        }
        else
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
