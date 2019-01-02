using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSquare : MonoBehaviour
{

    public bool TeraminoOnMe;

    public Sprite spritevoid;
    public Sprite spriteP1;
    public Sprite spriteP2;
    public bool AllTetrasOnGrid;

    public int GridX;
    public int GridY;
    public int TileType;

    Collider2D ThisObjectColl;
    Collider2D TetraColl;
    Collider2D TetColl;

    GameObject ThisObject;
    GameObject[] Tetras;
    GameObject Tetra;
    GameObject[] Tets;
    GameObject Tet;
    GameObject[] TowerSquares;

    bool Killed;
    bool EatenTetra;

    SpriteRenderer SpriteRenderer;
    // Use this for initialization

    void Start()
    {
        TileType = 0;
        SpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        ThisObjectColl = gameObject.GetComponent<Collider2D>();
        EatenTetra = false;
        TeraminoOnMe = false;
    }
}
    // Update is called once per frame
   
      

