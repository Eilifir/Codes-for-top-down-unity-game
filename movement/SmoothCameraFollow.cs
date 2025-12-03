using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector2 offset = Vector2.zero;
    [SerializeField] private float smoothTime = 0.2f;

    private Vector3 currentVelocity;

    private void LateUpdate()
    {
        if (target == null) return;

        Vector3 targetPos = target.position + (Vector3)offset;
        targetPos.z = transform.position.z;

        transform.position = Vector3.SmoothDamp(
            transform.position,
            targetPos,
            ref currentVelocity,
            smoothTime
        );
    }
}
