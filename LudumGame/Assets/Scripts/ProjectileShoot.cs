using UnityEngine;
using System.Collections;

public class ProjectileShoot : MonoBehaviour {

	GameObject prefab;
	void Start () {
		prefab = Resources.Load ("projectile_red") as GameObject;
	}

	void Update () {
	if (Input.GetKeyDown ("[1]")) {
			GameObject projectile_red = Instantiate(prefab) as GameObject;
			projectile_red.transform.position = transform.position + Vector3.up;
			Rigidbody rb = projectile_red.GetComponent<Rigidbody>();
			rb.velocity = (transform.rotation * Vector3.forward) *10;
		}
	}
}
