using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{

	public void LoadHalligan()
	{
		SceneManager.LoadScene("arhalligan");
	}

	public void LoadCannon()
	{
        SceneManager.LoadScene("arcannon");
	}

    public void LoadSEC()
    {
        SceneManager.LoadScene("arsec");
    }

    public void LoadTisch()
    {
        SceneManager.LoadScene("artisch");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("menu");
	}
}
