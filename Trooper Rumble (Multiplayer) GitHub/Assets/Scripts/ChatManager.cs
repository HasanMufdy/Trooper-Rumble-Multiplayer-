// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using Photon.Pun;
// using UnityEngine.UI;

// public class ChatManager : MonoBehaviourPunCallbacks ,IPunObservable
// {
//     public Movements plMove;
//     public PhotonView chatView;
//     public GameObject bubbleSpeechInput;
//     public Text updatedText;
//     public InputField chatInputField;
//     public bool disableSend;
//     // Start is called before the first frame update
//     void Start()
//     {
//         chatInputField = GameObject.Find("chatInputField").GetComponent<InputField>();
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if(chatView.IsMine){
//             if(!disableSend && chatInputField.isFocused){
//                 if(chatInputField.text !="" && chatInputField.text.Length >=0 && Input.GetKeyDown(KeyCode.Slash)){
//                     chatView.RPC("sendMessage", RpcTarget.All,chatInputField.text);
//                     bubbleSpeechInput.SetActive(true);

//                     chatInputField.text = "";
//                     disableSend = true;
//                 }
//             }
//         }
//     }




//     public void sendMessage(string message){
//         updatedText.text = message;
//         StartCoroutine("Remove");
//     }

//     IEnumerator Remove(){
//         yield return new WaitForSeconds(4f);
//         bubbleSpeechInput.SetActive(false);
//         disableSend = false;
//     }

//     public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info){

//         if(stream.IsWriting){
//             stream.SendNext(bubbleSpeechInput.active);
//         }
//         else if(stream.IsReading){
//             bubbleSpeechInput.SetActive((bool)stream.ReceiveNext());
//         }
//     }










// }
