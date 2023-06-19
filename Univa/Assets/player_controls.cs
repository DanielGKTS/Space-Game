using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controls : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
     	transform.Translate(0f, 0f, Input.GetAxis("Horizontal") * Time.deltaTime * 35f);
        transform.Translate(0f, Input.GetAxis("Vertical") * Time.deltaTime * 35f, 0f);
    }
}