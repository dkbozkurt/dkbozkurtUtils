using DKB.Utilities;
using UnityEngine;

namespace DKB.Test
{
    public class MainTest : MonoBehaviour
    {
        private Transform _transformInfo;
        
        private void Start()
        {
            _transformInfo = transform;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                transform.Reset();
            }
            
            if (Input.GetKeyDown(KeyCode.W))
            {
                transform.Reset(false);
            }
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                transform.position = _transformInfo.position;
                transform.rotation = _transformInfo.rotation;
                transform.localScale = _transformInfo.localScale;
            }
        }
    }
}
