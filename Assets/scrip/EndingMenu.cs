using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingMenu : MonoBehaviour {

    public string playGameLevel;
    public string mainMenuLevel;

    public void PlayGame()
    {
        Application.LoadLevel(playGameLevel);
    }
    public void QuitGame()
    {
        Application.LoadLevel(mainMenuLevel);

    }
}
