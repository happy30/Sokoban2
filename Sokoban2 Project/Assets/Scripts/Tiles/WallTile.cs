using UnityEngine;
using System.Collections;

public class WallTile : BaseTile
{
    public override void OnStep(Player player)
    {
        player.AbortStep();
    }

}
