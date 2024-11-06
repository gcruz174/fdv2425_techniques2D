using UnityEngine;

namespace Background.pool
{
    public class PoolableObject : MonoBehaviour
    {
        private int _collectionCount;
        private const int MaxCount = 3;

        private void Collect()
        {
            _collectionCount++;
            if (_collectionCount >= MaxCount)
            {
                Destroy(gameObject);
            }
            else
            {
                gameObject.SetActive(false);
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                Collect();
            }
        }
    }
}

