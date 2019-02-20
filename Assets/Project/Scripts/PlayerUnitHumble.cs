using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerUnit
{
    float Speed { get; }
    Vector3 Position { get; set; }
}

public class PlayerUnitController
{
    private readonly IPlayerUnit _unit;

    public PlayerUnitController(IPlayerUnit unit)
    {
        _unit = unit;
    }

    public void Move(Vector3 direction)
    {
        _unit.Position += direction * _unit.Speed;
    }
}

public class PlayerUnitHumble : MonoBehaviour, IPlayerUnit
{
    [SerializeField]
    private float _speed = 1F;

    private PlayerUnitController _controller;

    public float Speed => _speed;
    public Vector3 Position
    {
        get => transform.position;
        set => transform.position = value;
    }

    void Start()
    {
        _controller = new PlayerUnitController(this);
    }

    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        _controller.Move(new Vector3(horizontal, vertical));
    }
}
