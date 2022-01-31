using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicPlay : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource AudioSource;
    public float MusicVolume = 1f;
    public void Start()
    {
        AudioSource.Play();
    }

    // Update is called once per frame
    public void Update()
    {
     
    }
}
