using UnityEngine;
using System.Collections;

public class ProjectileShoot : MonoBehaviour {

	GameObject prefab;
	void Start () {
		prefab = Resources.Load ("projectile") as GameObject;
	}

	void Update () {
	if (Input.GetKeyDown ("space")) {
			GameObject projectile = Instantiate(prefab) as GameObject;
			projectile.transform.position = transform.position *2;
			Rigidbody rb = projectile.GetComponent<Rigidbody>();
			rb.velocity = Camera.main.transform.forward*1;
		}
	}
}
