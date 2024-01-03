using UnityEngine;
using UnityEngine.Events;

public abstract class APlayerInputController : MonoBehaviour
{
    public UnityEvent<bool> onGrabChange = new UnityEvent<bool>();

    /// <summary>
    /// Returns a Vector2 representing the movement input of the player.
    /// x and y are between -1 and 1.
    /// </summary>
    /// <returns></returns>
    public abstract Vector2 GetMovement();

    /// <summary>
    /// Is the player using the hold button?
    /// </summary>
    /// <returns></returns>
    public abstract bool GetHeld();
}
