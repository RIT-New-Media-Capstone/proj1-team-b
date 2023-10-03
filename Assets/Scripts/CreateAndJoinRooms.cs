using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{

    public InputField createInput;
    public InputField joinInput;

    public void CreateAndJoinRoom()
    {
        PhotonNetwork.CreateRoom("private_room");
        PhotonNetwork.JoinRoom("private_room");
    }

    public override void OnJoinedRoom()
    {
        //add whatever name of scene is the actual game/multiplayer scene
        PhotonNetwork.LoadLevel("MainGameScene");
    }
}
