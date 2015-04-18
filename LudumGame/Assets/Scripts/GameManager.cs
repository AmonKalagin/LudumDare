using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static int currentLevel = 0;
	public static int unlockedLevel;
	
	void Start () {
	
	}
	

	void Update () {
	
	}
	public static void CompleteLevel() {

		Application.LoadLevel(currentLevel + 1);

	}
}
