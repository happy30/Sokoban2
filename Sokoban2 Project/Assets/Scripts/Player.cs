using UnityEngine;

public class Player : MonoBehaviour
{
    Map map;

    Vector2 desiredPosition;
    Vector2 previousSafePosition;

    public void Awake()
    {
        map = GameObject.FindGameObjectWithTag("map").GetComponent<Map>();
    }

    /// <summary>
    /// Call this function when you move the player on either of the four directions
    /// </summary>
    /// <param name="direction">direction e.g. (0, 1), (1, 0), (-1, 0), (0, -1)</param>
    public void OnMove(Vector2 direction)
    {
        previousSafePosition = transform.position;

        desiredPosition = previousSafePosition + direction;

        TryStep(map.GetPoint(desiredPosition));
    }

    // Resets desired position.
    public void AbortStep()
    {
        desiredPosition = previousSafePosition;
    }

    void TryStep(BaseTile nextTile)
    {
        // TODO: better system than "AbortStep()"
        nextTile.OnStep(this);

        // TODO: Make this smoother.
        transform.position = desiredPosition;
    }
}

