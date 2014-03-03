using UnityEngine;
using System.Collections;

public class Vault : MonoBehaviour
{
	public Sprite LockedSprite;
	public Sprite UnlockedSprite;
	public bool locked = true;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void Signal()
	{
		locked = !locked;

		if (locked == true)
		{
			GetComponent<SpriteRenderer>().sprite = LockedSprite;
			GetComponent<Door>().isLocked = true;
		}
		else
		{
			GetComponent<SpriteRenderer>().sprite= UnlockedSprite;
			GetComponent<Door>().isLocked = false;
		}
	}

}
