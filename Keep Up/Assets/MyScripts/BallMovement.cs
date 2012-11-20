using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {
	
	public float constantSpeed = 0;
	public Vector3 direction = new Vector3(0,0,0);
	
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			direction = PaddleCollisionDetector.Bounce;
		}
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.velocity = direction * constantSpeed;
	}
}