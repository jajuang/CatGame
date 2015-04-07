using UnityEngine;
using System.Collections;

public class DoorContoller : MonoBehaviour {
	
	public static KeyCode INTERACT_BTN = PlayerController.INTERACT_BTN;

	// Use this for initialization
	void Start () {	
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnCollisionStay (Collision collision) {
		//collide with player and player interacts with
		if (collision.gameObject.CompareTag("Player")) 
		{
			if(Input.GetKeyDown(KeyCode.X)){
				if (PlayerController.keyCount > 0) 
				{
					PlayerController.keyCount--;
					Destroy(this.gameObject);
				} else {
					Debug.Log("You need a key!");
				}
			}
		}
	}
}
