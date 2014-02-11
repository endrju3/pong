using UnityEngine;
using System.Collections;

public class EnergyControl : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds(2);
		GoBall ();
	}

	IEnumerator ResetBall()
	{
		rigidbody2D.velocity = new Vector2 (0, 0);
		transform.position = new Vector2 (0, 0);
		yield return new WaitForSeconds (0.5f);
		GoBall ();
	}

	void GoBall()
	{
		int randomNumber = Random.Range (0, 2);
		if (randomNumber <= 0.5)
		{
			rigidbody2D.AddForce(new Vector2(80, 20));
		} 
		else
		{
			rigidbody2D.AddForce(new Vector2(80, -20));
		}
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D collInfo) {

		if (collInfo.collider.tag == "Player")
		{
			float velY = rigidbody2D.velocity.y;
			velY = velY + collInfo.collider.rigidbody2D.velocity.y/3;
			rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, velY);
		}

		if (collInfo.collider.name == "rightWall")
		{
			ScoreController.Score("rightWall");
		}
	}
}
