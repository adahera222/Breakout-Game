using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {
	
	/// <summary>
	/// The constant speed of the ball
	/// </summary>
	public float constantSpeed = 0;
	
	/// <summary>
	/// The direction of the ball
	/// </summary>
	public Vector3 direction = new Vector3(0,0,0);
	public Vector3 Direction
	{
		get { return this.direction; }
		set { this.direction = value; }
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.velocity = direction * constantSpeed;
	}
}