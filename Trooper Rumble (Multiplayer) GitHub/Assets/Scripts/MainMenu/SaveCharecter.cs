using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SaveCharecter : MonoBehaviour
{
    public Transform holder;
    public Button selectBtn;
    //int selector;
    // Start is called before the first frame update
    void Start()
    {
       // selector = PlayerPrefs.GetInt("Select");
       // holder.GetChild(selector).gameObject.active = true;
    }

    // Update is called once per frame
   
    public void ChooseChar()
    {
        if (holder.GetChild(0).gameObject.active == true)
        {
            PlayerPrefs.SetInt("Select", 0);
            Debug.Log("0");
        }
        if (holder.GetChild(1).gameObject.active == true)
        {
            PlayerPrefs.SetInt("Select", 1);
            Debug.Log("1");
        }
        if (holder.GetChild(2).gameObject.active == true)
        {
            PlayerPrefs.SetInt("Select", 2);
            Debug.Log("2");
        }
         if (holder.GetChild(3).gameObject.active == true)
        {
            PlayerPrefs.SetInt("Select", 3);
            Debug.Log("3");
        }
         if (holder.GetChild(4).gameObject.active == true)
        {
            PlayerPrefs.SetInt("Select", 4);
            Debug.Log("4");
        }
         if (holder.GetChild(5).gameObject.active == true)
        {
            PlayerPrefs.SetInt("Select", 5);
            Debug.Log("5");
        }


    }
}
