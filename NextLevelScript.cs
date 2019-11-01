using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class NextLevelScript : MonoBehaviour
{
    public Button NextButton;

    public void NextLevel()
    {
        if (trackstatic.gameCompStatus == "You Failed")
        {
            NextButton.interactable = false;
            NextButton.gameObject.SetActive(false);
        }
        else if (trackstatic.gameCompStatus == "CompleteLevel")
        {
            NextButton.interactable = true;
            NextButton.gameObject.SetActive(true);
            
            SceneManager.LoadScene("Level2");
            PlayerPrefs.SetInt("CoinsTotal", trackstatic.coinsTotal);
        }
    }
}
