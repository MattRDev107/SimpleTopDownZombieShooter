using System;
using UnityEditor.UIElements;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Survivor : MonoBehaviour
{

	public float moveSpeed = 5.0f;

	private Rigidbody2D _rb;

	private void Start()
	{
		_rb = gameObject.GetComponent<Rigidbody2D>();
	}

	public void Move(Vector2 movementDir)
	{
		Vector2 movePos = _rb.position + movementDir.normalized * moveSpeed * Time.fixedDeltaTime;

		_rb.MovePosition(movePos);
	}
}