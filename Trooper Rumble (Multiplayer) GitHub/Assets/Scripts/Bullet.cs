using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class Bullet : MonoBehaviourPunCallbacks
{
    public float bulletSpeed =10f;
    
    //public bool movDirection = true;  // true --> right
    public float timeToLive;
    public float bulletDamage;
    // public Text scoreText;
    // public int score;
    
    public Rigidbody2D bulletBody;
    public int damage = 30;
    public int health;
    //public GameObject myObject;

    // Start is called before the first frame update
    void Start()
    {

        // if(Movements.isFacingRight == true){                         //// not necessary //// ????
        //     bulletBody.velocity = transform.right * bulletSpeed;
        // }
        // else if(Movements.isFacingRight == false){
        //     bulletBody.velocity = -transform.right * bulletSpeed;
        // }
        bulletBody.velocity = transform.right * bulletSpeed;
      
        Destroy(gameObject, 5);    // THIS IS THE ONLY THING WE NEED TO DESTROY THE BULLET AUTOMATICALLY AFTER 5 SECONDS //
    }



    // public void changeDirection(){    //// also not necessary //// ????? 
    //     movDirection = false;
    // }



    void OnTriggerEnter2D(Collider2D hitInfo){
        print(hitInfo.name);
        Destroy(gameObject); // gameObject ---> Bullet
       // damage
        if(!photonView.IsMine){
            return;
        }
        PhotonView target = hitInfo.gameObject.GetComponent<PhotonView>();
        if(target != null && (!target.IsMine)){
            if(target.tag == "Player"){
                target.RPC("reduceHealth",RpcTarget.All,bulletDamage);
                ///////////////////////////////////////////////////////// increasing the score

        //     if(!photonView.IsMine){
        //     score = score + 1;
        // }
                



            }
            //this.GetComponent<PhotonView>().RPC("destroyBullet",RpcTarget.All);
        }

            
             // //if(health<=0){
             //     // Destroy(gameObject); // don't do this!! anyway, Unity wont let you destroy the prefab, we want to destroy the clone (instantiated prefab)
             //     Destroy(hitInfo);  //***********************************
 
            // //}
    }
}










