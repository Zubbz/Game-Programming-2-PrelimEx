using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShipsButton : MonoBehaviour
{
    [Header("Button Text Reference")]
    public TextMeshProUGUI shipsBtnNameText; // allows the developer tor eference the text of the button

    public void SetShipData(Ships tships) // tShips stands for type of ship
    {
        shipsBtnNameText.text = tships.shipName; // displays the name of the ship in the text of the button
    }
    public void Quit()
    {
        Application.Quit(); // exits the game
    }
}
