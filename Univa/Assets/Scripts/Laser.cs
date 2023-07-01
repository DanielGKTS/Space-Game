using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float life = 5;

	void Awake()
	{
		Destroy(gameObject, life);
	}

	private void OnCollisionEnter(Collision collision)
	{
		Destroy(collision.gameObject);
		Destroy(gameObject);
	}
}
