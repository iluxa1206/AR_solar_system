using UnityEngine;

public class CelestialBody : MonoBehaviour
{
    [Header("Orbital Settings")]
    public Transform orbitCenter; // Центр орбиты
    public float orbitSpeed = 0f; // Скорость вращения по орбите

    [Header("Rotation Settings")]
    public float rotationSpeed = 0f; // Скорость вращения вокруг своей оси

    private static bool isPaused = false; // Флаг паузы для всей системы

    void Update()
    {
        if (!isPaused)
        {
            // Вращение по орбите
            if (orbitCenter != null)
            {
                transform.RotateAround(orbitCenter.position, Vector3.up, orbitSpeed * Time.deltaTime);
            }

            // Вращение вокруг своей оси
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }

    // Метод для управления паузой всей системы
    public static void TogglePause()
    {
        isPaused = !isPaused;
    }
}

