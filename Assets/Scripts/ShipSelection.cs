using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ShipSelection : MonoBehaviour
{
    public ShipsList shipsList;
    public Transform buttonParentPos;
    public GameObject shipButtonPrefab;
    public TextMeshProUGUI shipsBtnText;
    public ShipInfo shipInfo;
    public GameObject descriptionPanel;
    public GameObject shipImage;

    void Start()
    {
        Debug.Log(shipsList.ships.Count());
        foreach (Ships s in shipsList.ships)
        {
            GameObject buttonPrefab = Instantiate(shipButtonPrefab, buttonParentPos);
            ShipsButton shipsButton = buttonPrefab.GetComponent<ShipsButton>();
            shipsButton.SetShipData(s);
            Button button = buttonPrefab.GetComponent<Button>();
            button.onClick.AddListener(() => shipInfo.DisplayShip(s));
            button.onClick.AddListener(() => descriptionPanel.gameObject.SetActive(true));
            button.onClick.AddListener(() => shipImage.gameObject.SetActive(true));
        }
    }
}
