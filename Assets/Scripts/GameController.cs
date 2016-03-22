using UnityEngine;
using System;


public class GameController : MonoBehaviour 
{
	public GameController ()
	{}

	void Update () {		
		TimeManager.Instance.time = TimeManager.Instance.time - 1;
	}


}


