using UnityEngine;
using System;
using UnityEngine.UI;


public class TimeController : MonoBehaviour 
{

	public Text timerText;

	void Start() {
		
	}

	void Update () {
		
		TimeManager.Instance.time -= Time.deltaTime;

		GameObject.Find("Time Text").GetComponent<GUIText>().text = "Time: " + Mathf.Round(TimeManager.Instance.time);
	}


}


