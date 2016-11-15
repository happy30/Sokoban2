using UnityEngine;
using System.Collections;

public class BaseTile : MonoBehaviour
{
    public bool isSolid = false;

    public virtual void OnStep(Player player)
    {
        if(isSolid)
        {
            player.AbortStep();
        }
    }
}
