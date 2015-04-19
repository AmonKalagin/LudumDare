using UnityEngine;
using System.Collections;

public class AmmunitionController : MonoBehaviour {
	private int redAmmoCount = 0;
	private int blueAmmoCount = 0;


	

	void Start () {
	
	}
	

	void Update () {
	
	}
	void OnTriggerEnter(Collider col) 
	{
		if (col.gameObject.tag == "RedAmmo") 
		{
			redAmmoCount++;
			Destroy (col.gameObject);
		}
		else if (col.gameObject.tag == "BlueAmmo") 
		{
			blueAmmoCount++;
			Destroy (col.gameObject);
		}
	}
	public void decreaseRedAmmo()
	{
		redAmmoCount--;
	}
	public int getRedAmmo()
	{
		return redAmmoCount;
	}
	public void decreaseBlueAmmo()
	{
		blueAmmoCount--;
	}
	public int getBlueAmmo()
	{
		return blueAmmoCount;
	}
}
