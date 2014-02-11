using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour {

	public KeyCode moveUp;
	public KeyCode moveDown;

	public float speed = 10;

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (moveUp))
		{
			rigidbody2D.velocity = new Vector2(0, speed);
		} 
		else if (Input.GetKey (moveDown))
		{
			rigidbody2D.velocity = new Vector2(0, -speed);
		}
		else 
		{
			rigidbody2D.velocity = new Vector2(0, 0);
		}


	}
}
