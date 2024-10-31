using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using Bank;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Button button;

    public event Action ButtonIsPressed;

    public ResourceBank gameResource;
    public Resource resourceType;
    public Level resourceLevel;

    private int ProductionTime;
    public Slider slider;
    private Coroutine ProductionCoroutine;

    void Start()
    {
        button.onClick.AddListener(ClickButton);
        ButtonIsPressed += IncreasingResource;
        ProductionTime = 1000;
        slider.maxValue = ProductionTime;
    }

    private void ClickButton()
    {
        ButtonIsPressed?.Invoke();
    }

    private void IncreasingResource()
    {
        button.interactable = false; // Делаем кнопку неактивной
        ProductionCoroutine = StartCoroutine(ProduceResource());
    }

    private IEnumerator ProduceResource()
    {
        float Time = 0;

        while (Time < ProductionTime) // Цикл до тех пор, пока не пройдет время производства
        {
            Time += gameResource.GetLevel(resourceLevel);
            slider.value = Time;
            yield return null;
        }

        gameResource.ChangeResource(resourceType, 1);

        button.interactable = true; // Делаем кнопку активной
        slider.value = 0; // Сбрасываем слайдер
        ProductionCoroutine = null; // Удаляем корутину, так как производство завершено
    }
}
