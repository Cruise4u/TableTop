using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionScript : MonoBehaviour
{
    public int GridX;
    public int GridY;
    public int Move;
    public int Hp;
    public int Dmg;
    public int Range;
    public int Cost;

    GameObject MinionObj;
    GameObject otherObject;
    GameObject obj;
    MainGame Main;
    GridScript otherObj_Script;
    GridScript MinionTilePos;
    GridScript PlaceCheck;
    bool canMove;
    int  movementleft;
    GameObject Turn;
    int turnchange;
    int oldturnchange;
    GameObject Undo;
    GameObject Comfirm;
    int OriginGridX;
    int OriginGridY;
    GameObject otherObjectOrigin;
    public int PlayerOwner;
    bool DoOncePerTurn;
    bool Selected;
    bool Undoing;
    bool Confirming;
    bool DoOnceForver;
    public bool selected;
    bool MouseOverMe;
    bool Confrimed;
    Component halo;
    GameObject[] MinionList;
    GameObject OtherMinion;
    List<GameObject> HittableMinonList;
    public bool ICanBeHit;
    bool YetAnotherDoOnce;




    // Pedro new
    public bool IsonGrid = false;
    bool DoOnce;
    string IMASTRING;
    MinionScript enemy;
    bool canAttack;
    GameObject enemyobj;



    private void OnMouseOver()
    {
        MouseOverMe = true;
        Debug.Log("MouseME");
    }

    private void OnMouseExit()
    {
        MouseOverMe = false;
    }

    void Start()
    {
        HittableMinonList = new List<GameObject>();
        // Pedro
        MinionObj = gameObject;
        MinionTilePos = MinionObj.GetComponent<GridScript>();
        movementleft = Move;
        Turn = GameObject.Find("EndTurn");
        Undo = GameObject.Find("UndoButton"); 
        Comfirm = GameObject.Find("ConfirmButton");
        DoOnceForver = true;
        Confirming = false;
        selected = false;
        halo = GetComponent("Halo");
        YetAnotherDoOnce = false;

        // Pedro

        enemy = enemyobj.GetComponent<MinionScript>();
    }


    void Attack(MinionScript target)
    {
                if (target.GridX >= gameObject.GetComponent<MinionScript>().GridX - Range || target.GridX <= gameObject.GetComponent<MinionScript>().GridX + Range)
                { 
                    if()
                    {


                    }
                    else
                    {

                    }
                enemyobj = GameObject.FindGameObjectWithTag("Minion P1");
                canAttack = true;
                if (Input.GetKey(KeyCode.K))
                {
                    if (canAttack == true)
                    {
                        target.GetComponent<MinionScript>().Hp = target.GetComponent<MinionScript>().Hp - gameObject.GetComponent<MinionScript>().Dmg;
                        Debug.Log("ATtack!");
                        Attack(enemy);
                        if (enemy.Hp <= 0)
                        {
                            Destroy(enemyobj);
                        }
                    }
                }
            }
            else if (selected == true && enemy.GetComponent<MinionScript>().PlayerOwner == 0)
            {
                enemyobj = GameObject.FindGameObjectWithTag("Minion P2");
                if (Input.GetKey(KeyCode.K))
                {
                    Attack(enemy);
                    if (enemy.Hp <= 0)
                    {
                        Destroy(enemyobj);
                    }
                }
            }
        }
    }

    void Update()
    {
        Attack(enemy);
        gameObject.GetComponent<MouseScript>().IsonGrid = IsonGrid;
        turnchange = Turn.GetComponent<ChangeSprite>().Turn;
        Undoing = Undo.GetComponent<Button_Script>().IsMouseOverRollButton;
        Confirming = Comfirm.GetComponent<Button_Script>().IsMouseOverRollButton;
        if(Confirming == true && Input.GetMouseButtonDown(0) && selected == true )
        {
           Confrimed = true;

        }
        if (DoOnceForver == true && turnchange !=0)
        {
            PlayerOwner = Turn.GetComponent<ChangeSprite>().Turn;
            DoOnceForver = false;
        }
        if (oldturnchange != turnchange && DoOncePerTurn == false)
        {
            DoOncePerTurn = true;
            Confrimed = false;
        }
        if (DoOncePerTurn == true && IsonGrid == true && Input.GetMouseButtonDown(0))
        {
            movementleft = Move;
            oldturnchange = turnchange;
            OriginGridX = GridX;
            OriginGridY = GridY;
            DoOncePerTurn = false;
            otherObjectOrigin = GameObject.Find("Empty Tile  " + "x: " + GridX + " " + "y: " + GridY);
        }
        if (Undoing == true && Input.GetMouseButtonDown(0) && IsonGrid == true && Confrimed == false)
        {
            gameObject.transform.position = otherObjectOrigin.transform.position;
            GridY = OriginGridY;
            GridX = OriginGridX;
            movementleft = Move;
        }
        if (MouseOverMe == true && Input.GetMouseButtonDown(0) && turnchange == PlayerOwner)
        {
            Debug.Log("SELECTED");
            halo.GetType().GetProperty("enabled").SetValue(halo, true, null);
            gameObject.GetComponent<SpriteRenderer>().color = new Vector4(255, 0, 0, 255);
            selected = true;
        }
        if (MouseOverMe == false && Input.GetMouseButtonDown(0))
        {
            Debug.Log("NotDebug.LogSELECTED)");
            halo.GetType().GetProperty("enabled").SetValue(halo, false, null);
            gameObject.GetComponent<SpriteRenderer>().color = new Vector4(255, 255, 255, 255); 
            
            selected = false;
        }

        if (PlayerOwner == turnchange && selected == true&&  Confrimed == false)
        {
           
            if (IsonGrid == true && DoOnce == true && Input.GetMouseButtonUp(0))
            {
                otherObject = GameObject.Find("Empty Tile  " + "x: " + GridX + " " + "y: " + GridY);
                DoOnce = false;
            }
            if (IsonGrid == true && Input.GetKeyDown(KeyCode.W) && movementleft > 0)
            {
                GridY = GridY + 1;
                IMASTRING = ("Empty Tile  " + "x: " + GridX + " " + "y: " + GridY);
                otherObject = GameObject.Find(IMASTRING);
                if (otherObject.GetComponent<GridScript>().TileType == 1 || otherObject.GetComponent<GridScript>().TileType == 2)
                {
                    gameObject.transform.position = otherObject.transform.position;
                    movementleft = movementleft - 1;
                }
                else
                {
                    GridY = GridY - 1;
                    IMASTRING = ("Empty Tile  " + "x: " + GridX + " " + "y: " + GridY);
                    otherObject = GameObject.Find(IMASTRING);
                }

            }
            if (IsonGrid == true && Input.GetKeyDown(KeyCode.S) && movementleft > 0)
            {
                GridY = GridY - 1;
                IMASTRING = ("Empty Tile  " + "x: " + GridX + " " + "y: " + GridY);
                otherObject = GameObject.Find(IMASTRING);
                if (otherObject.GetComponent<GridScript>().TileType == 1 || otherObject.GetComponent<GridScript>().TileType == 2)
                {
                    gameObject.transform.position = otherObject.transform.position;
                    movementleft = movementleft - 1;
                }
                else
                {
                    GridY = GridY + 1;
                    IMASTRING = ("Empty Tile  " + "x: " + GridX + " " + "y: " + GridY);
                    otherObject = GameObject.Find(IMASTRING);
                }

            }
            if (IsonGrid == true && Input.GetKeyDown(KeyCode.A) && movementleft > 0)
            {
                GridX = GridX - 1;
                IMASTRING = ("Empty Tile  " + "x: " + GridX + " " + "y: " + GridY);
                otherObject = GameObject.Find(IMASTRING);
                if (otherObject.GetComponent<GridScript>().TileType == 1 || otherObject.GetComponent<GridScript>().TileType == 2)
                {
                    gameObject.transform.position = otherObject.transform.position;
                    movementleft = movementleft - 1;
                }
                else
                {
                    GridX = GridX + 1;
                    IMASTRING = ("Empty Tile  " + "x: " + GridX + " " + "y: " + GridY);
                    otherObject = GameObject.Find(IMASTRING);
                }
            }
            if (IsonGrid == true && Input.GetKeyDown(KeyCode.D) && movementleft > 0)
            {
                GridX = GridX + 1;
                IMASTRING = ("Empty Tile  " + "x: " + GridX + " " + "y: " + GridY);
                otherObject = GameObject.Find(IMASTRING);
                if (otherObject.GetComponent<GridScript>().TileType == 1 || otherObject.GetComponent<GridScript>().TileType == 2)
                {
                    gameObject.transform.position = otherObject.transform.position;
                    movementleft = movementleft - 1;
                }
                else
                {
                    GridX = GridX - 1;
                    IMASTRING = ("Empty Tile  " + "x: " + GridX + " " + "y: " + GridY);
                    otherObject = GameObject.Find(IMASTRING);
                }
            }
        }
    }
}