using UnityEngine;
using System;


public class TimeController : MonoBehaviour 
{
	void Start() {

	}

	void Update () {		

		GameObject.Find("Time Text").GetComponent<GUIText>().text = "Time: " + TimeManager.Instance.time;

		//print (DateTime.Now.ToString("ss"));
	}


}


