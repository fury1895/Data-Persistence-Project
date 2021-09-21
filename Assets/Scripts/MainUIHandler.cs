using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUIHandler : MonoBehaviour
{
    public Text PlayerNameText;

    // Start is called before the first frame update
    void Start()
    {
        PlayerNameText.GetComponent<Text>().text = "Name: " + DataManager.Instance1.PlayerName;
    }
}
