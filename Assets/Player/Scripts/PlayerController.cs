/// <summary>
/// Player Controller.
/// By Corey Blackburn
/// 3/1/2014
/// Controls the movement for character.
/// </summary>

using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float speed = 0.5f;
	public float toastLaunchSpeed = 2.1f;
	public Sprite HorizontalSprite;
	public Sprite UpSprite;
	public Sprite DownSprite;
	public GameObject Toast;

	public AudioSource ToasterPop;
	public AudioSource Feet;

	private bool facingRight = true;
	private Vector2 firingDirection = Vector2.zero;
	
	void Start()
	{
		
	}
	
	void Awake()
	{
	}
	
	
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			GetComponent<SpriteRenderer>().sprite = UpSprite;
			firingDirection.x = 0;
			firingDirection.y = 1;
		}
		
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			GetComponent<SpriteRenderer>().sprite = DownSprite;
			firingDirection.x = 0;
			firingDirection.y = -1;
		}
		
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			GetComponent<SpriteRenderer>().sprite = HorizontalSprite;
			if (facingRight) flipSprite();
			firingDirection.x = -1;
			firingDirection.y = 0;
		}
		
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			GetComponent<SpriteRenderer>().sprite = HorizontalSprite;
			if (!facingRight) flipSprite();
			firingDirection.x = 1;
			firingDirection.y = 0;
		}
	}
	
	void FixedUpdate ()
	{
		float horizontalMovement = speed * Input.GetAxis("Horizontal") * Time.deltaTime;
		float verticalMovement = speed * Input.GetAxis("Vertical") * Time.deltaTime;

		if (horizontalMovement != 0 || verticalMovement != 0)
		{
			if (!Feet.isPlaying)
				Feet.Play();
		}
		else
			Feet.Stop();

		Vector3 movement = new Vector3(horizontalMovement, verticalMovement, 0);
		transform.Translate(movement);

		if (Input.GetKeyDown(KeyCode.Space))
		{
			GameObject toast = Instantiate(Toast, Vector3.zero, Quaternion.identity) as GameObject;
			toast.transform.position = transform.position;
			toast.rigidbody2D.velocity = firingDirection * toastLaunchSpeed;
			ToasterPop.Play();
			Destroy(toast, 4); // destroy the toast in 5 seconds.
		}
	}

	void flipSprite()
	{
		facingRight = !facingRight;
		Vector3 myScale = transform.localScale;
		myScale.x *= -1;
		transform.localScale = myScale;
	}
}
