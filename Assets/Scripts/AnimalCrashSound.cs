using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class AnimalCrashSound : MonoBehaviour {
	public AudioClip impact;
	AudioSource audio;

	void Start() {
		audio = GetComponent<AudioSource>();
		audio.PlayOneShot(impact, 0.7F);
	}

	void OnCollisionEnter() {
		audio.PlayOneShot(impact, 0.7F);
	}
}