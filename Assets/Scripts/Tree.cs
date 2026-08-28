using UnityEngine;

public class Tree : MonoBehaviour

{
	private MeshRenderer rd;

	void Start()
	{
		rd = GetComponent<MeshRenderer>();
	}

	void Update()
	{

	}

	private void OnCollisionEnter(Collision collision)
	{
		rd.material.color = Color.red;
		Player player = collision.gameObject.GetComponent<Player>();

		if (player == null)
			return;

		AudioManager.instance.PlayTreeHit();

		player.HP -= 15;

		UImanager.instance.ShowNotitext($"AUGH IT SO HURT! -15\nHP: {player.HP}");

		if (player.HP <= 0)
		{
			player.HP = 0;
			UImanager.instance.ShowNotitext($"YOU DIED!\nYour Score: {player.Point}");
			Time.timeScale = 0f;
			UImanager.instance.ShowHideRestartButton(true);
		}
	}

	private void OnCollisionExit(Collision collision)
	{
		rd.material.color = new Color32(115, 73, 37, 255);
	}
}