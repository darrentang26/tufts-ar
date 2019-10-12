using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PanelManager : MonoBehaviour
{
    public GameObject hide_button;
    public GameObject show_button;
    public GameObject panel;

    public void HidePanel()
    {
        hide_button.SetActive(false);
        panel.SetActive(false);
        show_button.SetActive(true);
    }

    public void ShowPanel()
    {
        show_button.SetActive(false);
        panel.SetActive(true);
        hide_button.SetActive(true);
    }

}
