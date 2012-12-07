using UnityEngine;
using System.Collections;

public class PaddleCollisionDetector : MonoBehaviour {
	// The different bounce directions
	public Vector3 bounceRight = new Vector3(1,1,0);
	public Vector3 bounceLeft = new Vector3(-1,1,0);
	public Vector3 bounceCenter = new Vector3(0,1,0);
	public Vector3 bounce = new Vector3(0,1,0);
	float distance;

	void OnCollisionEnter (Collision collision)
	{
		// Collision.GameObject = Ball
		// Collider.GameObject = Paddle
		
		if (collision.gameObject.tag == "Ball")
		{
			BallMovement ballMovement = collision.gameObject.GetComponent<BallMovement>();
			//bounce = ballMovement.Direction;
			if (collision.contacts[0].point.x != gameObject.transform.position.x)
			{
				bounce.x = collision.contacts[0].point.x - gameObject.transform.position.x;
				
				ballMovement.Direction = bounce;
			}
			
//			if (collision.contacts[0].point.x > gameObject.transform.position.x)
//			{
//				//Debug.Log("Hit Right Side Of The Paddle");
//				distance = collision.contacts[0].point.x - gameObject.transform.position.x;
//				bounceRight.x = distance;
//				ballMovement.Direction = bounceRight;
//				
//			}
//			else if (collision.contacts[0].point.x < gameObject.transform.position.x)
//			{
//				//Debug.Log("Hit Left Side Of The Paddle");
//				distance = gameObject.transform.position.x - collision.contacts[0].point.x;
//				bounceLeft.x = distance;
//				ballMovement.Direction = bounceLeft;
//			}
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
