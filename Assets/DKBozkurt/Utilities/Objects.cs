//  Dogukan Kaan Bozkurt
//      github.com/dkbozkurt

using UnityEngine;

namespace DKBozkurt.Utilities
{
    /// <summary>
    /// My own Utils class for Creating.
    /// 
    /// </summary>
    
    public static partial class DKBozkurtUtilities 
    {
        
        /// <summary>
        /// Creates a Sprite in the World, no parent.
        /// </summary>
        /// <param name="name"> Name of the object.</param>
        /// <param name="sprite">Sprite to assign into Sprite Renderer component.</param>
        /// <param name="position">World position of the object.</param>
        /// <param name="localScale">Scale of the object.</param>
        /// <param name="sortingOrder">Order in the hierarchy.</param>
        /// <param name="color">Initial color of the sprite.</param>
        /// <returns> GameObject that contains Sprite in it.</returns>
        public static GameObject CreateWorldSprite(string name, Sprite sprite, Vector3 position, Vector3 localScale,
            int sortingOrder, Color color)
        {
            return CreateWorldSprite(null, name, sprite, position, localScale, sortingOrder, color);
        }
        
        /// <summary>
        /// Creates a Sprite in the World.
        /// </summary>
        /// <param name="parent">Parent object.</param>
        /// <param name="name"> Name of the object.</param>
        /// <param name="sprite">Sprite to assign into Sprite Renderer component.</param>
        /// <param name="position">World position of the object.</param>
        /// <param name="localScale">Scale of the object.</param>
        /// <param name="sortingOrder">Order in the hierarchy.</param>
        /// <param name="color">Initial color of the sprite.</param>
        /// <returns> GameObject that contains Sprite in it.</returns>
        /// <returns></returns>
        public static GameObject CreateWorldSprite(Transform parent, string name, Sprite sprite, Vector3 localPosition, Vector3 localScale, int sortingOrder, Color color) {
            GameObject gameObject = new GameObject(name, typeof(SpriteRenderer));
            Transform transform = gameObject.transform;
            transform.SetParent(parent, false);
            transform.localPosition = localPosition;
            transform.localScale = localScale;
            SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = sprite;
            spriteRenderer.sortingOrder = sortingOrder;
            spriteRenderer.color = color;
            return gameObject;
        }

        /// <summary>
        /// Quickly destroy all child objects.
        /// </summary>
        /// <param name="t">Parent object's transform </param>
        public static void DeleteChildren(this Transform t)
        {
            foreach (Transform child in t) { Object.Destroy(child.gameObject); }
        }
        
        /// <summary>
        /// Resets the transform properties
        /// </summary>
        /// <param name="transform"></param>
        /// <param name="isLocalTransform"> Identifies if operation going to be in local space</param>
        public static void Reset(this Transform transform, bool isLocalTransform = true )
        {
            if (isLocalTransform)
            {
                transform.localPosition = Vector3.zero;
                transform.localRotation = Quaternion.Euler(Vector3.zero);
                transform.localScale = Vector3.one;
                return;    
            }
            
            transform.position = Vector3.zero;
            transform.rotation = Quaternion.Euler(Vector3.zero);
            transform.localScale = Vector3.one;
        }

        /// <summary>
        /// Makes the object's down vector point at the target transform
        /// </summary>
        /// <param name="transform"></param>
        /// <param name="targetTransform"></param>
        public static void LookTargetWithDownVector(this Transform transform, Transform targetTransform)
        {
            transform.LookTargetWithDownVector(targetTransform.position);
        }
        
        /// <summary>
        /// Makes the object's down vector point at the target position
        /// </summary>
        /// <param name="transform"></param>
        /// <param name="targetPosition"></param>
        public static void LookTargetWithDownVector(this Transform transform, Vector3 targetPosition)
        {
            Vector3 directionToTarget = (targetPosition - transform.position).normalized;
            transform.rotation = Quaternion.FromToRotation(transform.up, -directionToTarget)
                * transform.rotation;

        }

    }
}