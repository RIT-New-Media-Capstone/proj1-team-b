using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using UnityEngine.SceneManagement;
using TMPro;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{

    public Button startNew;
    public Button joinCurrent;
    public TMP_InputField newRoomName;
    public TMP_InputField joinRoomName;

    //public void Awake()
    //{
    //    SceneManager.LoadScene("Lobby");
    //    Debug.Log("Scene Loaded.");
    //}
    public void Start()
    {
        //newRoomName = GameObject.Find("newRoomName").GetComponent<InputField>();
        //joinRoomName = GameObject.Find("joinRoomName").GetComponent<InputField>();
        Debug.Log(newRoomName, joinRoomName);
    }

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(newRoomName.text);
        Debug.Log("newRoomName: " + newRoomName.text);
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinRoomName.text);
        Debug.Log("joinRoomName: " + joinRoomName.text);
    }

    public override void OnJoinedRoom()
    {
        //add whatever name of scene is the actual game/multiplayer scene
        PhotonNetwork.LoadLevel("SampleScene");
    }
}
