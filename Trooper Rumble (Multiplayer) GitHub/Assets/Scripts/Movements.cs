using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;


public class Movements : MonoBehaviour
{
    public Text playerNameTest;
    public Transform playerNameTestPosition;
    public Text playerName;

    public Text playerNameTextScene;
    public GameObject playerCamera;
//////
    public float UIMov; // can be left or right (1/-1)

    public Transform playerPosition;
    public Vector3 lastPosition;
    public SpriteRenderer sr;
    public SpriteRenderer shootingPointsr; 
    public float movementX;
//////
    public float moveSpeed = 10f;
    public float jumpSpeed = 11f;
//////
   
//////
    public Rigidbody2D body;
    public Collider2D coll;
//////
    public static bool isFacingRight = true;  
    //public static bool toRight;   
    public bool isOnGround = true; //to prevent him from jumping from air
    public bool disableInput = false;     // will be changed by Health class
//////
    public PhotonView view;

// Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>(); 
        lastPosition = transform.position;
        // playerPosition = GetComponent<Transform>();
        // isFacingRight = toRight;
        // sr = GetComponent<SpriteRenderer>();
        // if(view.IsMine){
        //    // playerCamera.SetActive(true);
        //     //playerName.text = PhotonNetwork.NickName;
        //    //// playerName.text = CreateOrJoin.createIn.text;
        // }
        // else{
        //     playerName.text = view.Owner.NickName;

        // }
    }
    void Awake(){               // this method is for the name only.
       /////////////////// view.RPC("setNames",RpcTarget.All);
        if(view.IsMine){
            playerNameTextScene.text = PhotonNetwork.NickName;
        }
        else{
            playerNameTextScene.text = view.Owner.NickName;

        }
        //view = GetComponent<PhotonView>();
        //body = GetComponent<Rigidbody2D>();
        //coll = GetComponent<BoxCollider2D>();
        //view = GetComponent<PhotonView>();        
    }
    //////////////////// sync player names:
    // [PunRPC]
    // public void setNames(){

    //       if(view.IsMine){
    //         playerNameTextScene.text = PhotonNetwork.NickName;
    //     }
    // }

    // Update is called once per frame
    void Update()
    {
        if(view.IsMine){    // && !disableInput
        playerMovements();
        playerJump(); 
        }
        //toRight = isFacingRight;
        // playerPosition = playerNameTestPosition; 
        //  Vector3 difference = transform.position - lastPosition;
        //  playerNameTestPosition.Translate( difference );
        //  lastPosition = transform.position;
        // Vector3 playerPos = playerPosition;
        

        
    }

    public void playerJump(){
        if(Input.GetButtonDown("Jump") && isOnGround ){
            isOnGround = false;
            body.AddForce(new Vector2(0f, jumpSpeed) , ForceMode2D.Impulse);

        }
    }



    public void playerMovements(){
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position = transform.position + new Vector3(movementX, 0f, 0f) * moveSpeed * Time.deltaTime;
        // UI Buttons
        transform.position = transform.position + new Vector3(UIMov, 0f, 0f) * moveSpeed * Time.deltaTime;
        // flip
        if(movementX<0 && isFacingRight){
            view.RPC("flipRight",RpcTarget.All);
            //flip();
        }
        else if(movementX>0 && !isFacingRight){
            view.RPC("flipLeft",RpcTarget.All);
        }

    }
    // public void shootingPointFlip(){
    //     if(movementX<0){

    //     }
    // }

    [PunRPC]
    public void flipRight(){
        isFacingRight = false;
        //sr.transform.Rotate(0,180,0);
        //playerNameSr.Rotate(0,180,0);
        sr.flipX = true;
        shootingPointsr.transform.Rotate(0,180,0);  // bullet direction
    }
    [PunRPC]
    void flipLeft(){
        isFacingRight = true;
        //sr.transform.Rotate(0,180,0);
        //playerNameSr.Rotate(0,180,0);
        sr.flipX = false;
        shootingPointsr.transform.Rotate(0,180,0);  // bullet direction
 

    }

    public void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Ground")){
            isOnGround = true;

        }

    }


     public void ButtonJump(){
        if(isOnGround){
        isOnGround = false;
        body.AddForce(new Vector2(0f, jumpSpeed) , ForceMode2D.Impulse);
        }
    }


////// moving the player with UI buttons
   public void movRight(){
        UIMov = 1;

    }

    public void movLeft(){
        UIMov = -1;
        
    }

    
    public void stopUImov(){
        UIMov = 0;
    }

    public void printSomething(){
        print("something");

    }







}//class
