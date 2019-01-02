using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AT_TableScript : MonoBehaviour
{

//    public int AbilityPointsPlayer1;
//    public int AbilityPointsPlayer2;
//    GameObject Token1;
//    GameObject Token2;
//    GameObject Token3;
//    GameObject AbCounter;
//    bool RollButtonHasBeenPressed;
//    GameObject Main;
//    Vector3 Token1Position;
//    Vector3 Token2Position;
//    Vector3 Token3Position;
//    Vector3 TablePosition;
//    bool MouseRightButtonDown;
//    public bool TokenAte;
//    public float AbilityPoints;

//    // Use this for initialization
//    void Start () {
//        AbilityPointsPlayer1 = 0;
//        AbilityPointsPlayer2 = 0;
//        RollButtonHasBeenPressed = false;
//        Main = GameObject.Find("VoidDungeoun");
//        AbCounter = GameObject.Find("AbilityCounter");
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        RollButtonHasBeenPressed = Main.GetComponent<MainGame>().RollButtonHasBeenPressed;


//        TablePosition = gameObject.transform.position;

//        if (RollButtonHasBeenPressed == true && TokenAte == false)
//        {
//            MouseRightButtonDown = Main.GetComponent<MainGame>().MouseRightButtonDown;
//            Token1 = GameObject.Find("Token nº 0");
//            Token2 = GameObject.Find("Token nº 1");
//            Token3 = GameObject.Find("Token nº 2");
//            Token1Position = Token1.GetComponent<MouseScript>().TokenPosition;
//            Token2Position = Token2.GetComponent<MouseScript>().TokenPosition;
//            Token3Position = Token3.GetComponent<MouseScript>().TokenPosition;
//            if (Token1Position == TablePosition && MouseRightButtonDown == false && TokenAte == false)
//            {
//                AbilityPoints = Token1.GetComponent<MouseScript>().TokenRollNumber;
//                Debug.Log(AbilityPoints);
//                AbCounter.GetComponent<CounterScript>().NumberChange = AbilityPoints;
//                TokenAte = true;
//                Token1.GetComponent<MouseScript>().ShowSelf = false;

//            }
//            if (Token2Position == TablePosition && MouseRightButtonDown == false && TokenAte == false)
//            {
//                AbilityPoints = Token2.GetComponent<MouseScript>().TokenRollNumber;
//                Debug.Log(AbilityPoints);
//                AbCounter.GetComponent<CounterScript>().NumberChange = AbilityPoints;
//                TokenAte = true;
//                Token2.GetComponent<MouseScript>().ShowSelf = false;

//            }
//            if (Token3Position == TablePosition && MouseRightButtonDown == false && TokenAte == false)
//            {
//                AbilityPoints = Token3.GetComponent<MouseScript>().TokenRollNumber;
//                Debug.Log(AbilityPoints);
//                AbCounter.GetComponent<CounterScript>().NumberChange = AbilityPoints;
//                TokenAte = true;
//                Token3.GetComponent<MouseScript>().ShowSelf = false;

//            }
//        }

//    }
//}


    public int AbilityPointsPlayer1;
    public int AbilityPointsPlayer2;
    GameObject Token1;
    GameObject Token2;
    GameObject Token3;
    GameObject Atcounter;
    bool RollButtonHasBeenPressed;
    GameObject Main;
    Vector3 Token1Position;
    Vector3 Token2Position;
    Vector3 Token3Position;
    Vector3 TablePosition;
    bool MouseRightButtonDown;
    public bool TokenAte;
    public float AbilityPoints;
    GameObject TurnChecker;
    GameObject AtcounterP2;
    int Turn;

    // Use this for initialization
    void Start()
    {
        TurnChecker = GameObject.Find("EndTurn");
        AbilityPointsPlayer1 = 0;
        AbilityPointsPlayer2 = 0;
        RollButtonHasBeenPressed = false;
        Main = GameObject.Find("VoidDungeoun");
        Atcounter = GameObject.Find("AbilityCounter");
        AtcounterP2 = GameObject.Find("AbilityCounterP2");
    }

    // Update is called once per frame
    void Update()
    {
        Turn = TurnChecker.GetComponent<ChangeSprite>().Turn;
        RollButtonHasBeenPressed = Main.GetComponent<MainGame>().RollButtonHasBeenPressed;


        TablePosition = gameObject.transform.position;

        if (Turn == 1 && gameObject.name == "AT_Table(Clone)")
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
                    AbilityPoints = Token1.GetComponent<MouseScript>().TokenRollNumber;
                    Debug.Log(AbilityPoints);
                    Atcounter.GetComponent<CounterScript>().NumberChange = AbilityPoints;
                    TokenAte = true;
                    Token1.GetComponent<MouseScript>().ShowSelf = false;

                }
                if (Token2Position == TablePosition && MouseRightButtonDown == false && TokenAte == false)
                {
                    AbilityPoints = Token2.GetComponent<MouseScript>().TokenRollNumber;
                    Debug.Log(AbilityPoints);
                    Atcounter.GetComponent<CounterScript>().NumberChange = AbilityPoints;
                    TokenAte = true;
                    Token2.GetComponent<MouseScript>().ShowSelf = false;

                }
                if (Token3Position == TablePosition && MouseRightButtonDown == false && TokenAte == false)
                {
                    AbilityPoints = Token3.GetComponent<MouseScript>().TokenRollNumber;
                    Debug.Log(AbilityPoints);
                    Atcounter.GetComponent<CounterScript>().NumberChange = AbilityPoints;
                    TokenAte = true;
                    Token3.GetComponent<MouseScript>().ShowSelf = false;

                }
            }
        }
        else if (Turn == 2 && gameObject.name == "AT_TableP2(Clone)")
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
                    AbilityPoints = Token1.GetComponent<MouseScript>().TokenRollNumber;

                    Debug.Log("TURN2");
                    AtcounterP2.GetComponent<CounterScript>().NumberChange = AbilityPoints;
                    TokenAte = true;
                    Token1.GetComponent<MouseScript>().ShowSelf = false;
                }
                if (Token2Position == TablePosition && MouseRightButtonDown == false && TokenAte == false)
                {
                    AbilityPoints = Token2.GetComponent<MouseScript>().TokenRollNumber;
                    Debug.Log("TURN2");
                    TokenAte = true;
                    AtcounterP2.GetComponent<CounterScript>().NumberChange = AbilityPoints;
                    Token2.GetComponent<MouseScript>().ShowSelf = false;
                }
                if (Token3Position == TablePosition && MouseRightButtonDown == false && TokenAte == false)
                {
                    AbilityPoints = Token3.GetComponent<MouseScript>().TokenRollNumber;
                    Debug.Log("TURN2");
                    TokenAte = true;
                    AtcounterP2.GetComponent<CounterScript>().NumberChange = AbilityPoints;
                    Token3.GetComponent<MouseScript>().ShowSelf = false;
                }
            }


        }
    }
}

