using UnityEngine;
using System.Collections;

public class PaddleCollisionDetector : MonoBehaviour {
	public Vector2 bounceRight = new Vector2(1,1);
	public Vector2 bounceLeft = new Vector2(1,1);
	public Vector3 v3 = new Vector3(1,1);
	
	private static Vector3 _bounce = new Vector3(0,0,0);
	
	public static Vector3 Bounce
	{
		get { return _bounce; }
	}
	
	void OnCollisionEnter (Collision collision)
	{
		// Collision.GameObject = Ball
		// Collider.GameObject = Paddle
		
		if (collision.contacts.Length == 1)
		{
			if (collision.contacts[0].point.x > gameObject.transform.position.x)
			{
				Debug.Log("Hit Right Side Of The Paddle");
				_bounce.Set(1,7,0);
			}
			else if (collision.contacts[0].point.x < gameObject.transform.position.x)
			{
				Debug.Log("Hit Left Side Of The Paddle");
				_bounce.Set(-1,7,0);
			}
			else if (collision.contacts[0].point.x == gameObject.transform.position.x)
				Debug.Log("Hit Center Of The Paddle");
		}

	}
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
