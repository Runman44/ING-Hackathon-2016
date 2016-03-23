using UnityEngine;
using System.Collections;

public class fadeToBlack : MonoBehaviour {



	void OnGUI () {
//		if (Mathf.Round (TimeManager.Instance.time) <= 0f){
			// Make a background box
		GUI.Box (new Rect ((Screen.width / 2 - ((Screen.width / 2) / 2)), Screen.height / 2 - ((Screen.height / 2) /2),Screen.width / 2, Screen.height /2), "Loader Menu");
//		GUI.Box(new Rect(10,10,100,90), "Loader Menu");
			// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
			if (GUI.Button (new Rect (20, 40, 200, 20), "Start The Game")) {
				Application.LoadLevel (1);
			}

			// Make the second button.
			if (GUI.Button (new Rect (20, 70, 200, 20), "Quit?")) {
				Application.Quit ();
			}
//		}
	}
}
