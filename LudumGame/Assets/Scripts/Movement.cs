using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float moveSpeed;
	private float maxSpeed = 7f;

	private Vector3 input;

	
	void Start () 
	{
	
	}

	void Update () 
	{
		input = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (input), Time.deltaTime * 10f);
//		transform.Translate (input * moveSpeed *Time.deltaTime, Space.World);
//		if (transform.localRotation.y < 0.7) 
//		{
//			if (Input.GetAxisRaw ("Horizontal") > 0) 
//			{ 
//				transform.Rotate (Vector3.up, 100 * Time.deltaTime);
//
//			}
//		}
//		if (transform.localRotation.y > -0.7) 
//		{
//			if (Input.GetAxisRaw ("Horizontal") < 0) 
//			{ 
//				transform.Rotate (Vector3.down, 100 * Time.deltaTime);
//				
//			}
//		}
//			
//		if (transform.localRotation.y > 0) 
//		{
//			if (Input.GetAxisRaw ("Vertical") > 0) 
//			{ 
//				transform.Rotate (Vector3.down, 100 * Time.deltaTime);
//				Debug.Log ("y" + transform.localRotation.y);
//				Debug.Log ("x" + transform.localRotation.x);
//				Debug.Log ("z" + transform.localRotation.z);
//				
//			}
//		}
//		if (transform.localRotation.y < 0) 
//		{
//			if (Input.GetAxisRaw ("Vertical") > 0) 
//			{ 
//				transform.Rotate (Vector3.down, -100 * Time.deltaTime);
//				Debug.Log ("y" + transform.localRotation.y);
//				Debug.Log ("x" + transform.localRotation.x);
//				Debug.Log ("z" + transform.localRotation.z);
//				
//			}
//		}
//		if (transform.localRotation.y < 0) 
//		{
//			if (Input.GetAxisRaw ("Vertical") < 0) 
//			{ 
//				transform.Rotate (Vector3.down, 100 * Time.deltaTime);
//
//				Debug.Log ("y" + transform.localRotation.y);
//				Debug.Log ("x" + transform.localRotation.x);
//				Debug.Log ("z" + transform.localRotation.z);
//			}
//		}


		if(GetComponent<Rigidbody>().velocity.magnitude < maxSpeed)
		{

			GetComponent<Rigidbody>().AddForce(input * moveSpeed);
		}


	}
}