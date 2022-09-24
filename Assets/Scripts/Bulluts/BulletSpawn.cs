using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject bullet;
    public float spawnTime;
    private bool canAttack = true;
    public AudioSource au;

    // Start is called before the first frame update

    public void FixedUpdate()
    {
        while (canAttack)
        {
            StartCoroutine(attackTimer());
        }
    }
    public IEnumerator attackTimer()
    {
        
        canAttack = false;
        yield return new WaitForSeconds(spawnTime);
        canAttack = true;
        Instantiate(bullet, gameObject.transform.position,new Quaternion(gameObject.transform.rotation.x +90f , gameObject.transform.rotation.y, gameObject.transform.rotation.z,90));
        au.Play();
        
    }
}
