using UnityEngine;

public class PauseSystem : MonoBehaviour
{
    public void OnPauseButtonPressed()
    {
        CelestialBody.TogglePause();
    }
}
