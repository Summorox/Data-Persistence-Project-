using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

[DefaultExecutionOrder(1000)]
public class MenuUiHandler : MonoBehaviour
{
    public TMP_InputField inputField;
    // Start is called before the first frame update
    void Update()
    {
        MainManager.instance.username = inputField.text;
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
}
