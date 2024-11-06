using System.Collections.Generic;
using UnityEngine;

namespace Background.pool
{
    public class ObjectPool : MonoBehaviour
    {
        public GameObject objectPrefab;
        public int initialPoolSize = 15;
        
        public readonly List<GameObject> Pool = new();

        private void Start()
        {
            for (var i = 0; i < initialPoolSize; i++)
            {
                var obj = Instantiate(objectPrefab);
                obj.SetActive(false);
                Pool.Add(obj);
            }
        }

        public GameObject GetObjectFromPool()
        {
            foreach (var obj in Pool)
            {
                if (obj == null || obj.activeInHierarchy) continue;
                obj.SetActive(true);
                return obj;
            }

            return null;
        }

        public void ReturnObjectToPool(GameObject obj)
        {
            obj.SetActive(false);
        }
    }
}