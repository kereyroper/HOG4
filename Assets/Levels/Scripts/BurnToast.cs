using UnityEngine;
using System.Collections;

public class BurnToast : MonoBehaviour {

	void Awake() {
		rigidbody2D.AddForce(new Vector2(-100f, 700f));
	}
}
