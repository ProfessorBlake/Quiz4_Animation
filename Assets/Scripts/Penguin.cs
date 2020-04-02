using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Penguin : MonoBehaviour
{
	public Animator PenguinAnimator;
	public float WalkSpeed = 1f;

	private void Update()
	{
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			PenguinAnimator.SetInteger("state", 1);
			transform.position += new Vector3(-WalkSpeed, 0f, 0f) * Time.deltaTime;
		}
		else if (Input.GetKey(KeyCode.RightArrow))
		{
			PenguinAnimator.SetInteger("state", 2);
			transform.position += new Vector3(WalkSpeed, 0f, 0f) * Time.deltaTime;
		}
		else
		{
			PenguinAnimator.SetInteger("state", 0);
		}
	}
}
