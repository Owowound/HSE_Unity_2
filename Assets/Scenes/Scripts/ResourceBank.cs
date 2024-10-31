using UnityEngine;
using System.Collections.Generic;

namespace Bank
{
    public enum Resource
    {
        Human,
        Food,
        Wood,
        Stone,
        Gold

    };
    public enum Level
    {
        Human,
        Food,
        Wood,
        Stone,
        Gold

    };

    public class ResourceBank : MonoBehaviour
    {
        public Dictionary<Resource, int> bank = new Dictionary<Resource, int>();
        public Dictionary<Level, int> levels = new Dictionary<Level, int>();

        public void ChangeResource(Resource r, int v)
        {
            if (bank.ContainsKey(r))
            {
                bank[r] += v;
            }
            else
            {
                bank[r] = v; // Если ресурса еще нет, добавляем его
            }
        }

        public int GetResource(Resource r)
        {
            return bank.ContainsKey(r) ? bank[r] : 0; // Возвращаем 0, если ресурса нет
        }

        public void ChangeLevel(Level r, int v)
        {
            if (levels.ContainsKey(r))
            {
                levels[r] += v;
            }
            else
            {
                levels[r] = v;
            }
        }

        public int GetLevel(Level r)
        {
            return levels.ContainsKey(r) ? levels[r] : 0; // Возвращаем 0, если ресурса нет
        }
    }
}
