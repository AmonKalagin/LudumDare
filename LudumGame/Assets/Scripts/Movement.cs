using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float moveSpeed;
	private float maxSpeed = 7f;
	public GameObject SpawnParticle;
	private Vector3 input;

	private Vector3 spawn;
	
	void Start () 
	{
		Instantiate(SpawnParticle, transform.position, Quaternion.Euler(270,0,0));
	}

	void Update () 
	{
		input = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (input), Time.deltaTime * 10f);

		if(GetComponent<Rigidbody>().velocity.magnitude < maxSpeed)
		{

			GetComponent<Rigidbody>().AddForce(input * moveSpeed);
		}
		if (transform.position.y < -2) 		
		{
			Die ();

		}

	}
	void Die()
	{
		int level = GameManager.currentLevel;
		Application.LoadLevel(level);

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag == "Goal")
		{
			GameManager.CompleteLevel();
		}
}
}