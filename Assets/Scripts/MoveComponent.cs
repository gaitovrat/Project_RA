using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveComponent : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    private Rigidbody _body;
    
    public void Start()
    {
        _body = GetComponent<Rigidbody>();    
    }

    public void Update()
    {
        var xAxis = Input.GetAxisRaw("Horizontal");
        var zAxis = Input.GetAxisRaw("Vertical");

        _body.velocity = new Vector3(xAxis, _body.velocity.y, zAxis) * _speed;
    }
}
