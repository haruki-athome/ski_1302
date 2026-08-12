using UnityEngine;

public class Finish : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
	{
		Player player = other.gameObject.GetComponent<Player>();
		if (player == null)
			return;
		UImanager.instance.ShowNotitext($"YOU WIN!\nYour Score: {player.Point}");
	}
}
