using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenL : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("Library");
    }
}
