using UnityEngine;

namespace Background.pool
{
    public class ObjectManager : MonoBehaviour
    {
        public ObjectPool objectPool;
        public int maxObjectsInScene = 10;

        private void Update()
        {
            var activeObjectsCount = 0;
            foreach (var obj in objectPool.Pool)
            {
                if (obj != null && obj.activeInHierarchy)
                {
                    activeObjectsCount++;
                }
            }
            
            while (activeObjectsCount < maxObjectsInScene)
            {
                var coin = objectPool.GetObjectFromPool();
                if (coin == null) return;
                coin.transform.position = transform.position + new Vector3(Random.Range(-5f, 5f), Random.Range(-4f, 4f), 0);
                activeObjectsCount++;
            }
        }
    }
}