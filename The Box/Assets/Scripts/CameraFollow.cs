using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   public Transform target;
   public float smoothTime = 0.3f;

   private Vector3 velocity = Vector3.zero;
   public float baseCamVal_Z = -1.0f;

   void Awake() {
      baseCamVal_Z = transform.position.z;
   }

   void FixedUpdate() {
      Vector3 foo = new Vector3(transform.position.x, transform.position.y, target.position.z + baseCamVal_Z);

      transform.position = Vector3.SmoothDamp(transform.position, foo, ref velocity, smoothTime);

      //transform.LookAt(target);
   }
}
 