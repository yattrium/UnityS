using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenArtist : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("Artist");
    }
}
