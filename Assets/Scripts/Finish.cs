using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
	[SerializeField] private float delayBeforeLoad = 2f;
	private bool hasFinished = false;

	private void OnTriggerEnter(Collider other)
	{
		if (hasFinished) return;

		Player player = other.gameObject.GetComponent<Player>();
		if (player == null)
			return;

		hasFinished = true;
		UImanager.instance.ShowNotitext($"YOU WIN!\nYour Score: {player.Point}");
		AudioManager.instance.PlayWin();

		Invoke(nameof(GoToMainMenu), delayBeforeLoad);
	}

	private void GoToMainMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}
}