using UnityEngine;
using System.Collections;

public class EdgeCollision : MonoBehaviour {
	private Vector3 bounce = new Vector3(0,0,0);
	
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Ball")
		{
			BallMovement ballMovement = collision.gameObject.GetComponent<BallMovement>();
			bounce = ballMovement.direction;
			if (gameObject.tag == "Roof")
			{
				bounce.y = -ballMovement.direction.y;
			}
			if (gameObject.tag == "Side")
			{
				bounce.x = -ballMovement.direction.x;
			}
			ballMovement.direction = bounce;
		}
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
