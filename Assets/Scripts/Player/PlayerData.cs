using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class PlayerData : MonoBehaviour
{
    public static float score = 0;
    public bool infoBool = true;
    private int playerHealth = 3;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        //Cursor.visible = false;
    }
    private void FixedUpdate()
    {
        //die when hp is 0
        StartCoroutine(info());
    }
    public void takeDamage()
    {
        playerHealth -= 1;
        if(playerHealth <= 0)
        {
            playerDeath();
            return;
        }

        shake();
    }

    private void shake()
    {
        var meshObjce1 = transform.GetChild(0);
        meshObjce1.transform.DOShakePosition(1,1,10,90,false,true);
    }
    public void playerDeath()
    {

        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(this.gameObject);
        //screan change after pass time

    }
    public IEnumerator info()
    {
        infoBool = false;
        yield return new WaitForSeconds(10);
        infoBool = true;
        Debug.Log("Current Score: " + score);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            other.GetComponent<EnemyBasicSript>().death();
            takeDamage();
        }
    }


}

