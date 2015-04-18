using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {
	public float Lifetime = 0;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, Lifetime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
