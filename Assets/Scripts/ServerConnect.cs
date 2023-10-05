using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class ServerConnect : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    public void Start()
    {
        //SceneManager.LoadScene("ConnectServer");
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("ConnectUsingSettings");


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
        Debug.Log("lobby joined");

    }

    public override void OnJoinedLobby()
    {
        SceneManager.LoadScene("Lobby");
    }
}
