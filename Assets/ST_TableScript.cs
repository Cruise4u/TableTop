using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ST_TableScript : MonoBehaviour
{

    public int SpawnPointsPlayer1;
    public int SpawnPointsPlayer2;
    GameObject Token1;
    GameObject Token2;
    GameObject Token3;
    GameObject STCounter;
    bool RollButtonHasBeenPressed;
    GameObject Main;
    Vector3 Token1Position;
    Vector3 Token2Position;
    Vector3 Token3Position;
    Vector3 TablePosition;
    bool MouseRightButtonDown;
    public bool TokenAte;
    public float SpawnPoints;
    GameObject TurnChecker;
    GameObject STCounterP2;
    int Turn;


    // Use this for initialization
    void Start()
    {
        
        TurnChecker = GameObject.Find("EndTurn");
        SpawnPointsPlayer1 = 0;
        SpawnPointsPlayer2 = 0;
        RollButtonHasBeenPressed = false;
        Main = GameObject.Find("VoidDungeoun");
        STCounter = GameObject.Find("SpawnCounter");
        STCounterP2 = GameObject.Find("SpawnCounterP2");
    }

    // Update is called once per frame
    void Update()
    {
        Turn = TurnChecker.GetComponent<ChangeSprite>().Turn;
        if (Turn == 1 && gameObject.name == "ST_Table(Clone)")
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
                    SpawnPoints = Token1.GetComponent<MouseScript>().TokenRollNumber;
                    Debug.Log(SpawnPoints);
                    STCounter.GetComponent<CounterScript>().NumberChange = SpawnPoints;
                    TokenAte = true;
                    Token1.GetComponent<MouseScript>().ShowSelf = false;
                }
                if (Token2Position == TablePosition && MouseRightButtonDown == false && TokenAte == false)
                {
                    SpawnPoints = Token2.GetComponent<MouseScript>().TokenRollNumber;
                    Debug.Log(SpawnPoints);
                    TokenAte = true;
                    STCounter.GetComponent<CounterScript>().NumberChange = SpawnPoints;
                    Token2.GetComponent<MouseScript>().ShowSelf = false;
                }
                if (Token3Position == TablePosition && MouseRightButtonDown == false && TokenAte == false)
                {
                    SpawnPoints = Token3.GetComponent<MouseScript>().TokenRollNumber;
                    Debug.Log(SpawnPoints);
                    TokenAte = true;
                    STCounter.GetComponent<CounterScript>().NumberChange = SpawnPoints;
                    Token3.GetComponent<MouseScript>().ShowSelf = false;
                }
            }

        }
        else if (Turn == 2 && gameObject.name == "ST_TableP2(Clone)")
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
                    SpawnPoints = Token1.GetComponent<MouseScript>().TokenRollNumber;
              
                    Debug.Log("TURN2");
                    STCounterP2.GetComponent<CounterScript>().NumberChange = SpawnPoints;
                    TokenAte = true;
                    Token1.GetComponent<MouseScript>().ShowSelf = false;
                }
                if (Token2Position == TablePosition && MouseRightButtonDown == false && TokenAte == false)
                {
                    SpawnPoints = Token2.GetComponent<MouseScript>().TokenRollNumber;
                    Debug.Log("TURN2");
                    TokenAte = true;
                    STCounterP2.GetComponent<CounterScript>().NumberChange = SpawnPoints;
                    Token2.GetComponent<MouseScript>().ShowSelf = false;
                }
                if (Token3Position == TablePosition && MouseRightButtonDown == false && TokenAte == false)
                {
                    SpawnPoints = Token3.GetComponent<MouseScript>().TokenRollNumber;
                    Debug.Log("TURN2");
                    TokenAte = true;
                    STCounterP2.GetComponent<CounterScript>().NumberChange = SpawnPoints;
                    Token3.GetComponent<MouseScript>().ShowSelf = false;
                }
            }

        }
    }
}
