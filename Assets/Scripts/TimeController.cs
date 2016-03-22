using UnityEngine;
using System;
using UnityEngine.UI;


public class TimeController : MonoBehaviour 
{

	public float myCoolTimer = 100;
	public Text timerText;

	void Start() {
		timerText = GetComponent<Text> ();
	}

	void Update () {		
		myCoolTimer -= Time.deltaTime;
		print (myCoolTimer);

		GameObject.Find("Time Text").GetComponent<GUIText>().text = "Time: " + Mathf.Round(myCoolTimer);

		//print (DateTime.Now.ToString("ss"));
	}


}


