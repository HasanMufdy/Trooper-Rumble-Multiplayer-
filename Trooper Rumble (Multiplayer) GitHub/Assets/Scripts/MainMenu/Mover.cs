using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Mover : MonoBehaviour
{
    public void LoadScreen(int lvl)
    {
        SceneManager.LoadScene(lvl);















    }


    public void playAsAGuest(){
        SceneManager.LoadScene("Loading");
    }
}
