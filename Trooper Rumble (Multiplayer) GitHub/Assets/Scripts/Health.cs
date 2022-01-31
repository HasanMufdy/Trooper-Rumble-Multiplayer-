using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;


public class Health : MonoBehaviourPunCallbacks
{
    public Vector3 position;
    public Image fillImage;
    public float healthAmount;

    public Movements plMove;  // class Movements
    public GameObject playerCanvas;
    public Rigidbody2D rb;
    public BoxCollider2D bc;
    public SpriteRenderer sr;
    public bool disableMoves;
                            
    public void checkHealth(){

        fillImage.fillAmount = healthAmount/100f;
        if(photonView.IsMine && healthAmount<=0){
           // SpawnPlayer.Instance.enableRespawn();
           // plMove.disableInput = true;             // this is the instace that was created above, will modify disableInput value from Movements class

            this.GetComponent<PhotonView>().RPC("respawn",RpcTarget.All);
        }
        if(!photonView.IsMine && healthAmount<=0){
        ScoreManager.score = ScoreManager.score + 1;          ////////// increase the score, ScoreManager ... score (static) 
        }
   
   
        
    }

    // public void enableInput(){   // enable player movements and inputs, we will call it from SpawnPlayer class
    //     plMove.disableInput = false;
    // }
    // [PunRPC]
    //     public void dead(){
    //     rb.gravityScale = 0;
    //     bc.enabled = false;
    //     sr.enabled = false;
    //     playerCanvas.SetActive(false);

    // }
    [PunRPC]
    public void respawn(){
        //rb.gravityScale = 1;
       // bc.enabled = true;
      //  sr.enabled = true;
     //   playerCanvas.SetActive(true);
        fillImage.fillAmount = 1f;
        healthAmount = 100f; 
        changePosition();
    }
    public void changePosition(){  
        gameObject.transform.position = new Vector3(0,0,0);
        //Movements.isFacingRight = true;
    }


    void Start()
    {
        SpawnPlayer.Instance.localPlayer = this.gameObject;
    }

    [PunRPC]
    public void reduceHealth(float amount){
        modifyHealth(amount);
    }
    public void modifyHealth(float amount){
        if(photonView.IsMine){
            healthAmount-=amount;
            fillImage.fillAmount -= amount;
        }   
        else{
            healthAmount-=amount;
            fillImage.fillAmount -= amount;
        }  
        checkHealth(); //////////////////////////////////////////////////////////////////////////   
    }
 
    // to respawn after falling
      public void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Reset")){
            this.GetComponent<PhotonView>().RPC("respawn",RpcTarget.All);
        }

    }

    void Update()
    {
    }
}
  

