using UnityEngine;
using System.Collections;

public class KeyController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter (Collision collision) {
		//collide with player
		if (collision.gameObject.CompareTag ("Player")) 
		{
			PlayerController.keyCount++;
			Destroy(this.gameObject);
		}
	}
}
