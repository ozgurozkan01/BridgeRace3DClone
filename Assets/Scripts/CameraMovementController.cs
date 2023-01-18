using System;
using UnityEngine;

public class CameraMovementController : MonoBehaviour
{
    private Vector3 _distance;
    [SerializeField] private float lerpMultiplier;
    [SerializeField] private Transform player;

    private void Start()
    {
        _distance = transform.position - player.transform.position;
    }

    private void LateUpdate()
    {
        CameraFollowPlayer();
    }

    private void CameraFollowPlayer()
    {
        transform.position = Vector3.Lerp(transform.position, player.transform.position + _distance, lerpMultiplier);
    }
}
