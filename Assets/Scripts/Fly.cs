using UnityEngine;
using System.Collections;

public class Fly : MonoBehaviour {

	public float speed = 1f;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
	
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = Vector3.forward * moveVertical;

		rb.AddForce (movement * speed);
	}
}
