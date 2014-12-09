using UnityEngine;
using System.Collections;
/*
 * Simple script to control the TextGUI that is counting how many new panels
 * the player has stepped on.
 * 
 * Has a method to update the value that is being displayed to the screen.
 * This method is called each time the player steps on a new panel
 */

public class panelsSteppedOn : MonoBehaviour {

    GUIText PanelsSteppedOn;

	// Use this for initialization
	void Start () {

        PanelsSteppedOn = GetComponent<GUIText>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void setText(int num)
    {
        PanelsSteppedOn.text = "Panels to Spend: " + num;
    }
    
}
