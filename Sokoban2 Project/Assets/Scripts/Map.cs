
using UnityEngine;

public class Map
{
    BaseTile[,] tiles = new BaseTile[16,16];

    public void Load()
    {
        // TODO: Load map
    }

    public void Unload()
    {
        // TODO: unload map
    }

    public BaseTile GetPoint(Vector2 point)
    {
        return tiles[Mathf.RoundToInt(point.x), Mathf.RoundToInt(point.y)];
    }
}
