using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FinishLIne : MonoBehaviour
{
	[SerializeField] float loadDelay = 1.0f;
	[SerializeField] ParticleSystem finishEffect;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			finishEffect.Play();
			GetComponent<AudioSource>().Play();
			Invoke("ReloadScene", loadDelay);
		}		
	}

	void ReloadScene()
	{
		SceneManager.LoadScene(0);
	}
}
