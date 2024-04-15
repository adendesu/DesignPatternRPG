using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private GameObject target;
    
    private new Transform transform;
    private Transform targetTransform;
    
    private void Awake()
    {
        transform = gameObject.transform;
        targetTransform = target.transform;
    }
    
   void LateUpdate()
   {
       MoveCamera();
   }
    void MoveCamera()
    {
        transform.position = targetTransform.position;
    }
}
