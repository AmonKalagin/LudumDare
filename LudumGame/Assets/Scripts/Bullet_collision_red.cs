using UnityEngine;
using System.Collections;

public class Bullet_collision_red : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "RedWall") 
		{
			Debug.Log ("hit red");
		}
	}
}
