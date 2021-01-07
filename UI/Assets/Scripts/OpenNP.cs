using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenNP : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("NnP");
        Debug.Log("click");
    }

}
