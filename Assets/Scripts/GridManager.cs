using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int _width, _height;

    [SerializeField] private Tile _tilePrefab;

    void GeneratesGrid()
    {
        for (int wdth = 0; wdth < _width; wdth++)
        {
            for (int hght = 0; hght < _height; hght++)
            {

            }
        }
    }
}
