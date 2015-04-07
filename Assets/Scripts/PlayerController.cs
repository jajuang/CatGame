using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public int health;
	public static int keyCount = 0;
	public static KeyCode INTERACT_BTN = KeyCode.X;
	public static bool isDead = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	void OnCollisionEnter (Collision collision){
		if (collision.gameObject.CompareTag ("Death")) {
			Destroy(this.gameObject);
		}
	}
}
