using UnityEngine;
using System.Collections;

public class BrickCollision : MonoBehaviour {
	private Vector3 bounce = new Vector3(0,0,0);
	
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Ball")
		{
			BallMovement ballMovement = collision.gameObject.GetComponent<BallMovement>();
			bounce = ballMovement.direction;
			
			// If collision hit the top of the boxcollider
//			if (collision.contacts[0].normal == gameObject.transform.up)
//				Debug.Log("Hit the bottom of the boxcollider");
//			else if (collision.contacts[0].normal == -gameObject.transform.up)
//				Debug.Log("Hit the top of the boxcollider");
//			else if (collision.contacts[0].normal == gameObject.transform.right)
//				Debug.Log("Hit the left side of the boxcollider");
//			else if (collision.contacts[0].normal == -gameObject.transform.right)
//				Debug.Log("Hit the right side of the boxcollider");
			
			if (collision.contacts[0].normal == gameObject.transform.up || collision.contacts[0].normal == -gameObject.transform.up)
			{
				Debug.Log("Hit top or bottom");
				bounce.y = -bounce.y;
			}
			else if (collision.contacts[0].normal == gameObject.transform.right || collision.contacts[0].normal == -gameObject.transform.right)
			{
				Debug.Log("Hit right or left side");
				bounce.x = -bounce.x;
			}
			ballMovement.direction = bounce;
			Destroy(gameObject);
		}
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
