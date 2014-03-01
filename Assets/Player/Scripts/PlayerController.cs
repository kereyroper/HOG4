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
	enum FACING
	{
		UP, RIGHT, DOWN, LEFT
	};

	public float speed = 0.5f;
	public float toastLaunchSpeed = 2.1f;
	public GameObject Toast;

	private FACING facing = FACING.UP;
	
	void Start()
	{
		
	}
	
	void Awake()
	{
	}
	
	
	void Update()
	{
	}
	
	void FixedUpdate ()
	{
		float horinzontalMovement = speed * Input.GetAxis("Horizontal") * Time.deltaTime;
		float verticallMovement = speed * Input.GetAxis("Vertical") * Time.deltaTime;

		if (Mathf.Abs(horinzontalMovement) > Mathf.Abs(verticallMovement))
		{
			if (horinzontalMovement > 0)
				facing = FACING.RIGHT;
			else
				facing = FACING.LEFT;
		}
		else
		{
			if (verticallMovement > 0)
				facing = FACING.DOWN;
			else
				facing = FACING.UP;
		}

		Vector3 movement = new Vector3(horinzontalMovement, verticallMovement, 0);
		transform.Translate(movement);

		if (Input.GetKeyDown(KeyCode.Space))
		{
			GameObject toast = Instantiate(Toast, Vector3.zero, Quaternion.identity) as GameObject;
			toast.transform.position = transform.position;

			Vector2 firingDirection = Vector2.zero;

			switch(facing)
			{
			case FACING.UP:
				firingDirection.x = 0;
				firingDirection.y = -1;
				break;
			case FACING.RIGHT:
				firingDirection.x = 1;
				firingDirection.y = 0;
				break;
			case FACING.DOWN:
				firingDirection.x = 0;
				firingDirection.y = 1;
				break;
			case FACING.LEFT:
				firingDirection.x = -1;
				firingDirection.y = 0;
				break;
			default:
				Debug.LogError("Invalid facing direction!");
				break;
			};

			toast.rigidbody2D.velocity = firingDirection * toastLaunchSpeed;
			Destroy(toast, 5); // destroy the toast in 5 seconds.
		}
	}
}
