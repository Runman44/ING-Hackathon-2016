using UnityEngine;
using System.Collections;

public class RentePuntenController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject.Find ("RentePunten Text").GetComponent<GUIText> ().text = "Packages: " + RentepuntManager.Instance.creditCount;
	}
}
