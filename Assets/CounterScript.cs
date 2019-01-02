using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CounterScript : MonoBehaviour {

    // Check Static if not work
    public float counterValue = 0;
    TextMesh counter;
    public float NumberChange;


	// Use this for initialization
	void Start () {
        counter = GetComponent<TextMesh> ();
        NumberChange = 0;

}
	
	// Update is called once per frame
	void Update () {
		if (NumberChange != 0)
        {
            counterValue= counterValue + NumberChange;
            Debug.Log("Counter");
       

            if (counterValue < 0)
            {
                counterValue = 0;
            }
            NumberChange = 0;
        }
        counter.text = counterValue.ToString();
	}
}
