using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LossCollider : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Application.LoadLevel("StartMenu");
        Debug.Log("Collision");
    }
}
