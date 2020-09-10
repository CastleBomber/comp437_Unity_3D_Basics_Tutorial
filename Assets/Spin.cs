using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {

	public float speed = 3.0f;

	private void Update()
	{
		transform.Rotate(0, speed, 0);
	}
}
