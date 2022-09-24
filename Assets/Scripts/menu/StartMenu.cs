using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public Button play;
    
    public void playButton ()
    {
        int i = Random.Range(3, 6);
        SceneManager.LoadScene(i);
    }

}
