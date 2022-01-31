using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AddFriend : MonoBehaviour
{
    public GameObject Menu;
    public GameObject panel;
    public void Show ()
    {
        panel.SetActive(true);
        Menu.SetActive(false);
    }
    public void Hide()
    {
        panel.SetActive(false);
        Menu.SetActive(true);
    }

}
