using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class AnketaScript : MonoBehaviour
{
    public TMP_InputField nameInputField;
    public TMP_Text nameTmpText;

    public TMP_InputField ageInputField;
    public TMP_Text ageTmpText;

    private void Start() {
        nameInputField.onEndEdit.AddListener(NameInputFieldOnEdit);
        ageInputField.onEndEdit.AddListener(AgeInputFieldOnEdit);
    } 

    private void NameInputFieldOnEdit(string text) {
        Debug.Log("AnketaScript::NameInputFieldOnEdit(); -- text:" + text);
        OnButtonUserName();
    }

    private void AgeInputFieldOnEdit(string text) {
        Debug.Log("AnketaScript::AgeInputFieldOnEdit(); -- text:" + text);
        OnButtonUserAge();
    }

    public void OnButtonUserName() {
        Debug.Log("AnketaScript::OnButtonUserName(); --nameInputField.text:" + nameInputField.text);
        nameTmpText.text = nameInputField.text;
    }

    public void OnButtonUserAge() {
        Debug.Log("AnketaScript::OnButtonUserAge(); -- ageInputField.text" + ageInputField.text);
        string ageString = ageInputField.text;
        if (ageString != null && ageString.Length > 0) {
            if (int.TryParse(ageString, out int ageInt)) { 
                // int ageInt = int.Parse(ageString);
                DateTime dateTime = DateTime.Now;
                dateTime = dateTime.AddYears(-ageInt);
                ageTmpText.text = dateTime.ToString("yyyy");
            } else {
                ageTmpText.text = "Нужно только число!"; 
            }
        } else {
            ageTmpText.text = "Заполните поле!";
        }            
    }
}       
    