using UnityEngine;

namespace Background
{
    public class ScrollingBackgroundMaterial : MonoBehaviour
    {
        [SerializeField]
        private float speed = 1;
        private Material _material;
        
        private void Start()
        {
            _material = GetComponent<Renderer>().material;
        }
        
        private void Update()
        {
            var offset = _material.mainTextureOffset;
            offset.x += Time.deltaTime * speed;
            _material.mainTextureOffset = offset;
        }
    }
}
