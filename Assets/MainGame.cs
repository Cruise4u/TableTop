using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour
{

    private GameObject[,] Grid = new GameObject[20, 14];
    private List<GameObject> VoidList;
    private List<GameObject> NormalList;
    private List<GameObject> TokenList;
    private List<GameObject> TetraminoList;
    private List<GameObject> TetraminoList2;
    private List<GameObject> Minions_01;
    private List<GameObject> Minions_02;


    float turn;

    public GameObject Normal_Block;
    public GameObject Void_Block;
    public GameObject Tetramino_Block_1;
    public GameObject Tetramino_Block_2;
    public GameObject Tetramino_Block_3;
    public GameObject Tetramino_Block_4;
    public GameObject Tetramino_Block_5;
    public GameObject Tetramino_Block_6;
    public GameObject Tetramino_Block_7;
    public GameObject Tetramino_Block_8;
    public GameObject Tower_Block;
    public GameObject AT_Table_Block;
    public GameObject ST_Table_Block;
    public GameObject LT_Table_Block;
    public GameObject AT_Table_BlockP2;
    public GameObject ST_Table_BlockP2;
    public GameObject LT_Table_BlockP2;
    public GameObject Token_Block;
    public GameObject Minion_Block;
    bool Player;
    //new 
    GameObject Token1;
    GameObject Token2;
    GameObject Token3;
    public bool TokensSpawn;

    GameObject ButtonRoll;

    bool MouseOverRollButton;
    bool IsMouseOverTetra;
    public bool RollButtonHasBeenPressed;
    public bool TokensHaveBeenSpawned;
    public bool MouseRightButtonDown;
    public bool TurnEnded;

    private List<GameObject> ChildTetraminoList;
    GameObject[] TetChilds;
    GameObject[] MinionObjects;
    GameObject[] GridObjects;
    GameObject[] TetList;
    Collider2D TetChildColl;
    Collider2D TetColl;
    GameObject TetChild;
    GameObject Tet;

    int TetAmmount;

    //new


    GameObject Token_Object;
    GameObject Void_Object;
    GameObject Normal_Object;
    GameObject Tetramino_Object;
    GameObject Minion_Object;


    // Pedro


    GameObject M_P1;
    GameObject M_P2;

    GameObject Tower_Object;
    GameObject AT_Object;
    GameObject ST_Object;
    GameObject LT_Object;
    GameObject AT_ObjectP2;
    GameObject ST_ObjectP2;
    GameObject LT_ObjectP2;

    GameObject ButtonBuild;


    Collider2D void_collision;
    Collider2D normal_collision;
    Collider2D tetramino_collision;
    Collider2D tower_collision;
    Collider2D Minion_collision;
    Collider2D tetramino_collision2;



    Collider2D AT_collision;
    Collider2D ST_collision;
    Collider2D LT_collision;
    Collider2D AT_collisionP2;
    Collider2D ST_collisionP2;
    Collider2D LT_collisionP2;
    Collider2D Token_collision;


    Transform GridBase_01;
    Transform GridBase_02;
    Vector2 voidTilePos;
    Vector2 normalTilePos;
    private bool isPicked;
    public bool BuildPerTurn;
    int ShapeCountL = 0;


    Vector2 Tower_Pos;
    Vector2 Tower_SPos;
    Vector2 Tetramino_Pos;

    Vector2 Minion_Pos_P1;
    Vector2 Minion_Pos_P2;

    Vector2 Normal_Pos;
    Vector2 Void_Pos;

    Vector2 AT_Pos;
    Vector2 ST_Pos;
    Vector2 LT_Pos;
    Vector2 AT_PosP2;
    Vector2 ST_PosP2;
    Vector2 LT_PosP2;
    Vector2 tokenPos;

    public GameObject Chosen;
    GameObject GoldToken;

    // new
    //public void ButtonClick()
    //{
    //    if (RollButtonHasBeenPressed == false)
    //    {
    //        Debug.Log("AmRunning");
    //        RollButtonHasBeenPressed = true;
    //        MouseOverRollButton = ButtonRoll.GetComponent<Button_Script>().IsMouseOverRollButton;
    //        if (MouseOverRollButton == true)
    //        {
    //            Debug.Log("AmRunning");



    //            if (TokensHaveBeenSpawned == true)
    //                {
    //                Debug.Log("AmRunning");
    //                    Token1 = GameObject.Find("Token nº 0");
    //                    Token2 = GameObject.Find("Token nº 1");
    //                    Token3 = GameObject.Find("Token nº 2");



    //            float DieRoll1 = Random.Range(0.5f, 3.5f);
    //            if (DieRoll1 <= 3.5 && DieRoll1 >= 2.5)
    //            { DieRoll1 = 3; }
    //            else if (DieRoll1 > 1.5)
    //            { DieRoll1 = 2; }
    //            else
    //            { DieRoll1 = 1; }

    //            Token1.GetComponent<MouseScript>().TokenRollNumber = DieRoll1;


    //            float DieRoll2 = Random.Range(0.5f, 3.5f);
    //            if (DieRoll2 <= 3.5 && DieRoll2 >= 2.5)
    //            { DieRoll2 = 3; }
    //            else if (DieRoll2 > 1.5)
    //            { DieRoll2 = 2; }
    //            else
    //            { DieRoll2 = 1; }

    //            Token2.GetComponent<MouseScript>().TokenRollNumber = DieRoll2;


    //            float DieRoll3 = Random.Range(0.5f, 3.5f);
    //            if (DieRoll3 <= 3.5 && DieRoll3 >= 2.5)
    //            { DieRoll3 = 3; }
    //            else if (DieRoll3 > 1.5)
    //            { DieRoll3 = 2; }
    //            else
    //            { DieRoll3 = 1; }

    //            Token3.GetComponent<MouseScript>().TokenRollNumber = DieRoll3;
    //            }

    //        }
    //    }
    //}
    // new

    // Use this for initialization
    void Start()
    {
        //new
        TurnEnded = true;
        TokensSpawn = true;
        MouseOverRollButton = false;
        RollButtonHasBeenPressed = false;
        TokensHaveBeenSpawned = false;
        MouseRightButtonDown = false;
        int GridCreationY = 14;
        int GridCreationX = 20;
        //new
        ButtonRoll = GameObject.Find("RollButton");
        ButtonBuild = GameObject.Find("BuildButton");
        VoidList = new List<GameObject>();
        NormalList = new List<GameObject>();
        TokenList = new List<GameObject>();
        TetraminoList = new List<GameObject>();
        TetraminoList2 = new List<GameObject>();




        AT_Pos = new Vector2(-5, -9);
        ST_Pos = new Vector2(0, -9);
        LT_Pos = new Vector2(5, -9);

        tokenPos = new Vector2(-14f, -6f);
        

        AT_Object = Instantiate(AT_Table_Block, AT_Pos, Quaternion.identity);
        ST_Object = Instantiate(ST_Table_Block, ST_Pos, Quaternion.identity);
        LT_Object = Instantiate(LT_Table_Block, LT_Pos, Quaternion.identity);

        AT_PosP2 = new Vector2(-20, -9);
        ST_PosP2 = new Vector2(-15, -9);
        LT_PosP2 = new Vector2(-10, -9);

        AT_ObjectP2 = Instantiate(AT_Table_BlockP2, AT_PosP2, Quaternion.identity);
        ST_ObjectP2 = Instantiate(ST_Table_BlockP2, ST_PosP2, Quaternion.identity);
        LT_ObjectP2 = Instantiate(LT_Table_BlockP2, LT_PosP2, Quaternion.identity);

        // Minion_Object = Instantiate(Minion_Block, new Vector2(-9, -7), Quaternion.identity);

        Minion_Pos_P1 = new Vector2(-15.8f, -5.99f);
        Minion_Pos_P2 = new Vector2(-1.9f, -5.89f);



        for(int i=0;i<0;i++)
        {
            M_P1 = Instantiate(Minion_Object, Minion_Pos_P1, Quaternion.identity);
            M_P1.name = "Minion " + "P1 " + i;
            Minions_01.Add(M_P1);
        }

        for (int i = 0; i < 0; i++)
        {
            M_P2 = Instantiate(Minion_Object, Minion_Pos_P2, Quaternion.identity);
            M_P2.name = "Minion " + "P2 " + i;
            Minions_02.Add(M_P2);
        }



        Tower_Object = Instantiate(Tower_Block, Tower_SPos, Quaternion.identity);


        ButtonBuild = GameObject.Find("BuildButton");



        voidTilePos = new Vector2(-18, 9);
        normalTilePos = new Vector2(-18, 9);



        for (int i = 0; i < GridCreationY; i++)
        {
            for (int j = 0; j < GridCreationX; j++)
            {
                if (j == 0 || j == 19 || i == 0 || i == 13)
                {
                    Void_Object = Instantiate(Void_Block, voidTilePos, Quaternion.identity) as GameObject;
                    int YFixer = GridCreationY;
                    YFixer = YFixer - i;
                    Void_Object.name = ("Void  " + "x: " + j + " " + "y: " + YFixer);
                    Void_Object.GetComponent<TowerSquare>().GridX = j;
                    Void_Object.GetComponent<TowerSquare>().GridY = YFixer;
                    VoidList.Add(Void_Object);



                }
                else
                {
                    Normal_Object = Instantiate(Normal_Block, normalTilePos, Quaternion.identity) as GameObject;
                    int YFixer = 13;
                    YFixer = YFixer - i;
                    Normal_Object.name = ("Empty Tile  " + "x: " + j + " " + "y: " + YFixer);
                    NormalList.Add(Normal_Object);
                    Normal_Object.GetComponent<GridScript>().GridX = j;
                    Normal_Object.GetComponent<GridScript>().GridY = YFixer;
                }

                voidTilePos += new Vector2(1f, 0);
                normalTilePos += new Vector2(1f, 0);

            }
            voidTilePos.x = -18f;
            voidTilePos.y -= 1;
            normalTilePos.x = -18f;
            normalTilePos.y -= 1;
        }

        void_collision = Void_Block.GetComponent<Collider2D>();
        normal_collision = Normal_Block.GetComponent<Collider2D>();
        tetramino_collision = Tetramino_Block_1.GetComponent<Collider2D>();
        tetramino_collision2 = Tetramino_Block_2.GetComponent<Collider2D>();
        tower_collision = Tower_Block.GetComponent<Collider2D>();
        AT_collision = AT_Table_Block.GetComponent<Collider2D>();
        ST_collision = ST_Table_Block.GetComponent<Collider2D>();
        LT_collision = LT_Table_Block.GetComponent<Collider2D>();
        AT_collisionP2 = AT_Table_BlockP2.GetComponent<Collider2D>();
        ST_collisionP2 = ST_Table_BlockP2.GetComponent<Collider2D>();
        LT_collisionP2 = LT_Table_BlockP2.GetComponent<Collider2D>();
        //Minion_collision = Minion_Object.GetComponent<Collider2D>();

        Void_Pos = Void_Object.transform.position;
        Tower_Pos = new Vector2(-18, -7);

        Token_collision = Token_Block.GetComponent<Collider2D>();
    }

    //// void checkTurn(bool Player) { MouseOverRollButton};



    //     turn = Random.Range(0.9f, 1.0f);

    //     if (turn < 0.95f)
    //     {
    //         Debug.Log("Player 1");
    //         Debug.Log(turn);
    //     }
    //     else if (turn > 0.95f)
    //     {
    //         Debug.Log("Player 2");
    //         Debug.Log(turn);
    //     }
    // }

    
    bool BuildButtonIsPressed;
    bool runonce;
    int ShapeCountC = 0;
    int ShapeCountT = 0;
    int ShapeCountZ = 0;

    // Update is called once per frame
    void Update()
    {

        // bool MouseOverBuildButton = ButtonBuild.GetComponent<BuildButton>().IsMouseOverRollButton;
        // new
        BuildButtonIsPressed = ButtonBuild.GetComponent<Button_Script>().IsMouseOverRollButton;
        if (BuildButtonIsPressed == true && BuildPerTurn == false && Input.GetMouseButtonDown(0))
        {
            BuildPerTurn = true;
            if (runonce == false)
            {
                runonce = true;
                Tetramino_Pos = new Vector2(-24.62941f, -8.171326f);
                ShapeCountL = ShapeCountL + 1;
                Tetramino_Object = Instantiate(Tetramino_Block_1, Tetramino_Pos, Quaternion.identity);
                Tetramino_Object.name = "LShape" + ShapeCountL;
                Tetramino_Object.transform.rotation = new Quaternion(0, 0, 90, 0);
                Tetramino_Object = GameObject.Find("LShape" + ShapeCountL);
                TetraminoList2.Add(Tetramino_Object);

                Tetramino_Pos = new Vector2(-25.117f, -7.001098f);

                Tetramino_Object = Instantiate(Tetramino_Block_2, Tetramino_Pos, Quaternion.identity);
                ShapeCountC = ShapeCountC + 1;
                Tetramino_Object.name = "CrossRoad" + ShapeCountC;
                Tetramino_Object = GameObject.Find("CrossRoad" + ShapeCountL);
                TetraminoList2.Add(Tetramino_Object);

                Tetramino_Pos = new Vector2(-26.18971f, -4.221803f);

                Tetramino_Object = Instantiate(Tetramino_Block_3, Tetramino_Pos, Quaternion.identity);
                ShapeCountT = ShapeCountT + 1;
                Tetramino_Object.name = "Tee" + ShapeCountT;
                Tetramino_Object = GameObject.Find("Tee" + ShapeCountL);
                TetraminoList2.Add(Tetramino_Object);

                Tetramino_Pos = new Vector2(-24.43437f, -2.661498f);

                Tetramino_Object = Instantiate(Tetramino_Block_4, Tetramino_Pos, Quaternion.identity);
                ShapeCountZ = ShapeCountZ + 1;
                Tetramino_Object.name = "Zig" + ShapeCountZ;
                Tetramino_Object = GameObject.Find("Zig" + ShapeCountL);
                TetraminoList2.Add(Tetramino_Object);
            }
            else
            {
                foreach (GameObject Tetramino in TetraminoList2)
                {
                    TetraminoList.Add(Tetramino);
                }
                foreach (GameObject Tetramino in TetraminoList)
                {
                    bool IsKill = Tetramino.GetComponent<TileSnapper>().KILLME;
                    if (IsKill = true && Tetramino.name == "LShape" + ShapeCountL)
                    {
                        TetraminoList2.Remove(Tetramino);
                        Tetramino_Pos = new Vector2(-24.62941f, -8.171326f);
                        ShapeCountL = ShapeCountL + 1;
                        Tetramino_Object = Instantiate(Tetramino_Block_1, Tetramino_Pos, Quaternion.identity);
                        Tetramino_Object.name = "LShape" + ShapeCountL;
                        Tetramino_Object.transform.rotation = new Quaternion(0, 0, 90, 0);

                        Tetramino_Object = GameObject.Find("LShape" + ShapeCountL);
                        TetraminoList2.Add(Tetramino_Object);
                    }
                    if (IsKill = true && Tetramino.name == "CrossRoad" + ShapeCountC)
                    {
                        Tetramino_Pos = new Vector2(-25.117f, -7.001098f);
                        TetraminoList2.Remove(Tetramino);
                        Tetramino_Object = Instantiate(Tetramino_Block_2, Tetramino_Pos, Quaternion.identity);
                        ShapeCountC = ShapeCountC + 1;
                        Tetramino_Object.name = "CrossRoad" + ShapeCountC;

                        Tetramino_Object = GameObject.Find("CrossRoad" + ShapeCountL);
                        TetraminoList2.Add(Tetramino_Object);
                    }
                    if (IsKill = true && Tetramino.name == "Tee" + ShapeCountT)
                    {
                        Tetramino_Pos = new Vector2(-26.18971f, -4.221803f);
                        TetraminoList2.Remove(Tetramino);
                        Tetramino_Object = Instantiate(Tetramino_Block_3, Tetramino_Pos, Quaternion.identity);
                        ShapeCountT = ShapeCountT + 1;
                        Tetramino_Object.name = "Tee" + ShapeCountT;

                        Tetramino_Object = GameObject.Find("Tee" + ShapeCountL);
                        TetraminoList2.Add(Tetramino_Object);
                    }
                    if (IsKill = true && Tetramino.name == "Zig" + ShapeCountZ)
                    {
                        Tetramino_Pos = new Vector2(-24.43437f, -2.661498f);
                        TetraminoList2.Remove(Tetramino);
                        Tetramino_Object = Instantiate(Tetramino_Block_4, Tetramino_Pos, Quaternion.identity);
                        ShapeCountZ = ShapeCountZ + 1;
                        Tetramino_Object.name = "Zig" + ShapeCountZ;

                        Tetramino_Object = GameObject.Find("Zig" + ShapeCountL);
                        TetraminoList2.Add(Tetramino_Object);
                    }
                }
                foreach (GameObject Tetramino in TetraminoList2)
                {
                    TetraminoList.Add(Tetramino);
                }
            }
        }





        // MouseOverRollButton = ButtonRoll.GetComponent<Button_Script>().IsMouseOverRollButton;
        // new

        if (RollButtonHasBeenPressed == false && MouseRightButtonDown == true)
        {
            Debug.Log("AmRunning1");


            if (TokensHaveBeenSpawned == false && TokensSpawn == true)
            {


                for (int i = 0; i < 3; i++)
                {

                    Token_Object = Instantiate(Token_Block, tokenPos, Quaternion.identity);
                    Token_Object.name = ("Token nº " + i);
                    TokenList.Add(Token_Object);
                    tokenPos.x += 1.5f;
                }
                TokensHaveBeenSpawned = true;
                Debug.Log(TokensHaveBeenSpawned);
                TokensSpawn = false;

                Debug.Log(MouseOverRollButton);
                Debug.Log(TokensHaveBeenSpawned);
                Debug.Log(TurnEnded);
            }

        }
        MouseOverRollButton = ButtonRoll.GetComponent<Button_Script>().IsMouseOverRollButton;
        if ((MouseOverRollButton == true) && (TokensHaveBeenSpawned == true) && (TurnEnded == true))
        {





            Debug.Log("AmRunning2");
            Token1 = GameObject.Find("Token nº 0");
            Token2 = GameObject.Find("Token nº 1");
            Token3 = GameObject.Find("Token nº 2");



            float DieRoll1 = Random.Range(0.5f, 3.5f);
            if (DieRoll1 <= 3.5 && DieRoll1 >= 2.5)
            {
                DieRoll1 = 3;
            }
            else if (DieRoll1 > 1.5)
            {
                DieRoll1 = 2;
            }
            else
            {
                DieRoll1 = 1;
            }

            Token1.GetComponent<MouseScript>().TokenRollNumber = DieRoll1;


            float DieRoll2 = Random.Range(0.5f, 3.5f);
            if (DieRoll2 <= 3.5 && DieRoll2 >= 2.5)
            {
                DieRoll2 = 3;
            }
            else if (DieRoll2 > 1.5)
            {
                DieRoll2 = 2;
            }
            else
            {
                DieRoll2 = 1;
            }

            Token2.GetComponent<MouseScript>().TokenRollNumber = DieRoll2;


            float DieRoll3 = Random.Range(0.5f, 3.5f);
            if (DieRoll3 <= 3.5 && DieRoll3 >= 2.5)
            {
                DieRoll3 = 3;
            }
            else if (DieRoll3 > 1.5)
            {
                DieRoll3 = 2;
            }
            else
            {
                DieRoll3 = 1;
            }

            Token3.GetComponent<MouseScript>().TokenRollNumber = DieRoll3;
            RollButtonHasBeenPressed = true;
            TurnEnded = false;


        }


        // new
        // new

        if (Input.GetMouseButtonDown(0))
        {
            // ButtonClick();
            MouseRightButtonDown = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            MouseRightButtonDown = false;
        }
        // new
        //if ()
        // {
        foreach (GameObject coin in TokenList)
        {

            Token_collision = coin.GetComponent<Collider2D>();
            AT_collision = AT_Object.GetComponent<Collider2D>();

            if (Token_collision.bounds.Intersects(AT_collision.bounds))
            {
                Token_collision.transform.position = AT_collision.transform.position;
            }

            LT_collision = LT_Object.GetComponent<Collider2D>();

            if (Token_collision.bounds.Intersects(LT_collision.bounds))
            {
                Token_collision.transform.position = LT_collision.transform.position;
            }

            ST_collision = ST_Object.GetComponent<Collider2D>();

            if (Token_collision.bounds.Intersects(ST_collision.bounds))
            {
                Token_collision.transform.position = ST_collision.transform.position;
            }

            AT_collisionP2 = AT_ObjectP2.GetComponent<Collider2D>();
            if (Token_collision.bounds.Intersects(AT_collisionP2.bounds))
            {
                Token_collision.transform.position = AT_collisionP2.transform.position;
            }


            LT_collisionP2 = LT_ObjectP2.GetComponent<Collider2D>();
            if (Token_collision.bounds.Intersects(LT_collisionP2.bounds))
            {
                Token_collision.transform.position = LT_collisionP2.transform.position;
            }

            ST_collisionP2 = ST_ObjectP2.GetComponent<Collider2D>();
            if (Token_collision.bounds.Intersects(ST_collisionP2.bounds))
            {
                Token_collision.transform.position = ST_collisionP2.transform.position;
            }
        }
        //  }
        foreach (GameObject VoidTiles in VoidList)
        {

            void_collision = VoidTiles.GetComponent<Collider2D>();


            GameObject[] TowerList = GameObject.FindGameObjectsWithTag("Tower");
            for (int i = 1; i < TowerList.Length - 1; i++)
            {
                tower_collision = TowerList[i].GetComponent<Collider2D>();
                GameObject tower;
                tower = TowerList[i];



                if (tower_collision.bounds.Intersects(void_collision.bounds) && Input.GetMouseButtonUp(0))
                {
                    if (tower.name != "TowerC")
                    {
                        tower.GetComponent<MouseScript>().Moved = true;
                    }
                    Debug.Log("Towerss");
                    tower.GetComponent<TowerPlacer>().GridX = void_collision.GetComponent<TowerSquare>().GridX;
                    tower.GetComponent<TowerPlacer>().GridY = void_collision.GetComponent<TowerSquare>().GridY;
                    tower_collision.transform.position = VoidTiles.transform.position;
                }
            }

        }

        foreach (GameObject tile in NormalList)
        {
            normal_collision = tile.GetComponent<Collider2D>();
            tower_collision = Tower_Object.GetComponent<Collider2D>();
            void_collision = Void_Object.GetComponent<Collider2D>();
            if (tower_collision.bounds.Intersects(normal_collision.bounds))
            {
                tower_collision.transform.position = new Vector2(-20, -7);
            }
            //if(tetramino_collision.bounds.Intersects(normal_collision.bounds))
            //{
            //    tetramino_collision.transform.position = normal_collision.transform.position;
            //}
        }
        MinionObjects = GameObject.FindGameObjectsWithTag("Minion");
        for (int i2 = 0; i2 < MinionObjects.Length; i2++)
        {
            Minion_Object = MinionObjects[i2];
            Minion_collision = MinionObjects[i2].GetComponent<Collider2D>();

            TetChilds = GameObject.FindGameObjectsWithTag("ChildTet");

            for (int i = 0; i < TetChilds.Length; i++)
            {



                TetChild = TetChilds[i];
                TetChildColl = TetChilds[i].GetComponent<Collider2D>();

                if (Minion_collision.bounds.Intersects(TetChildColl.bounds) && Input.GetMouseButtonUp(0))
                {

                    Minion_collision.transform.position = TetChild.transform.position;
                    Minion_Object.GetComponent<MinionScript>().GridX = TetChild.GetComponent<TileSnapper>().GridX;
                    Minion_Object.GetComponent<MinionScript>().GridY = TetChild.GetComponent<TileSnapper>().GridY;
                    Minion_Object.GetComponent<MinionScript>().IsonGrid = true;

                }
                TetList = GameObject.FindGameObjectsWithTag("Tet");

                for (int i3 = 0; i3 < TetList.Length; i3++)
                {



                    Tet = TetList[i3];
                    TetColl = TetList[i3].GetComponent<Collider2D>();

                    if (Minion_collision.bounds.Intersects(TetColl.bounds) && Input.GetMouseButtonUp(0))
                    {

                        Minion_collision.transform.position = Tet.transform.position;
                        Minion_Object.GetComponent<MinionScript>().GridX = Tet.GetComponent<TileSnapper>().GridX;
                        Minion_Object.GetComponent<MinionScript>().GridY = Tet.GetComponent<TileSnapper>().GridY;
                        Minion_Object.GetComponent<MinionScript>().IsonGrid = true;
                    }

                }
            }
        }
        GridObjects = GameObject.FindGameObjectsWithTag("Grid");
        TetList = GameObject.FindGameObjectsWithTag("Tet");
        for (int i2 = 0; i2 < GridObjects.Length; i2++)
        {
            GameObject Grid_Object = GridObjects[i2];
            Collider2D Grid_collision = GridObjects[i2].GetComponent<Collider2D>();
            for (int i = 0; i < TetList.Length; i++)
            {



                Tet = TetList[i];
                TetColl = TetList[i].GetComponent<Collider2D>();

                if (Grid_collision.bounds.Intersects(TetColl.bounds))
                {


                    Tet.transform.position = Grid_collision.transform.position;


                }

            }
        }






        //foreach (GameObject Tile in TetraminoList)
        //{
        //    tetramino_collision = Tile.GetComponent<Collider2D>();
        //    Minion_collision = Minion_Object.GetComponent<Collider2D>();




        //    if (Minion_collision.bounds.Intersects(tetramino_collision.bounds))
        //    {
        //        Minion_collision.transform.position = tetramino_collision.transform.position;
        //    }

        //}

    }


    }
