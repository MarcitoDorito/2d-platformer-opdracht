using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("");
            Coinmanager.Addscore();
            Destroy(gameObject);
        }
    }
}
