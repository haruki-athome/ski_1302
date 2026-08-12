using TMPro;
using UnityEngine;

public class UImanager : MonoBehaviour
{

[SerializeField]
private TMP_Text notiText;
[SerializeField]
private GameObject restartButton;

    [SerializeField]
    private Player player;

	public static UImanager instance;

	private void Awake()
	{
		instance = this;
	}
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowNotitext(string message)
    {
        notiText.text = message;
    }

	public void RestartGame()
	{
        player.transform.position = new Vector3(0f, 86f, -85f);
        player.HP = 100;
        ShowNotitext("Game Restarted");
        Time.timeScale = 1f;
        ShowHideRestartButton(false);

	}

    public void ShowHideRestartButton(bool flag)
	{
		restartButton.SetActive(flag);
	}
}
