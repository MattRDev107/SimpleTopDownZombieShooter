using UnityEngine;

public class GameObjectBuilder
{
	private GameObject _gameObject;

	public GameObjectBuilder()
	{
		_gameObject = new GameObject();
	}

	public GameObjectBuilder With<TComponent>() where TComponent : Component
	{
		_gameObject.AddComponent<TComponent>();
		return this;
	}

	public GameObjectBuilder WithPosition(float x, float y, float z)
	{
		_gameObject.transform.position = new Vector3(x,y,z);
		return this;
	}

	public GameObjectBuilder WithPosition(float x, float y)
	{
		_gameObject.transform.position = new Vector2(x, y);
		return this;
	}

	public GameObjectBuilder WithPosition(Vector3 position)
	{
		_gameObject.transform.position = position;
		return this;
	}

	public GameObjectBuilder WithPosition(Vector2 position)
	{
		_gameObject.transform.position = position;
		return this;
	}
	
	public GameObjectBuilder WithRotation(Quaternion rotation)
	{
		_gameObject.transform.rotation = rotation;
		return this;
	}

	private GameObject Build()
	{
		return _gameObject;
	}

	public static implicit operator GameObject(GameObjectBuilder builder)
	{
		return builder.Build();
	}
}