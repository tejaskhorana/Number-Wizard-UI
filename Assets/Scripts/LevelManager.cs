using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void callLevel (string name) {
		Application.LoadLevel(name);
	}

	public void quitGame (string name) {
		Application.Quit();
	}
}
