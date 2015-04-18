using UnityEngine;
using System.Collections;

public class BulletCollisionBlue : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "BlueWall") 
		{
			Destroy(col.gameObject);
			Destroy(this.gameObject);
		}
	}
}
