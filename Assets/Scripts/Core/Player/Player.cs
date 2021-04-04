using MoonlanderCode.Input;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Survivor))]
public class Player : MonoBehaviour
{
	private Survivor _survivor;
	private Vector2 _movementDir;
	
	private PlayerInputs _input;

	private void OnEnable() => _input.Enable();
	private void OnDisable() => _input.Disable();

	private void Awake()
	{
		_input = new PlayerInputs();

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
