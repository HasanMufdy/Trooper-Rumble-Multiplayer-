using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class saveName : MonoBehaviour
{
    public InputField TextBox;

    public void ClickSaveButton()
    {
        // UnityEngine.PlayerPrefs.SetString("name", TextBox.text);
        // Debug.Log("your name is ?" + PlayerPrefs.GetString("name"));
        //ConnectUsingName.nameInput = TextBox; // photon name
    }
}