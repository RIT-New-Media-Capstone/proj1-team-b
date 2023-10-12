using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class DrawManager : MonoBehaviourPunCallbacks, IPunObservable
{
    public GameObject circlePrefab;

    [SerializeField]
    List<GameObject> drawnCircles = new List<GameObject>();

    [SerializeField]
    List<GameObject> otherPlayerCircles = new List<GameObject>();

    [SerializeField]
    private Vector2 mousePosition;

    PhotonView view;

    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if (view.IsMine)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButton(0)) // Start Drawing
        {
            // add a new dot to the drawn list
            drawnCircles.Add(Instantiate(circlePrefab, mousePosition, Quaternion.identity));
        }
        }
        
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            stream.SendNext(drawnCircles);
        } else if (stream.IsReading)
        {
            otherPlayerCircles = (List<GameObject>)stream.ReceiveNext();
        }
    }
}
