using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildButton : MonoBehaviour
{

    public Transform hello;
    public bool IsMouseOverRollButton;

    void OnMouseOver()
    {
        IsMouseOverRollButton = true;
        Debug.Log("MouseIs");
    }
    void OnMouseExit()
    {
        IsMouseOverRollButton = false;
    }

    public void ButtonisClicked(string Hello)
    {
        Debug.Log(Hello);
    }


    void Start()
    {
        IsMouseOverRollButton = false;
    }


    void Update()
    {

    }
}