using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public bool touchingGround;
	public float sphereRadius = 0.5f;

	public Vector3 bounceVelocity = new Vector3( 0, 10, 0 );
	public Transform[] stuffs;

	// Use this for initialization
	void Start () {
		Function1 ();
	
	}
	
	// Update is called once per frame
	void Update () {

		//this is a comment...

		/* this is a multiline comment
		 Blah Blah Blah Blah*/ 
		touchingGround = IsTouching();
		Debug.Log( IsTouching() );

		if (touchingGround == true) {
			Bounce( bounceVelocity );
				}
	}

void Function1 () {
	Debug.Log( "This is a funtion" );
		float tempVar = 1.1f;
		tempVar = 5.4f;
}

void Bounce ( Vector3 bounceVelocity ) {
		rigidbody.velocity = bounceVelocity;
}

	bool IsTouching (){
		return Physics.Raycast (transform.position, Vector3.down, sphereRadius );
		}
}