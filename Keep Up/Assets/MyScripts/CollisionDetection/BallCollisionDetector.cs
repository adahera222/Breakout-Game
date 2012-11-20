using UnityEngine;
using System.Collections;

public class BallCollisionDetector : MonoBehaviour {
	
	void OnCollisionEnter (Collision collision)
	{
		// Collision.GameObject = Paddle
		// Collider.GameObject = Ball
		
		if (collision.contacts.Length == 1)
		{
			if (gameObject.transform.position.x > collision.contacts[0].point.x)
			{
				Debug.Log("Hit Right Side Of The Paddle");
			}
			else if (collision.contacts[0].point.x < gameObject.transform.position.x)
			{
				Debug.Log("Hit Left Side Of The Paddle");
			}
			//else if (collision.contacts[0].point.x == gameObject.transform.position.x)
				//Debug.Log("Hit Center of the Paddle");
		}

	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
