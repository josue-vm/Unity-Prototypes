using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// GridController class
/// Generate a grid based on the cam format
/// </summary>

public class GridController : MonoBehaviour
{
    [SerializeField] private int _whith;
    [SerializeField] private int _heigth;
    [SerializeField] private Tiles _tilePrefab;
    [SerializeField] private Transform _cam;

    /// <summary>
    /// genarate the grid at start
    /// </summary>
    void Start()
    {
        GenerateGrid();
    }
    /// <summary>
    /// Generate a grid with _whith lines and _heigth collums and different colors and centrilize it on cammera
    /// </summary>
    public void GenerateGrid()
    {
        for (int x = 0; x < _whith; x++)
        {
            for (int y = 0; y < _heigth; y++)
            {
                var spawnTile = Instantiate(_tilePrefab, new Vector3(x, y), Quaternion.identity);
                spawnTile.name = $"Tile {x} {y}";
                var isOffset = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);
                spawnTile.Init(isOffset);
            }
        }

        _cam.transform.position = new Vector3((float)_whith / 2 - 0.5f, (float)_heigth / 2 - 0.5f, -1);
    }
}