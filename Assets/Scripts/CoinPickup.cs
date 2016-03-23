using UnityEngine;
using System.Collections;
using Endless2DTerrain;

public class CoinPickup : MonoBehaviour {

	void Start(){
		GameObject.Find("Score Text").GetComponent<GUIText>().text = "Coins: 0";
	}

	void OnTriggerEnter(Collider item)
	{
		//Assume only one terrain displayer at a time
		var terrainDisplayer = GameObject.FindObjectOfType(typeof(TerrainDisplayer)) as TerrainDisplayer;        
		if (terrainDisplayer != null && terrainDisplayer.PrefabManager != null && terrainDisplayer.PrefabManager.Pool != null)
		{
			terrainDisplayer.PrefabManager.Pool.Remove(this.gameObject);

			CoinManager.Instance.creditCount = CoinManager.Instance.creditCount + 1;
			updateScore();
			Debug.Log ("crash2222");
		}
	}

	public void updateScore() {
		GameObject.Find("Score Text").GetComponent<GUIText>().text = "Coins: " + CoinManager.Instance.creditCount;

		TimeManager.Instance.time = TimeManager.Instance.time + 1;

		//GameObject.Find ("Time Text").GetComponent<GUIText> ().text = "Time: " + TimeManager.Instance.time;
	}
}
