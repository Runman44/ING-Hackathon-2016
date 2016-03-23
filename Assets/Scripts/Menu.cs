using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public void loadMenu(int item) {
		Application.LoadLevel (item);
}

	public void Quit() {
		Application.Quit();
	}
}
