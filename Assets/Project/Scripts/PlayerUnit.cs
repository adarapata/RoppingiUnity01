using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit : MonoBehaviour
{
    [SerializeField]
    private float _speed = 1F;

    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        Move(new Vector3(horizontal, vertical));
    }

    private void Move(Vector3 direction)
    {
        transform.position += direction * _speed;
    }
}
