using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public void SaveName()
    {
        PlayerPrefs.SetString("NickName",GameObject.Find("NameField").GetComponent<TMP_InputField>().text);
        Debug.Log(GameObject.Find("NameField").GetComponent<TMP_InputField>().text);
        SceneManager.LoadScene("RoomList");
    }
}
