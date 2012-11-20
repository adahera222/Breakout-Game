using UnityEngine;
using System.Collections;

public class PaddleCollisionDetector : MonoBehaviour {
	// The different bounce directions
	public Vector3 bounceRight = new Vector3(1,1,0);
	public Vector3 bounceLeft = new Vector3(-1,1,0);
	public Vector3 bounceCenter = new Vector3(0,1,0);
	
	void OnCollisionEnter (Collision collision)
	{
		// Collision.GameObject = Ball
		// Collider.GameObject = Paddle
		
		if (collision.gameObject.tag == "Ball")
		{
			BallMovement ballMovement = collision.gameObject.GetComponent<BallMovement>();
			if (collision.contacts[0].point.x > gameObject.transform.position.x)
			{
				Debug.Log("Hit Right Side Of The Paddle");
				ballMovement.Direction = bounceRight;
				
			}
			else if (collision.contacts[0].point.x < gameObject.transform.position.x)
			{
				Debug.Log("Hit Left Side Of The Paddle");
				ballMovement.Direction = bounceLeft;
			}
			else if (collision.contacts[0].point.x == gameObject.transform.position.x)
			{
				Debug.Log("Hit Center Of The Paddle");
				
				ballMovement.Direction = bounceCenter;
			}
		}

	}
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
