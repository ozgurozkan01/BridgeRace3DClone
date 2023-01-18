using System;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private CharacterController controller;
    [SerializeField] private float movementSpeed;
    [SerializeField] private LayerMask _layerMask;

    private Ray _ray;
    private RaycastHit _hit;
    private Vector3 _movementDirection;
    void Start()
    {
        
    }

    void Update()
    {
        GetMousePositionİnWorld();
        if (CheckRayIsHit() && Input.GetMouseButton(0))
            PlayerMove();       
        
    }

    private void GetMousePositionİnWorld()
    {
        _ray = cam.ScreenPointToRay(Input.mousePosition);
    }

    bool CheckRayIsHit()
    {
        return Physics.Raycast(_ray, out _hit, float.MaxValue,_layerMask);
    }

    void PlayerMove()
    {
        _movementDirection = new Vector3(
            _hit.point.x - transform.position.x,
            transform.position.y,
            _hit.point.z - transform.position.z);

        transform.position = Vector3.MoveTowards(transform.position, new Vector3(_hit.point.x, transform.position.y, _hit.point.z), Time.deltaTime * movementSpeed);
        transform.LookAt(new Vector3(_hit.point.x, transform.position.y, _hit.point.z));
    }
}
