
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	public static AudioManager Instance;

	private void Awake()
	{
		if (Instance != null)
			Destroy(gameObject);
		Instance = this;
	}

	public void PlayClip(AudioClip clip)
	{
		GameObject soundObject = new GameObject();
		AudioSource audioSource = soundObject.AddComponent<AudioSource>();
		audioSource.PlayOneShot(clip);
		//Destroy(soundObject, clip.length);
	}
}