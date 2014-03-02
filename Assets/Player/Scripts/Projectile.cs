using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	public Sprite ToastSprite;
	public Sprite WaffleSprite;
	public Sprite BagelSprite;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetSprite(ItemType type)
	{
		if (type == ItemType.Bread)
			GetComponent<SpriteRenderer>().sprite = ToastSprite;
		else if (type == ItemType.Waffle)
			GetComponent<SpriteRenderer>().sprite = WaffleSprite;
		else if (type == ItemType.Bagel)
			GetComponent<SpriteRenderer>().sprite = BagelSprite;
		else
			Debug.LogError("Invalid projectile!");
	}
}
