using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapData : MonoBehaviour
{
    public int width = 10;
    public int height = 5;

    public int [,] MakeMap()
    {
        int[,] map = new int [width, height];

        for (int y= 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                map[x, y] = 0;
            }

        }
        return map;
    }
    void DisplayMap( int[,] map)
    {

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
               Debug.Log( map[x, y] );
            }

        }
    }
    void Start()
    {
       int [,] mapInstance = MakeMap();
        DisplayMap(mapInstance);
    }
}
