using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Weapon : MonoBehaviour
{
    public PhotonView bulletView;
    public Transform shootingPoint;
    
    //public SpriteRenderer shootingPointsr; 

    public GameObject bulletPrefab;
    public bool disableShooting;

    void Start(){
        bulletView = GetComponent<PhotonView>();
    }
    
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && bulletView.IsMine && !disableShooting){
            shoot();

        }
        
    }
    public void shoot(){
        PhotonNetwork.Instantiate(bulletPrefab.name,shootingPoint.position,shootingPoint.rotation);
        //Instantiate(bulletPrefab,shootingPoint.position,shootingPoint.rotation);
       // print("shooting...");
    }
}
