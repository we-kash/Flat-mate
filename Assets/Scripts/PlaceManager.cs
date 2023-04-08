using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceManager : MonoBehaviour
{
    private Placeindicartor placeindi;
    public GameObject ObjToPlace;
    private GameObject newPlacedObj;
    // Start is called before the first frame update
    void Start()
    {
        placeindi = FindObjectOfType<Placeindicartor>();

    }
    public void ClicktoPlace()
    {
        newPlacedObj = Instantiate(ObjToPlace, placeindi.transform.position, placeindi.transform.rotation);
    }

}
