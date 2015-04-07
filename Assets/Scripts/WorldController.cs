using UnityEngine;
using System.Collections;

public class WorldController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(PlayerController.isDead){

		}
	}
	
	void showScore(){
		Rect textArea = new Rect (0,0,Screen.width,Screen.height);
		GUI.Label (textArea, "KeyCount: "+ PlayerController.keyCount );
	}
		
	//GUI text
	void OnGUI(){
		showScore ();
	}
}
