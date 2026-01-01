using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SlotMover : MonoBehaviour
{
    [Header("Slots")]
    public Transform[] slots;
    public float moveSpeed = 8f;

    [Header("References")]
    public Springer stickHinge; 
    public Movement ballDriver;           

    int currentIndex;
    Vector3 targetPosition;
    Rigidbody rb;
    bool onLeftWall = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentIndex = 0;
        targetPosition = slots[0].position;
        rb.position = targetPosition;
        ApplyWall(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) Move(-1);
        if (Input.GetKeyDown(KeyCode.D)) Move(1);
    }

    void FixedUpdate()
    {
        rb.MovePosition(Vector3.MoveTowards(
            rb.position,
            targetPosition,
            moveSpeed * Time.fixedDeltaTime
        ));
    }

    void Move(int dir)
    {
        int next = Mathf.Clamp(currentIndex + dir, 0, slots.Length - 1);
        if (next == currentIndex) return;

        currentIndex = next;
        targetPosition = slots[currentIndex].position;

        bool left = currentIndex <= 2;
        if (left != onLeftWall)
            ApplyWall(left);
    }

    void ApplyWall(bool left)
    {
        onLeftWall = left;
        rb.MoveRotation(left ? Quaternion.Euler(0, 0, 0) : Quaternion.Euler(0, 90, 0));

        // Update hinge axis after rotation
        if (stickHinge != null)
            stickHinge.UpdateAxisFromTile();

        // Ensure BallDriver has tile reference (only if unassigned)
        if (ballDriver != null && ballDriver.tile == null)
            ballDriver.tile = transform;
    }
}
