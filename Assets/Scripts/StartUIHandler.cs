using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;

[DefaultExecutionOrder(1000)]
public class StartUIHandler : MonoBehaviour
{
    // Start is called before the first frame update
    private string enteredText;
    public InputField inputField;

    public void OnNameEntered()
    {
        enteredText = inputField.text;
        //Debug.Log(enteredText);
    }
    public void SetText(string str)
    {
        if (DataManager.Instance != null)
        {
            DataManager.Instance.playerName = str;
        }
        else
        {
            Debug.Log("Fuck");
        }
    }

    public void StartNew()
    {
        SetText(enteredText);
        SceneManager.LoadScene(1);
    }
}
