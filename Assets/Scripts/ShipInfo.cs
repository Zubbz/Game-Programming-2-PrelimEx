using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.IO;
using UnityEngine.Analytics;


public class ShipInfo : MonoBehaviour
{
    public Ships ships;

    [Header("Description Headers")] // references the text mesh pro text that is in the description panel

    public TextMeshProUGUI shipName;
    public TextMeshProUGUI shipSize;
    public TextMeshProUGUI tileSize;
    public TextMeshProUGUI hP;

    [Header("Image References")] // references the UI image
    public Image shipImage;
    public void displayUI()
    {
        DisplayShip(ships);
    }
    public void DisplayShip(Ships ship) // displays the info of the ship on the description panel
    {
        shipName.text = "Ship Name: " + ship.shipName;
        shipSize.text = "Ship Size: " + ship.size.ToString();
        tileSize.text = "Tile Size: " + ship.tileSize.ToString();
        hP.text = "HP: " + ship.shipHealthPoints.ToString();
        shipImage.sprite = ship.shipImage;
    }

    public void ClearUI() // clears the text so a new text can load when a button is pressed
    {
        ships = null;
        shipName = null;
        shipSize = null;
        tileSize = null;
        hP = null;
        shipImage = null;
    }


}
