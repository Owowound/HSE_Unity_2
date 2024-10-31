using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class OpenShopScript : MonoBehaviour
{
    public Button shopButton;

    public GameObject newWindow;

    private event Action ButtonIsPressed;

    void Start()
    {
        shopButton.onClick.AddListener(ClickButton);
        ButtonIsPressed += OpenShop;
    }

    private void ClickButton()
    {
        ButtonIsPressed?.Invoke();
    }

    public void OpenShop()
    {
        bool isActive = newWindow.activeSelf;
        newWindow.SetActive(!isActive);
    }
}
