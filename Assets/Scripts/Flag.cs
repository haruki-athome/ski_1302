using UnityEngine;

public class Flag : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		Player p = other.gameObject.GetComponent<Player>();
		if (p == null)
			return;
		p.Point += 10;
		UImanager.instance.ShowNotitext($"You got a flag! +10\nScore: {p.Point}");
		Destroy(gameObject);
	}
}
