using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShipsButton : MonoBehaviour
{
    [Header("Button Text Reference")]
    public TextMeshProUGUI shipsBtnNameText; // allows the developer tor eference the text of the button

    [Header("Main Menu Reference")]
    public GameObject pauseMenuPanel;   // references the in game pause menu

    public void SetShipData(Ships tships) // tShips stands for type of ship
    {
        shipsBtnNameText.text = tships.shipName; // displays the name of the ship in the text of the button
    }
    public void Quit()
    {
        Application.Quit(); // exits the game
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("InGame");
    }

    public void GoToMainMenu()
    {
        pauseMenuPanel.SetActive(false);
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseMenuPanel.SetActive(true);
    }

    public void ResumeGame()
    {
        pauseMenuPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void RestartGame()
    {
        pauseMenuPanel.SetActive(false);
        Time.timeScale = 1;
    }
}
