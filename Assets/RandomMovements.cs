using UnityEngine;

public class RandomMovements : MonoBehaviour {

	public float speed = 3.0f;
	private bool restartMovementOnNextSpaceHit = false;

	void Update()
	{
		transform.Rotate(0, speed, 0);
		if (Input.GetKey("space") && restartMovementOnNextSpaceHit == false)
		{
			speed = 0;
			restartMovementOnNextSpaceHit = true;
		}
		else if (Input.GetKey("space") && restartMovementOnNextSpaceHit == true)
		{
			speed = 3.0f;
			restartMovementOnNextSpaceHit = false;
		}
	}
}
 