using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blaster : MonoBehaviour
{
    public Transform laserSpawnPoint;
    public GameObject laserPrefab;
    public float laserSpeed = 10;

	public AudioSource src;
	public AudioClip sfx;

	// Update is called once per frame
	void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(laserPrefab, laserSpawnPoint.position, laserSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = laserSpawnPoint.up * laserSpeed;

			src.clip = sfx;
			src.Play();
		}
    }
}
