using UnityEngine;
using System.Collections;

public class SlideTile : BaseTile
{
    public override void OnStep(Player player)
    {
        player.TryStep(player.map.GetPoint(new Vector2(transform.position.x, transform.position.y) + player.desiredPosition));
    }
}
