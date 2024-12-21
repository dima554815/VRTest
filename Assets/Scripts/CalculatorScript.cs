using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CalculatorScript : MonoBehaviour
{
   [SerializeField] private TMP_InputField inputField1;
   [SerializeField] private TMP_InputField inputField2;
   [SerializeField] private TMP_Text outputText;

    private float ReadFloatFromInputField(TMP_InputField inputField) {
        string str = inputField.text;
        if (str != null && str.Length >0) {
            if (float.TryParse(str, out float floatValue)) {
                return floatValue;
            }
        }
        return 0;
    }

    public void OnButtonMinus() {
         float value1 = ReadFloatFromInputField(inputField1);
         float value2 = ReadFloatFromInputField(inputField2);
         outputText.text = (value1 - value2).ToString();
    }

    public void OnButtonPlus() {
        float value1 = ReadFloatFromInputField(inputField1);
         float value2 = ReadFloatFromInputField(inputField2);
         outputText.text = (value1 + value2).ToString();
    }

    public void OnButtonMultiplication() {
         float value1 = ReadFloatFromInputField(inputField1);
         float value2 = ReadFloatFromInputField(inputField2);
         outputText.text = (value1 * value2).ToString();
    }
    public void OnButtonDivision() {
        float value1 = ReadFloatFromInputField(inputField1);
        float value2 = ReadFloatFromInputField(inputField2);
        if (value2 == 0) {
            outputText.text = "На ноль делить нельзя!";
        } else {
            outputText.text = (value1 / value2).ToString();
        }
    }
}