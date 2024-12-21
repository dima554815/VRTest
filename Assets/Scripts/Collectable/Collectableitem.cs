using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectableitem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            CollectableCanvas.Instance.IncrementItem();
            Destroy(gameObject);
        }
    }
}
