using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//TODO: link to player here
	}
	
	void OnTriggerEnter2D(Collider2D other) {
		// TODO: Check if player
		// Add item to player inventory if not full for this item
	}
}
