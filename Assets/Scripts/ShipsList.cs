using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipsList : MonoBehaviour
{
    public Ships[] ships;
    private string folderPath = "Ship";

    private void Start()
    {
        ships = Resources.LoadAll<Ships>(folderPath);
    }
}
