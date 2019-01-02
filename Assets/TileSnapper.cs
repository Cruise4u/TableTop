using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSnapper : MonoBehaviour {

    public bool KILLME;
    public int GridX;
    public int GridY;
    GameObject TurnOb;
    GameObject CounterReducer;
    GameObject MouseScript;
    bool DoOnce;
    bool MouseIsOver = true;

    // Use this for initialization
    void Start () {
        KILLME = false;
        TurnOb = GameObject.Find("EndTurn");
        DoOnce = true;
        



    }

  

    // Update is called once per frame
    void Update()
    {

        if (gameObject.tag != "Tower" && MouseIsOver == true || gameObject.tag == "Tower" && gameObject.GetComponent<MouseScript>().Moved == false && MouseIsOver == true)
        {
            if (Input.GetKeyDown(KeyCode.Q) && KILLME != true)
            {
                gameObject.transform.Rotate(0, 0, 90);
            }
            if (Input.GetKeyDown(KeyCode.E) && KILLME != true)
            {
                gameObject.transform.Rotate(0, 0, -90);
            }
        }
        if (gameObject.tag != "Tower")
        {
            if (TurnOb.GetComponent<ChangeSprite>().Turn == 1)
            {
                CounterReducer = GameObject.Find("BuildCounter");
            }
            else
            {
                CounterReducer = GameObject.Find("BuildCounterP2");
            }

            if (KILLME == true)
            {
                gameObject.GetComponent<Renderer>().enabled = false;
                if (DoOnce == true)
                {
                    TurnOb.GetComponent<ChangeSprite>().Builded = true;
                    DoOnce = false;
                    if (3 <= CounterReducer.GetComponent<CounterScript>().counterValue)
                    {
                        CounterReducer.GetComponent<CounterScript>().NumberChange = -3;
                    }
                }

            }
        }
    }
}
