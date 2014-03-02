using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour
{

	public Sprite upSprite;
	public Sprite downSprite;

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
		if (col.gameObject.tag == "Player" || col.gameObject.tag == "Turttle")
		{
			GetComponent<SpriteRenderer>().sprite = downSprite;
		}
	}

	void OnTriggerExit2D(Collider2D col)
	{
		GetComponent<SpriteRenderer>().sprite = upSprite;
	}
}
