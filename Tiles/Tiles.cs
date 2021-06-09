using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class tiles
/// Define and set the Tiles features
/// </summary>

public class Tiles : MonoBehaviour
{
    [SerializeField] private Color _baseColor;
    [SerializeField] private Color _offsetColor;
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private GameObject _highLight;

    /// <summary>
    /// Defines if the tile have a offset color or base color
    /// </summary>
    /// <param name="isOffset"> if true the tile color is a offset color </param>

    public void Init(bool isOffset)
    {
        if (isOffset)
        {
            _renderer.material.color = _offsetColor;
        }
        else
        {
            _renderer.material.color = _baseColor;
        }
    }

    /// <summary>
    /// if the mouse is in the tile sets highlight to true
    /// </summary>
    void OnMouseEnter()
    {
        _highLight.SetActive(true);
    }

    /// <summary>
    /// f the mouse is in the tile sets highlight to false
    /// </summary>
    void OnMouseExit()
    {
        _highLight.SetActive(false);
    }
}