using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScript : MonoBehaviour {
    public float TokenRollNumber;
    public Vector3 TokenPosition;
    bool RollButtonPressed;
    GameObject RollButton;
    public bool ShowSelf;
    public bool DoneOnce;
    public Vector3 tokenPos;
    public bool endturn;
    Vector3 Origin;
    public bool Dragging;
    GameObject EndTurn;
    public Sprite Token1;
    public Sprite Token2;
    public Sprite Token3;
    SpriteRenderer spriteRenderer;
    int GridX;
    bool Dragging2;
    public bool Moved;
    public bool IsonGrid;

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        RollButton =  GameObject.Find("VoidDungeoun");
        ShowSelf = true;
        DoneOnce = false;
        tokenPos = gameObject.transform.position;
        Origin = gameObject.transform.position;
        EndTurn = GameObject.Find("EndTurn");
        Moved = false;
        Dragging2 = false;
        IsonGrid = false;




            if (gameObject.tag == "Tet")
        {
            gameObject.transform.Rotate(0,0,90);
        }
    }

    private void OnMouseDrag()
    {
       
        Debug.Log("OnMouseDrag");
        if (ShowSelf == true && TokenRollNumber != 0 || ShowSelf == true && gameObject.tag != "Token" && gameObject.tag != "Tower" || gameObject.tag == "Tower" && Moved == false || gameObject.tag == "Minion" && IsonGrid != true)
        {
            if (IsonGrid == false)
            {

                Vector2 MousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

                Vector2 SelectedPos = Camera.main.ScreenToWorldPoint(MousePos);

                gameObject.transform.position = SelectedPos;

                Debug.Log(TokenRollNumber);

                Dragging2 = true;
            }

        }
      
        

    }

    public void SendBack()
    {
        if (gameObject.tag == "Tet" || gameObject.tag == "ChildTet")
        {
           
            gameObject.transform.position = Origin;
            
        }
    }


    void Update()
    {
        Dragging = Dragging2;
        if (gameObject.tag == "Tower" && Moved == true)
        {
            GridX = gameObject.GetComponent<TowerPlacer>().GridX;
           
        }
        if (gameObject.tag == "Tower")
        {
            GridX = gameObject.GetComponent<TowerPlacer>().GridX;
        }
        if ( TokenRollNumber == 1 && gameObject.tag == "Token")
        {
            spriteRenderer.sprite = Token1;
        }
        else if (TokenRollNumber ==2 && gameObject.tag == "Token")
        {
            spriteRenderer.sprite = Token2;
        }

        else if (TokenRollNumber == 3 && gameObject.tag == "Token")
        {
            spriteRenderer.sprite = Token3;
        }
        else if (TokenRollNumber == 0 && gameObject.tag == "Token")
        {
            gameObject.GetComponent<Renderer>().enabled = false;

        }
            if (endturn == true)
        {
            TokenRollNumber = 0;
            gameObject.transform.position = Origin;
            endturn = false;
        }

        RollButtonPressed = RollButton.GetComponent<MainGame>().RollButtonHasBeenPressed;

        if (gameObject.tag == "Token" && DoneOnce == false)
        {
            gameObject.GetComponent<Renderer>().enabled = true;
            ShowSelf = true;
            DoneOnce = true;
            gameObject.transform.position = tokenPos;

        }
        if(ShowSelf == false || RollButtonPressed == false)
        {
            gameObject.GetComponent<Renderer>().enabled = false;
        }
        if(gameObject.tag != "Token")
        {
            ShowSelf= true;
            gameObject.GetComponent<Renderer>().enabled = true;
        }
        if(ShowSelf == true)
        {
            gameObject.GetComponent<Renderer>().enabled = true;
        }

        TokenPosition = gameObject.transform.position;


    }
}
