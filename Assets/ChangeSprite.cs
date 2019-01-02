using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeSprite : MonoBehaviour {
 
    public Sprite sprite1;
    public Sprite sprite2;
    SpriteRenderer spriteRenderer;
    GameObject Token;
    GameObject RollButton;
    GameObject[] TokenList;
    GameObject AT_Table;
    GameObject ST_Table;
    GameObject LT_Table;
    GameObject AT_TableP2;
    GameObject ST_TableP2;
    GameObject LT_TableP2;
    public bool Builded;


    bool ismouseover;

    public int Turn;
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SwapSprite();
            ismouseover = true;
            Debug.Log(ismouseover);
        }
        
    }
    private void OnMouseExit()
    {
        ismouseover = false;
    }

    // Use this for initialization
    void Start () {
        Builded = false;
        Turn = 1;
        GameObject PlayerTurn = GameObject.Find("PlayerTurn");
        spriteRenderer = PlayerTurn.GetComponent<SpriteRenderer>();
        RollButton = GameObject.Find("VoidDungeoun");
    }


    void SwapSprite()
    {
        Builded = false;
        RollButton.GetComponent<MainGame>().BuildPerTurn = false;
        GameObject[] TokenList = GameObject.FindGameObjectsWithTag("Token");
        for(int i = 0; i < TokenList.Length; i++)
        {
            GameObject Token = TokenList[i];
            Token.GetComponent<MouseScript>().endturn = true;

        }
        if (spriteRenderer.sprite == sprite1)
        {
            AT_TableP2.GetComponent<AT_TableScript>().TokenAte = false;
            ST_TableP2.GetComponent<ST_TableScript>().TokenAte = false;
            LT_TableP2.GetComponent<LS_TableScript>().TokenAte = false;
            Turn = 2;
            spriteRenderer.sprite = sprite2;
            RollButton.GetComponent<MainGame>().RollButtonHasBeenPressed = false;
            TokenList = GameObject.FindGameObjectsWithTag("Token");
            RollButton.GetComponent<MainGame>().TurnEnded = true;
            for (int i = 0; i < TokenList.Length; i++)
            {
                Token = TokenList[i];
                Token.GetComponent<MouseScript>().ShowSelf = true;
                Token.GetComponent<MouseScript>().DoneOnce = false;
               
            }
        }
        else
        {
            AT_Table.GetComponent<AT_TableScript>().TokenAte = false;
            ST_Table.GetComponent<ST_TableScript>().TokenAte = false;
            LT_Table.GetComponent<LS_TableScript>().TokenAte = false;
            Turn = 1;
            spriteRenderer.sprite = sprite1;
            RollButton.GetComponent<MainGame>().RollButtonHasBeenPressed = false;
            RollButton.GetComponent<MainGame>().TokensSpawn = false;
            TokenList = GameObject.FindGameObjectsWithTag("Token");
            RollButton.GetComponent<MainGame>().TurnEnded = true;
            for (int i = 0; i < TokenList.Length; i++)
            {
                Token = TokenList[i];
                Token.GetComponent<MouseScript>().ShowSelf = true;
                Token.GetComponent<MouseScript>().DoneOnce = false;
                
            }
        }
        
    }

    
    // Update is called once per frame
    void Update () {
        AT_Table = GameObject.Find("AT_Table(Clone)"); 
        ST_Table = GameObject.Find("ST_Table(Clone)"); 
        LT_Table = GameObject.Find("LT_Table(Clone)");
        AT_TableP2 = GameObject.Find("AT_TableP2(Clone)");
        ST_TableP2 = GameObject.Find("ST_TableP2(Clone)");
        LT_TableP2 = GameObject.Find("LT_TableP2(Clone)");
    }

    
}
