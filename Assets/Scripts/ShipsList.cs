using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipsList : MonoBehaviour
{
    public Ships[] ships; // references the Ship script to access the scriptable objects
    private string folderPath = "Ship";

    private void Start()
    {
        ships = Resources.LoadAll<Ships>(folderPath); // loads all the created scriptable objects
    }
}
