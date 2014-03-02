using UnityEngine;
using System.Collections;


public class TurtleController : MonoBehaviour {

	public GameObject player;
	public float turtleSpeed = 0.02f;
	public Sprite movingSprite;
	public Sprite eatingSprite;
	public float eatingTime = 2.3f;
	public AudioSource TurtleNoises;

	bool eating = false;



	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
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
		// If the alien hits the trigger...
		if (col.gameObject.tag == "Player") {
			Destroy (gameObject);
		} else if (col.gameObject.tag == "Environ") {
			turtleSpeed = 0f;
		}
		else if (col.gameObject.tag == "Toast") {
			GetComponent<SpriteRenderer>().sprite = eatingSprite;
			Destroy(col.gameObject);
			eating = true;
			StartCoroutine( EatBread(eatingTime) );
		}
	}

	IEnumerator EatBread(float delay)
	{
		TurtleNoises.Play ();
		yield return new WaitForSeconds(delay);
		GetComponent<SpriteRenderer>().sprite = movingSprite;
		eating = false;
	}

}