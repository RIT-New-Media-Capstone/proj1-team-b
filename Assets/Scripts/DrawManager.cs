using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawManager : MonoBehaviour
{
    public GameObject circlePrefab;

    [SerializeField]
    List<GameObject> drawnCircles = new List<GameObject>();

    [SerializeField]
    private Vector2 mousePosition;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButton(0)) // Start Drawing
        {
            // add a new dot to the drawn list
            drawnCircles.Add(Instantiate(circlePrefab, mousePosition, Quaternion.identity));
        }
    }
}
