using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_Text EnteredName;

    public void NewNameEntered()
    {
        DataManager.Instance1.PlayerName = EnteredName.GetComponent<Text>().text;
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
}
