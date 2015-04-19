using UnityEngine;
using System.Collections;

public class ProjectileShoot : MonoBehaviour {

	GameObject prefab;
	GameObject prefab2;
	void Start () {
		prefab = Resources.Load ("projectile_red") as GameObject;
		prefab2 = Resources.Load ("projectile_blue") as GameObject;
	}

	void Update () {
		if (Input.GetKeyDown ("[1]")) {
			if (GetComponent<AmmunitionController> ().getRedAmmo () > 0) {
			
				GameObject projectile_red = Instantiate (prefab) as GameObject;
				projectile_red.transform.rotation = transform.rotation;
				projectile_red.transform.position = transform.position + Vector3.up;
				Rigidbody rb = projectile_red.GetComponent<Rigidbody> ();
				rb.velocity = (transform.rotation * Vector3.forward) * 10;
				GetComponent<AmmunitionController>().decreaseRedAmmo();
			}
		}
		if (Input.GetKeyDown ("[2]")) {
			if (GetComponent<AmmunitionController> ().getBlueAmmo () > 0) {
				GameObject projectile_blue = Instantiate (prefab2) as GameObject;
				projectile_blue.transform.rotation = transform.rotation;
				projectile_blue.transform.position = transform.position + Vector3.up;
				Rigidbody rb = projectile_blue.GetComponent<Rigidbody> ();
				rb.velocity = (transform.rotation * Vector3.forward) * 10;
				GetComponent<AmmunitionController>().decreaseBlueAmmo();
			}
		}
	}
}
