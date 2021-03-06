﻿using UnityEngine;
using System.Collections;


public class TurtleController : MonoBehaviour {

	public GameObject player;
	public float turtleSpeed;
	public Sprite movingSprite;
	public Sprite eatingSprite;
	public float eatingTime;
	public AudioSource TurtleNoises;

	bool eating = false;



	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame

	// TODO: when turtle hits a block, stays there forever. Need to check if targetDirection
	// vector changes, and if turtle can now move towards player, should move again.
	void Update (){
		if (!eating)
		{
			Vector3 targetDirection = player.transform.position - transform.position;
			if (Vector3.Distance (transform.position, player.transform.position) >= 0.2) {
				transform.position += targetDirection * turtleSpeed * Time.deltaTime;
			}
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Environ") { 
			turtleSpeed = 0.0f;
		}
		else if (col.gameObject.tag == "Toast") {
			GetComponent<SpriteRenderer>().sprite = eatingSprite;
			Destroy(col.gameObject);
			eating = true;
			StartCoroutine( EatBread(eatingTime) );
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Player")
		{
			Application.LoadLevel("game_over");
		} 
	}

	IEnumerator EatBread(float delay)
	{
		TurtleNoises.Play ();
		yield return new WaitForSeconds(delay);
		GetComponent<SpriteRenderer>().sprite = movingSprite;
		eating = false;
	}

	void showMessageBubble()
	{
		transform.GetChild(0).gameObject.SetActive(true);
	}

	void hideMessageBubble()
	{
		transform.GetChild(0).gameObject.SetActive(false);
	}

}