using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBasicSript : MonoBehaviour
{
    public float health = 5;
    public float time = 0;
    public float point;
    public GameObject explosion;


    public void takeDamage(float damageAmount)
    {
        health -= damageAmount;
        if (health <= 0)
        {
            death();
        }
        else
        {
            shakeEffect();
        }
    }
    public void shakeEffect()
    {
        var meshObjce1 = transform.GetChild(0);
        meshObjce1.transform.DOShakePosition(1, 1, 10, 90, false, true);
    }

    public void death()
    {
        
        Instantiate(explosion, transform.position , transform.rotation);
        PlayerData.score += point;
        Destroy(this.gameObject, time);
    }

}
