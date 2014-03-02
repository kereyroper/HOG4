using UnityEngine;
using System.Collections;

public class TurtleController : MonoBehaviour {

	public float turtleSpeed = 0.02f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (-turtleSpeed, -turtleSpeed, 0);
	}
	void onCollisionEnter(Collision collision) {
	}	
}