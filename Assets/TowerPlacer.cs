using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlacer : MonoBehaviour {

    public int GridX = -1;
    public int GridY = -1;
    Collider2D TowerColl;
    Collider2D TowerPlaceColl;
    GameObject[] TowerPlaceList;
    // Use this for initialization
    void Start () {
		TowerPlaceList = GameObject.FindGameObjectsWithTag("TowerSpot");
        TowerColl = gameObject.GetComponent<Collider2D>();
    }
	
	// Update is called once per frame
	void Update () {
		
       //foreach(GameObject Towerplace in TowerPlaceList)
       // {
       //     TowerPlaceColl = Towerplace.GetComponent<Collider2D>();

       //     if (TowerColl.bounds.Intersects(TowerPlaceColl.bounds))
       //     {
       //         GridX = Towerplace.GetComponent<TowerSquare>().GridX;
       //         GridY = Towerplace.GetComponent<TowerSquare>().GridY;

       //     }
       // }

	}
}
