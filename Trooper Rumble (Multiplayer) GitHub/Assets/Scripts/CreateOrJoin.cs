using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
public class CreateOrJoin : MonoBehaviourPunCallbacks
{
    public InputField createIn;
    public InputField joinIn;
    public void CreateRoom(){

        PhotonNetwork.CreateRoom(createIn.text);
    }
    public void JoinRoom(){

        PhotonNetwork.JoinRoom(joinIn.text);
    }

     
    public override void OnJoinedRoom(){
        PhotonNetwork.LoadLevel("Game");


    }



}
