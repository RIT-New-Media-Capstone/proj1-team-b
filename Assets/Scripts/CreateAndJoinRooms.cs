using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using UnityEngine.SceneManagement;


public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{

    public Button startNew;
    public Button joinCurrent;
    public InputField newRoomName;
    public InputField joinRoomName;

    //public void Awake()
    //{
    //    SceneManager.LoadScene("Lobby");
    //    Debug.Log("Scene Loaded.");
    //}

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom("private_room");
        Debug.Log("room created");
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom("private_room");
        Debug.Log("room joined");
    }

    public override void OnJoinedRoom()
    {
        //add whatever name of scene is the actual game/multiplayer scene
        PhotonNetwork.LoadLevel("SampleScene");
    }
}
