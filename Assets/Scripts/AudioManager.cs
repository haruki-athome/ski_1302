using UnityEngine;

public class AudioManager : MonoBehaviour
{
	public static AudioManager instance;

	[SerializeField] private AudioSource ambientSource;
	[SerializeField] private AudioClip ambientClip;

	[SerializeField] private AudioSource sfxSource; // for one-shot sounds
	[SerializeField] private AudioClip coinClip;
	[SerializeField] private AudioClip treeHitClip;
	[SerializeField] private AudioClip winClip;

	void Awake()
	{
		if (instance != null)
		{
			Destroy(gameObject); 
			return;
		}
		instance = this;
		DontDestroyOnLoad(gameObject); 

		ambientSource.clip = ambientClip;
		ambientSource.loop = true;
		ambientSource.Play();
	}

	public void PlayCoin() => sfxSource.PlayOneShot(coinClip);
	public void PlayTreeHit() => sfxSource.PlayOneShot(treeHitClip);
	public void PlayWin() => sfxSource.PlayOneShot(winClip);
}