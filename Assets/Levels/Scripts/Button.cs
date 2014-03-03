using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour
{

	public Sprite upSprite;
	public Sprite downSprite;
	public GameObject Trigger;

	private bool isDown = false;
	private int colliders = 0; //HACK

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player" || col.gameObject.tag == "Turtle")
		{
			//HACK
			if (col.gameObject.tag == "Turtle")
				colliders++;

			isDown = true;
			GetComponent<SpriteRenderer>().sprite = downSprite;
			Trigger.GetComponent<Vault>().SignalUnlock();
		}
	}

	void OnTriggerExit2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player" || col.gameObject.tag == "Turtle")
		{
			//HACK
			if (col.gameObject.tag == "Turtle")
				colliders--;

			if (colliders == 0)
			{
				isDown = false;
				GetComponent<SpriteRenderer>().sprite = upSprite;
				Trigger.GetComponent<Vault>().SignalLock();
			}
		}
	}
}
