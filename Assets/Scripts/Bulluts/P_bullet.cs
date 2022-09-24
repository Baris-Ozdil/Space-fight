using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_bullet : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    private float gunPower = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = gameObject.transform.TransformDirection(0, speed, 0);
    }

    public IEnumerator deadWait()
    {
        yield return new WaitForSeconds(4);
        Destroy(this.gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.LogWarning("deydiði : " + other.name);
        if (other.gameObject.tag == "destroyer")
        {
            return;
        }
        else
        {
            var s1 = other.gameObject.GetComponent<EnemyBasicSript>();
            
            s1.takeDamage(gunPower);
            //exposion effect
            Destroy(this.gameObject);
        }
        
    }

}
