using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = gameObject.transform.TransformDirection(0, 0, speed);
        StartCoroutine(deadWait());
    }

    public IEnumerator deadWait()
    {
        yield return new WaitForSeconds(4);
        Destroy(this.gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "destroyer")
        {
            return;
        }
        var s1 = other.gameObject.GetComponentInParent<PlayerData>();
        s1.takeDamage();
        //exposion effect
        Destroy(this.gameObject);
    }
}
