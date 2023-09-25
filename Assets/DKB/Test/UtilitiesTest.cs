using DKB.Utilities;
using System.Collections;
using UnityEngine;

namespace DKB.Test
{
    public class UtilitiesTest : MonoBehaviour
    {
        [SerializeField] private Transform _testObject;
        private void Start()
        {
            DkbUtils.Events.OnScoreUpdated.Invoke(1);

            //StartCoroutine(NonAllocatingWaitTest());
        
        }

        private void Update()
        {
            // _testObject.transform.position =DkbUtils.GetMouseWorldPositionWithDistance(10);
            _testObject.transform.position =DkbUtils.GetMousePositionByCreatingPlaneOnZAxis();
        }

        private void OnEnable()
        {
            DkbUtils.Events.OnScoreUpdated.AddListener(TestCustomScoreEventMethod);
        }

        private void OnDisable()
        {
            DkbUtils.Events.OnScoreUpdated.RemoveListener(TestCustomScoreEventMethod);
        }

        private void TestCustomScoreEventMethod(int score)
        {
            Debug.Log($"score : {score}");
        }
    
        private IEnumerator NonAllocatingWaitTest()
        {
            for (int i = 0; i < 3; i++)
            {
                yield return DkbUtils.GetWait(5f);
                Debug.Log("Dogukan");
            }
        }
    }
}
