using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winLose : MonoBehaviour
{
    bool isEnd = false;
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null && !isEnd)
        {
            StartCoroutine(waitdie());
        }
        else if (GameObject.FindGameObjectWithTag("Enemy") == null && !isEnd)
        {
            StartCoroutine(waitwin());
        }
    }
    IEnumerator waitdie()
    {
        isEnd = true;
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(2);
    }
    IEnumerator waitwin()
    {
        isEnd = true;
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
}
