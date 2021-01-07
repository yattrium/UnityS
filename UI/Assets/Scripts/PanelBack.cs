using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelBack : MonoBehaviour
{
    public GameObject OpenedPanel;

    public void ClosePanel()
    {
        OpenedPanel.SetActive(false);     
    }


}
