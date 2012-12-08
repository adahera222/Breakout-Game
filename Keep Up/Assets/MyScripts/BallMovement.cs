using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {
	
	/// <summary>
	/// The constant speed of the ball
	/// </summary>
	public float constantSpeed;
	private float speed;
	
	/// <summary>
	/// The direction of the ball
	/// </summary>
	public Vector3 direction = new Vector3(0,-5,0);
	public Vector3 Direction
	{
		get { return this.direction; }
		set { this.direction = value; }
	}
	
	void OnCollisionEnter()
	{
		speed += 0.1f;
	}
	
	// Use this for initialization
	void Start () {
		speed = constantSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.velocity = direction * speed;
	}
}