using UnityEngine;
using System;
using UnityEngine.UI;
using RestSharp;
using System.Collections;
using System.Net;
using System.Collections.Generic;
using UnityEngine.Experimental.Networking;


public class TimeController : MonoBehaviour 
{

	public Text timerText;

	void Start() {
	}

	void Update () {
		
		TimeManager.Instance.time -= Time.deltaTime;

		if (Mathf.Round (TimeManager.Instance.time) > -1f) {
			GameObject.Find ("Time Text").GetComponent<GUIText> ().text = "Time: " + Mathf.Round (TimeManager.Instance.time);
		}
	}


}


