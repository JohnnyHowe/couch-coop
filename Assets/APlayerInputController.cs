using UnityEngine;

public abstract class APlayerInputController : MonoBehaviour
{
    /// <summary>
    /// Returns a Vector2 representing the movement input of the player.
    /// x and y are between -1 and 1.
    /// </summary>
    /// <returns></returns>
    public abstract Vector2 GetMovement();
}
