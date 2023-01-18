using System;
using UnityEngine;

public class PlayerPickUpTheBlock : MonoBehaviour
{
    [SerializeField] private Transform firstBlockPos;
    private float _heightOfNewBlock = .2f;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BlueBlock"))
        {
            other.transform.SetParent(gameObject.transform);
            other.transform.position = new Vector3(
                firstBlockPos.position.x,
                firstBlockPos.position.y + _heightOfNewBlock,
                firstBlockPos.position.z);

            _heightOfNewBlock += 0.2f;
            other.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
        }
    }
}
