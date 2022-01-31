using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class SpawnPlayer : MonoBehaviourPunCallbacks
{
    //public GameObject playerPrefab;  //to make a new prefab
    public static SpawnPlayer Instance;
    public GameObject localPlayer;
    // public Text respawnTimerText;
    // public  float timerAmount = 5f;
    // private bool RunSpawnTimer = false;
    public GameObject respawnMenu;
    public bool runSpawnTimer = false;


    public GameObject playerPrefab;

    public GameObject canvas;
    public GameObject sceneCamera;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 randomPos = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));  //instantiate on a random location  
        PhotonNetwork.Instantiate(playerPrefab.name, randomPos, Quaternion.identity);// Quaternion.identity ---> no rotation // sounds good, doesn't work
        playerPrefab.SetActive(true);
        Instance = this;
    }


    // public void startRespawn(){

    //    timerAmount -= Time.deltaTime;
    //    respawnTimerText.text = "Respawning in..." + timerAmount.ToString("F0");
    //    if(timerAmount <= 0){   
    //         localPlayer.GetComponent<PhotonView>().RPC("respawn", RpcTarget.All);
    //         localPlayer.GetComponent<Health>().enableInput();
    //         respawnMenu.SetActive(false);
    //        runSpawnTimer = false;
    //    }
    // }
    // public void enableRespawn(){

    //     timerAmount = 5f;
    //     runSpawnTimer = true; 
    //     respawnMenu.SetActive(true);
    // }

    // Update is called once per frame
    void Update()
    {
        // if(runSpawnTimer){
        //     startRespawn();
        // }
        // playerPrefab.SetActive(true);
    }
}
