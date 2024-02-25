using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShipsButton : MonoBehaviour
{
    [Header("Button Text Reference")]
    public TextMeshProUGUI shipsBtnNameText;

    public void SetShipData(Ships tships) // tShips stands for type of ship
    {
        shipsBtnNameText.text = tships.shipName;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
