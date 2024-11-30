using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RandomScript : MonoBehaviour {
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private TMP_Text outputText;
    private int randomValue;
    private void Start() {
        GenerateRandomValue();
    }
    private void GenerateRandomValue() {
        randomValue = Random.Range(0, 101);
    }
    public void OnButton() {
        int userEnterValue = ReadIntFromInputField(inputField);
        if (userEnterValue == randomValue) {
            outputText.text = "Ты угадал!";
            GenerateRandomValue();
        }else if (randomValue < userEnterValue) {
            outputText.text = "Загаданное число меньше!";
        } else {
            outputText.text = "Загаданное число больше!";
        }
    }
    private int ReadIntFromInputField(TMP_InputField inputField) {
        string str = inputField.text;
        if (str !=null && str.Length >0) {
            if (int.TryParse(str, out int intVaul)) {
                return intVaul;
            }
        }
        return 0;
    }
}
