using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

    public string playGameLevel;
    public string InstructionScene;

    public void PlayGame()
    {
        Application.LoadLevel(playGameLevel);
    }
    public void QuitGame()
    {
        Application.Quit();
    
	}
    public void Instruction()
    {
        Application.LoadLevel(InstructionScene);
    }
}
