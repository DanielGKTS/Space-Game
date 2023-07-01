using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
	[SerializeField]
	float enemySpeed = 10f;

	Rigidbody rb;


	// Start is called before the first frame update
	void Start()
    {
		rb = GetComponent<Rigidbody>();
		rb.GetComponent<Rigidbody>().velocity = Vector3.left * enemySpeed;
	}

	public GameObject frozenPanel;

	void Update()
	{
		if (transform.position.x < 0)
		{
			Time.timeScale = 0f;
			frozenPanel.SetActive(true);
		}
	}
}
