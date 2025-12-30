using UnityEngine;

public class SlotMover : MonoBehaviour
{
    [Header("Fixed slot positions")]
    public Transform[] slots;

    [Header("Movement")]
    public float moveSpeed = 8f;

    int currentIndex = 0;
    Vector3 targetPosition;

    void Start()
    {
        if (slots.Length == 0) return;

        currentIndex = 0;
        targetPosition = slots[currentIndex].position;
        transform.position = targetPosition;
    }

    void Update()
    {
        // Input (discrete, not continuous)
        if (Input.GetKeyDown(KeyCode.A))
        {
            MoveLeft();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            MoveRight();
        }

        // Smooth snap movement
        transform.position = Vector3.MoveTowards(
            transform.position,
            targetPosition,
            moveSpeed * Time.deltaTime
        );
    }

    void MoveLeft()
    {
        if (currentIndex <= 0) return;

        currentIndex--;
        targetPosition = slots[currentIndex].position;
    }

    void MoveRight()
    {
        if (currentIndex >= slots.Length - 1) return;

        currentIndex++;
        targetPosition = slots[currentIndex].position;
    }
}
