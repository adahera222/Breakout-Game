using UnityEngine;
using System.Collections;

public class BallCollision : MonoBehaviour {
	
	public Transform spawnPoint;
	
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Bounds")
		{
			Debug.Log("Ball is out of bounds");
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
