using UnityEngine;
using System.Collections;

/*
Each block in the maze is stored as an instance of this cell class.
this makes it easier to store cell specific information such as the current status of
the cell and the randomly assigned weight.

There is also a method in here to set the color of the cell to white
*/

public class cell : MonoBehaviour {

   int weight;

   int status; // 0 = not checked
                // 1 = frontier
                // 2 = path
                // 3 = wall

	// Use this for initialization
	public void Start () {

        weight = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void changeColorWhite() { this.renderer.material.color = Color.white; }

    public void setStatus(int _status) { status = _status; }
    public int getStatus() { return status; }

    public void setWeight(int _weight) { weight = _weight; }
    public int getWeight() { return weight; }
}
