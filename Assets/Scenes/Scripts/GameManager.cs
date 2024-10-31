using UnityEngine;
using System.Collections.Generic;
using Bank;

namespace Manager
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] public ResourceBank gameResource;

        void Awake()
        {
            gameResource.ChangeResource(Resource.Human, 10);
            gameResource.ChangeResource(Resource.Wood, 5);
            gameResource.ChangeResource(Resource.Food, 5);
            gameResource.ChangeResource(Resource.Stone, 0);
            gameResource.ChangeResource(Resource.Gold, 0);

            gameResource.ChangeLevel(Level.Human, 1);
            gameResource.ChangeLevel(Level.Wood, 1);
            gameResource.ChangeLevel(Level.Food, 1);
            gameResource.ChangeLevel(Level.Stone, 1);
            gameResource.ChangeLevel(Level.Gold, 1);
        }
    }
}

