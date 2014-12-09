using UnityEngine;
using System.Collections;

/*
 * Used for the keys in the maze
 * checks each update to rotate the key to be facing the player because the key is a 2d sprite 
 * and rotating it makes it possible to see from the FPS camera controller at all times.
 * 
 * There is a method to destroy the key which is called when the player collides with the key
 */

public class key : MonoBehaviour {

    GameObject fpsController;

	// Use this for initialization
	void Start () {
        fpsController = GameObject.Find("Main Camera/First Person Controller");
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(fpsController.transform.position);
	
	}

    public void destroyKey()
    {
        Destroy(gameObject);
    }


}
