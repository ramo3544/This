using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptySpaceTile : Tile
{
    [SerializeField] private Color _baseColor, _offsetColor;

    public override void Init(int x, int y)
    {
        bool isOffset = (x + y) % 2 == 1;
        _renderer.color = isOffset ? _baseColor : _offsetColor;
    }
}
