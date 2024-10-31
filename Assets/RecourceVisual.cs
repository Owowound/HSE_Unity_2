using UnityEngine;
using TMPro;
using Bank;
using Manager;

public class ResourceVisual : MonoBehaviour
{

    public Resource resourceType;

    public TextMeshProUGUI numberResource;
    public TextMeshProUGUI levelResource;

    private GameManager manager;

    public ResourceBank gameResource;

    public Level resourceLevel;


    void Start()
    {
        manager = new GameManager();

        numberResource.text = gameResource.GetResource(resourceType).ToString();
        levelResource.text = gameResource.GetLevel(resourceLevel).ToString();
    }

    void Update()
    {
        numberResource.text = gameResource.GetResource(resourceType).ToString();
        levelResource.text = gameResource.GetLevel(resourceLevel).ToString();
    }
}