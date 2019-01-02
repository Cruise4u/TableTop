using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenScript : MonoBehaviour
{

    public GameObject Chosen;
    GameObject GoldToken;
    Vector2 tokenPos;
    public float TokenRollNumber;


    private void OnMouseDown()
    {



        if (GameObject.FindGameObjectsWithTag("Respawn") != null)
        {
            tokenPos.x += 2;
        }


        GoldToken = Instantiate(Chosen, tokenPos, Quaternion.identity);


    }
    void Start()
    {
        Debug.Log(TokenRollNumber);

    }
}
