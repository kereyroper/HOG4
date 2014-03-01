using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//TODO: link to player here
	}
	
	void OnTriggerEnter(Collider other) { //TODO: maybe Collider2D?
		// TODO: Check if player
		// Add item to player inventory if not full for this item
	}
}
