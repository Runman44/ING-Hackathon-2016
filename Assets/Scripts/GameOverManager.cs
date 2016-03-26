using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour {

	protected GameOverManager () {}

	Animator anim;
	public GameObject rentepunten;
	public GameObject coinspunten;

	void Awake () {
		anim = GetComponent<Animator> ();
	}

	public void onRestart(){
		if(TimeManager.Instance.time <= 0){
		CoinManager.Instance.creditCount = 0;
		RentepuntManager.Instance.creditCount = 0;
		TimeManager.Instance.time = 100;

		Application.LoadLevel (Application.loadedLevel);
		}
	}

	public void onStop(){
		if(TimeManager.Instance.time <= 0){
		Application.Quit();
		}
	}

	void Update () {
		if (Mathf.Round (TimeManager.Instance.time) <= 0f) {
			anim.SetTrigger ("GameOver");


			GameObject.Find ("Rentepunten").GetComponent<Text>().text = "Packages: " + RentepuntManager.Instance.creditCount;
			GameObject.Find ("CoinsPunten").GetComponent<Text>().text = "Coins: " + CoinManager.Instance.creditCount;
		}
	}
	

}
