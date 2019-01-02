using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Script : MonoBehaviour
{

    public Transform hello;
    public bool IsMouseOverRollButton;

    void OnMouseOver()
    {
      IsMouseOverRollButton = true;

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
