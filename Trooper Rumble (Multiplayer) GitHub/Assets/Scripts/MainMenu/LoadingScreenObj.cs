using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LoadingScreenObj : MonoBehaviour
{
    public GameObject LoadingScreen;
    public Slider slider;

    
    public void LoadLevel( int sceneIndex)
    {
        StartCoroutine(LoadAsynchrronoisly( sceneIndex));
    }
    IEnumerator LoadAsynchrronoisly(int SceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneIndex);
        LoadingScreen.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            yield return null;
        }
            
        }

    }
