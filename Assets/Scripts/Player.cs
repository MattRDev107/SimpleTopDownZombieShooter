using MoonlanderCode.Input;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Survivor))]
public class Player : MonoBehaviour
{
	private Survivor _survivor;
	private Vector2 _movementDir;
	
	private PlayerInputAction _input;

	private void OnEnable() => _input.Enable();
	private void OnDisable() => _input.Disable();

	private void Awake()
	{
		_input = new PlayerInputAction();

		_input.Player.Movement.performed += ctx => _movementDir = ctx.ReadValue<Vector2>();
	}

	private void Start()
	{
		_survivor = gameObject.GetComponent<Survivor>();		
	}

	private void FixedUpdate()
	{
		_survivor.Move(_movementDir);
	}
}
