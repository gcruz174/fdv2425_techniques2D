using UnityEngine;
using UnityEngine.Serialization;

namespace Background
{
    public class ScrollingBackgroundTeleport : MonoBehaviour
    {
        [SerializeField]
        private float speed = 1;
        
        private SpriteRenderer _spriteRenderer;
        private Camera _mainCamera;
    
        private void Start()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
            _mainCamera = Camera.main;
        }
    
        private void Update()
        {
            // Comment this line if the camera is moving
            transform.Translate(Vector3.left * (speed * Time.deltaTime));
            
            var cameraPosition = _mainCamera.transform.position;
            var spritePosition = transform.position;
        
            var spriteWidth = _spriteRenderer.bounds.size.x;
            var cameraHalfWidth = _mainCamera.orthographicSize * _mainCamera.aspect;
            var cameraLeft = cameraPosition.x - cameraHalfWidth;
            var spriteRight = spritePosition.x + spriteWidth / 2;
        
            if (cameraLeft > spriteRight)
                transform.position = cameraPosition + new Vector3(cameraHalfWidth + spriteWidth / 2, 
                    transform.position.y, 10);
        }
    }
}
