//  Dogukan Kaan Bozkurt
//      github.com/dkbozkurt

using System.Collections;
using UnityEngine;

namespace DKBozkurt.Utilities
{
    public class UtilsTest : MonoBehaviour
    {
        [SerializeField] private Transform _testObject;
        private void Start()
        {
            DKBozkurtUtilities.Events.OnScoreUpdated.Invoke(1);

            //StartCoroutine(NonAllocatingWaitTest());
        
        }

        private void Update()
        {
            // _testObject.transform.position =DKBozkurtUtils.GetMouseWorldPositionWithDistance(10);
            _testObject.transform.position =DKBozkurtUtilities.GetMousePositionByCreatingPlaneOnZAxis();
        }

        private void OnEnable()
        {
            DKBozkurtUtilities.Events.OnScoreUpdated.AddListener(TestCustomScoreEventMethod);
        }

        private void OnDisable()
        {
            DKBozkurtUtilities.Events.OnScoreUpdated.RemoveListener(TestCustomScoreEventMethod);
        }

        private void TestCustomScoreEventMethod(int score)
        {
            Debug.Log($"score : {score}");
        }
    
        private IEnumerator NonAllocatingWaitTest()
        {
            for (int i = 0; i < 3; i++)
            {
                yield return DKBozkurtUtilities.GetWait(5f);
                Debug.Log("Dogukan");
            }
        }
    }
}
