using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
[CreateAssetMenu(fileName = "Ship", menuName = "Scriptable Objects/Ship")]
public class Ships : ScriptableObject
{

    public string shipName; // gives the scriptable  a name
    public Size size; // references the Ship
    public int tileSize;   //references the ShipTypes Script and gets the TileSize enum
    public int shipHealthPoints; // allows the developer to inert an HP for the Scriptable Object
    public Sprite shipImage;  // allows the developer to insert an image of the ship    
}
