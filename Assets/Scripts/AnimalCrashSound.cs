using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class AnimalCrashSound : MonoBehaviour {
	public AudioClip impact;
	AudioSource audio;

	void Start() {
		audio = GetComponent<AudioSource>();
	}
	void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log ("crash");
		audio.PlayOneShot(impact, 0.7F);
	}
}