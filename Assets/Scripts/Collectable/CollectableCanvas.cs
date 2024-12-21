using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollectableCanvas : MonoBehaviour
{
    public static CollectableCanvas Instance;
    [SerializeField] private TMP_Text tmpText;
    private int itemsCount = 0;

    private void Start() {
        if (Instance == null) {
            Instance = this;
        }
    }

    public void IncrementItem() {
        itemsCount++;
        tmpText.text = itemsCount.ToString();
    }
}
