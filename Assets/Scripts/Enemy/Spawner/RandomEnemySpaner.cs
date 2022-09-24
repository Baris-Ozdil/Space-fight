using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemySpaner : MonoBehaviour
{
    public GameObject basicEnemy;
    public float basiEnemyTime;
    public bool basicEnemyBool;
    void FixedUpdate()
    {
        while (basicEnemyBool)
        {
            StartCoroutine(basicEnemyTimer());
        }
    }

    IEnumerator basicEnemyTimer()
    {
        basicEnemyBool = false;
        enemySpawn(basicEnemy);
        yield return new WaitForSeconds(basiEnemyTime);
        basicEnemyBool = true;
    }

    public void enemySpawn(GameObject enemy)
    {
        Vector3 sapma = new Vector3(Random.Range(-32f, 32f), 0, 0);
        Instantiate(enemy, transform.position + sapma, transform.rotation);
    }
}
