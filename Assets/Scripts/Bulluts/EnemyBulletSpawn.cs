using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletSpawn : MonoBehaviour
{
    public GameObject bullet;
    public float spawnTime;
    private bool canAttack = true;
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
        Instantiate(bullet, gameObject.transform.position, gameObject.transform.rotation);
    }
}
