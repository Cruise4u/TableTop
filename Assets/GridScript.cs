using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridScript : MonoBehaviour
{
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
    Collider2D TowerColl;

    GameObject ThisObject;
    GameObject[] Tetras;
    GameObject Tetra;
    GameObject[] Tets;
    GameObject Tet;
    GameObject[] TowerSquares;
    GameObject TowerSquare;
    GameObject TurnOb;
    int Turn;
    bool Killed;
    bool EatenTetra;
    bool TowerCollision;
    bool TowerCollision2;
    bool builded;
    GameObject BuildCounter;

    SpriteRenderer SpriteRenderer;
    // Use this for initialization

    void Start()
    {
        TileType = 0;
        SpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        ThisObjectColl = gameObject.GetComponent<Collider2D>();
        EatenTetra = false;
        TurnOb = GameObject.Find("EndTurn");
    }

    // Update is called once per frame
    void Update()
    {
        if (TurnOb.GetComponent<ChangeSprite>().Turn == 1)
        {
            BuildCounter = GameObject.Find("BuildCounter");
        }
        else
        {
            BuildCounter = GameObject.Find("BuildCounterP2");
        }
        Turn = TurnOb.GetComponent<ChangeSprite>().Turn;
        builded = TurnOb.GetComponent<ChangeSprite>().Builded;

        Tets = GameObject.FindGameObjectsWithTag("Tet");
        Tetras = GameObject.FindGameObjectsWithTag("ChildTet");

        //for (int i = 0; i < Tets.Length; i++)
        //{
        //    Tet = Tets[i];


        //        TetColl = Tet.GetComponent<Collider2D>();


        //            TowerSquares = GameObject.FindGameObjectsWithTag("TowerSpot");
        //    for (int i2 = 0; i2 < TowerSquares.Length; i2++)
        //    {
        //        TowerSquare = TowerSquares[i2];
        //        TowerColl = TowerSquare.GetComponent<Collider2D>();
        //        if (TetColl.bounds.Intersects(TowerColl.bounds))
        //        {
        //            TowerCollision = true;

        //        }
        //        else
        //        {
        //            TowerCollision = false;
        //        }
        //    }


        //}


        //for (int i = 0; i < Tetras.Length; i++)
        //{

        //    Tetra = Tetras[i];




        //            TowerSquares = GameObject.FindGameObjectsWithTag("TowerSpot");
        //            for (int i2 = 0; i2 < TowerSquares.Length; i2++)
        //            {
        //                TowerSquare = TowerSquares[i2];
        //                TowerColl = TowerSquare.GetComponent<Collider2D>();
        //            }
        //            if (TetraColl.bounds.Intersects(TowerColl.bounds))
        //    {
        //        TowerCollision = true;

        //    }
        //    else
        //    {
        //        TowerCollision = false;
        //        }



        //}
        if (TowerCollision == true)
        {
            for (int i = 0; i < Tetras.Length; i++)
            {
                Tetra = Tetras[i];
                Tetra.GetComponent<MouseScript>().SendBack();
            }

            for (int i = 0; i < Tets.Length; i++)
            {
                Tet = Tets[i];
                Tet.GetComponent<MouseScript>().SendBack();
            }

        }
        if (builded == false && BuildCounter.GetComponent<CounterScript>().counterValue >= 3)
        {
            
            if (TowerCollision == false && TowerCollision2 == false && Turn == 1)
            {
                
                if (EatenTetra == false)
                {


                    for (int i = 0; i < Tetras.Length; i++)
                    {

                        Tetra = Tetras[i];
                        Killed = Tetra.GetComponent<TileSnapper>().KILLME;
                        if (Killed == false)
                        {
                            TetraColl = Tetra.GetComponent<Collider2D>();

                            if (ThisObjectColl.bounds.Intersects(TetraColl.bounds) && Input.GetMouseButtonUp(0) && TowerCollision == false)
                            {

                                TileType = 1;
                                Tetra.GetComponent<TileSnapper>().GridX = GridX;
                                Tetra.GetComponent<TileSnapper>().GridY = GridY;
                                SpriteRenderer.sprite = spriteP1;
                                Tetra.GetComponent<TileSnapper>().KILLME = true;
                                EatenTetra = true;
                                


                            }
                        }
                    }
                    

                }
                if (EatenTetra == false)
                {


                    for (int i = 0; i < Tets.Length; i++)
                    {

                        Tet = Tets[i];
                        Killed = Tet.GetComponent<TileSnapper>().KILLME;
                        if (Killed == false)
                        {
                            TetColl = Tet.GetComponent<Collider2D>();

                            if (ThisObjectColl.bounds.Intersects(TetColl.bounds) && Input.GetMouseButtonUp(0) && TowerCollision == false)
                            {
                                TowerSquares = GameObject.FindGameObjectsWithTag("TowerSpot");

                                TileType = 1;
                                Tet.GetComponent<TileSnapper>().GridX = GridX;
                                Tet.GetComponent<TileSnapper>().GridY = GridY;
                                SpriteRenderer.sprite = spriteP1;
                                Tet.GetComponent<TileSnapper>().KILLME = true;
                                EatenTetra = true;
                                



                            }
                        }
                    }

                }
            }
            else if (TowerCollision == false && TowerCollision2 == false && Turn == 2)
            {
                if (EatenTetra == false)
                {


                    for (int i = 0; i < Tetras.Length; i++)
                    {

                        Tetra = Tetras[i];
                        Killed = Tetra.GetComponent<TileSnapper>().KILLME;
                        if (Killed == false)
                        {
                            TetraColl = Tetra.GetComponent<Collider2D>();

                            if (ThisObjectColl.bounds.Intersects(TetraColl.bounds) && Input.GetMouseButtonUp(0) && TowerCollision == false)
                            {

                                TileType = 1;
                                Tetra.GetComponent<TileSnapper>().GridX = GridX;
                                Tetra.GetComponent<TileSnapper>().GridY = GridY;
                                SpriteRenderer.sprite = spriteP2;
                                Tetra.GetComponent<TileSnapper>().KILLME = true;
                                EatenTetra = true;
                                



                            }
                        }
                    }

                }
                if (EatenTetra == false)
                {


                    for (int i = 0; i < Tets.Length; i++)
                    {

                        Tet = Tets[i];
                        Killed = Tet.GetComponent<TileSnapper>().KILLME;
                        if (Killed == false)
                        {
                            TetColl = Tet.GetComponent<Collider2D>();

                            if (ThisObjectColl.bounds.Intersects(TetColl.bounds) && Input.GetMouseButtonUp(0) && TowerCollision == false)
                            {
                                TowerSquares = GameObject.FindGameObjectsWithTag("TowerSpot");

                                TileType = 1;
                                Tet.GetComponent<TileSnapper>().GridX = GridX;
                                Tet.GetComponent<TileSnapper>().GridY = GridY;
                                SpriteRenderer.sprite = spriteP2;
                                Tet.GetComponent<TileSnapper>().KILLME = true;
                                EatenTetra = true;
                                



                            }
                        }
                    }

                }
            }
            
        }
    }
            } 
