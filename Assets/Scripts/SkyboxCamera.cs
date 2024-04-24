using UnityEngine;

namespace CosmicBagel
{
    public class SkyboxCamera : MonoBehaviour
    {
        private Transform mainCameraTransform;

        private void Update()
        {
            if (mainCameraTransform != null)
            {
                transform.rotation = mainCameraTransform.rotation;
            }
            else
            {
                mainCameraTransform = GameObject.FindWithTag("MainCamera").GetComponent<Transform>();
            }
        }
    }
}
