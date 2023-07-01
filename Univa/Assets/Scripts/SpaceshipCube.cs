using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpaceshipCube : MonoBehaviour
{
	[Header("Ship Controls")]
	[SerializeField]
	private float strafeThrust = 1500f;
	[SerializeField]
	private float upDownThrust = 1500f;

	float upDownGlide, strafeGlide = 0f;

	[SerializeField]
	private float upDownGlideReduction = .1f;
	[SerializeField]
	private float strafeGlideReduction = .1f;


	Rigidbody rb;

	private float strafe1D;
	private float upDown1D;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		HandleMovement();
	}

	void HandleMovement()
	{
		//upDown
		if (upDown1D > 0.1f || upDown1D < -0.1f)
		{
			rb.AddRelativeForce(Vector3.up * upDown1D * upDownThrust * Time.deltaTime);
			upDownGlide = upDown1D * upDownThrust;
		}
		else
		{
			rb.AddRelativeForce(Vector3.up * upDownGlide * Time.deltaTime);
			upDownGlide *= upDownGlideReduction;
		}

		//strafe
		if (strafeThrust > 0.1f || strafeThrust < -0.1f)
		{
			rb.AddRelativeForce(Vector3.forward * strafe1D * strafeThrust * Time.deltaTime);
		}
		else
		{
			rb.AddRelativeForce(Vector3.forward * strafeGlide * Time.deltaTime);
			strafeGlide *= strafeGlideReduction;
		}

	}

	#region Input Methods
	public void onStrafe(InputAction.CallbackContext context)
	{
		strafe1D = context.ReadValue<float>();
	}

	public void onUpDown(InputAction.CallbackContext context)
	{
		upDown1D = context.ReadValue<float>();
	}

	public void onFire(InputAction.CallbackContext context)
	{

	}
	#endregion
}



