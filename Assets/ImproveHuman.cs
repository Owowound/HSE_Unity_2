using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using Bank;

public class ImproveHuman : MonoBehaviour
{
    public Button improveButton;
    public event Action ButtonIsPressed;

    public ResourceBank gameResource;
    public Level resourceLevel;

    void Start()
    {
        improveButton.onClick.AddListener(ClickButton);
        ButtonIsPressed += ImproveResource;
    }

    private void ClickButton()
    {
        ButtonIsPressed?.Invoke();
    }

    void ImproveResource()
    {
        gameResource.ChangeLevel(resourceLevel, 1);
    }
}
