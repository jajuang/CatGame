using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WorldController : MonoBehaviour {
	
	public Text keyCountText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(PlayerController.isDead){

		}
	}
	
	void keyCount(){
		keyCountText.text = "x "+ PlayerController.keyCount.ToString();
	}
		
	//GUI text
	void OnGUI(){
		keyCount ();
	}
}
