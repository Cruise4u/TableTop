using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LS_TableScript : MonoBehaviour
{

    public int BuildPointsPlayer1;
    public int BuildPointsPlayer2;
    GameObject Token1;
    GameObject Token2;
    GameObject Token3;
    GameObject BuCounter;
    bool RollButtonHasBeenPressed;
    GameObject Main;
    Vector3 Token1Position;
    Vector3 Token2Position;
    Vector3 Token3Position;
    Vector3 TablePosition;
    bool MouseRightButtonDown;
    public bool TokenAte;
    public float BuildPoints;
    GameObject TurnChecker;
    GameObject BuCounterP2;
    int Turn;

    // Use this for initialization
    void Start()
    {
        TurnChecker = GameObject.Find("EndTurn");
        BuildPointsPlayer1 = 0;
        BuildPointsPlayer2 = 0;
        RollButtonHasBeenPressed = false;
        Main = GameObject.Find("VoidDungeoun");
        BuCounter = GameObject.Find("BuildCounter");
        BuCounterP2 = GameObject.Find("BuildCounterP2");
    }

    // Update is called once per frame
    void Update()
    {
        Turn = TurnChecker.GetComponent<ChangeSprite>().Turn;
        RollButtonHasBeenPressed = Main.GetComponent<MainGame>().RollButtonHasBeenPressed;


        TablePosition = gameObject.transform.position;

        if (Turn == 1 && gameObject.name == "LT_Table(Clone)")
        {
            if (RollButtonHasBeenPressed == true && TokenAte == false)
            {
                MouseRightButtonDown = Main.GetComponent<MainGame>().MouseRightButtonDown;
                Token1 = GameObject.Find("Token nº 0");
                Token2 = GameObject.Find("Token nº 1");
                Token3 = GameObject.Find("Token nº 2");
                Token1Position = Token1.GetComponent<MouseScript>().TokenPosition;
                Token2Position = Token2.GetComponent<MouseScript>().TokenPosition;
                Token3Position = Token3.GetComponent<MouseScript>().TokenPosition;
                if (Token1Position == TablePosition && MouseRightButtonDown == false && TokenAte == false)
                {
                    BuildPoints = Token1.GetComponent<MouseScript>().TokenRollNumber;
                    Debug.Log(BuildPoints);
                    BuCounter.GetComponent<CounterScript>().NumberChange = BuildPoints;
                    TokenAte = true;
                    Token1.GetComponent<MouseScript>().ShowSelf = false;

                }
                if (Token2Position == TablePosition && MouseRightButtonDown == false && TokenAte == false)
                {
                    BuildPoints = Token2.GetComponent<MouseScript>().TokenRollNumber;
                    Debug.Log(BuildPoints);
                    BuCounter.GetComponent<CounterScript>().NumberChange = BuildPoints;
                    TokenAte = true;
                    Token2.GetComponent<MouseScript>().ShowSelf = false;

                }
                if (Token3Position == TablePosition && MouseRightButtonDown == false && TokenAte == false)
                {
                    BuildPoints = Token3.GetComponent<MouseScript>().TokenRollNumber;
                    Debug.Log(BuildPoints);
                    BuCounter.GetComponent<CounterScript>().NumberChange = BuildPoints;
                    TokenAte = true;
                    Token3.GetComponent<MouseScript>().ShowSelf = false;

                }
            }
        }
        else if (Turn == 2 && gameObject.name == "LT_TableP2(Clone)")
        {
            RollButtonHasBeenPressed = Main.GetComponent<MainGame>().RollButtonHasBeenPressed;


            TablePosition = gameObject.transform.position;

            if (RollButtonHasBeenPressed == true && TokenAte == false)
            {
                MouseRightButtonDown = Main.GetComponent<MainGame>().MouseRightButtonDown;
                Token1 = GameObject.Find("Token nº 0");
                Token2 = GameObject.Find("Token nº 1");
                Token3 = GameObject.Find("Token nº 2");
                Token1Position = Token1.GetComponent<MouseScript>().TokenPosition;
                Token2Position = Token2.GetComponent<MouseScript>().TokenPosition;
                Token3Position = Token3.GetComponent<MouseScript>().TokenPosition;
                if (Token1Position == TablePosition && MouseRightButtonDown == false && TokenAte == false)
                {
                    BuildPoints = Token1.GetComponent<MouseScript>().TokenRollNumber;

                    Debug.Log("TURN2");
                    BuCounterP2.GetComponent<CounterScript>().NumberChange = BuildPoints;
                    TokenAte = true;
                    Token1.GetComponent<MouseScript>().ShowSelf = false;
                }
                if (Token2Position == TablePosition && MouseRightButtonDown == false && TokenAte == false)
                {
                    BuildPoints = Token2.GetComponent<MouseScript>().TokenRollNumber;
                    Debug.Log("TURN2");
                    TokenAte = true;
                    BuCounterP2.GetComponent<CounterScript>().NumberChange = BuildPoints;
                    Token2.GetComponent<MouseScript>().ShowSelf = false;
                }
                if (Token3Position == TablePosition && MouseRightButtonDown == false && TokenAte == false)
                {
                    BuildPoints = Token3.GetComponent<MouseScript>().TokenRollNumber;
                    Debug.Log("TURN2");
                    TokenAte = true;
                    BuCounterP2.GetComponent<CounterScript>().NumberChange = BuildPoints;
                    Token3.GetComponent<MouseScript>().ShowSelf = false;
                }
            }


        }
    }
}
