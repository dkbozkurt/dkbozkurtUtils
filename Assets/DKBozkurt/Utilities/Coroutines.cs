// Dogukan Kaan Bozkurt
//      github.com/dkbozkurt

using System;
using System.Collections;
using UnityEngine;

namespace DKBozkurt.Utilities
{
    public static partial class DKBozkurtUtilities
    {
        /// <summary>
        /// Waits for a while then executes the callback.
        /// </summary>
        /// <param name="duration"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public static IEnumerator WaitForTimeCoroutine(float duration,Action callback = null)
        {
            yield return new WaitForSeconds(duration);
            callback?.Invoke();
        }

        /// <summary>
        /// Waits for a frame then executes the callback.
        /// </summary>
        /// <param name="callback"></param>
        /// <returns></returns>
        public static IEnumerator WaitForOneFrameCoroutine(Action callback = null)
        {
            yield return null;
            callback?.Invoke();
        }
        
        /// <summary>
        /// Waits for a while in real time then executes the callback.
        /// </summary>
        /// <param name="duration"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public static IEnumerator WaitForRealTimeCoroutine(float duration, Action callback = null)
        {
            yield return new WaitForSecondsRealtime(duration);
            callback?.Invoke();
        }
        
        /// <summary>
        /// Coroutine execution waits until the predicate become true
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public static IEnumerator WaitUntilTrueCoroutine(Func<bool> predicate,Action callback= null)
        {
            yield return new WaitUntil(predicate);
            callback?.Invoke();
        }
        
        /// <summary>
        /// Coroutine execution waits while the predicate is true
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public static IEnumerator WaitWhileTrueCoroutine(Func<bool> predicate,Action callback= null)
        {
            yield return new WaitWhile(predicate);
            callback?.Invoke();
        }
    }
    
}
