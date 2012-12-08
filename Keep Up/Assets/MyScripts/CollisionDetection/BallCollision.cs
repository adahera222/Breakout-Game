using UnityEngine;
using System.Collections;

public class BallCollision : MonoBehaviour {
	
	public Transform spawnPoint;
	
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Bounds")
		{
			BallMovement ballMovement = gameObject.GetComponent<BallMovement>();
			Debug.Log("Ball is out of bounds");
			ballMovement.direction = ballMovement.baseDirection;
			gameObject.transform.position = spawnPoint.position;
		}
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
