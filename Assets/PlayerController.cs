using UnityEngine;

namespace CosmicBagel
{
    public class PlayerController : MonoBehaviour
    {
        public Camera mainCamera;
        public float moveSpeed = 2.0f;
        // tuned this to my fav mouse sens
        // my aprox 800dpi mouse moving about 27.5cm gives 360 degree spin
        public float lookSensitivity = 1.724f;

        // Start is called before the first frame update
        void Start()
        {
#if !UNITY_EDITOR
            Cursor.lockState = CursorLockMode.Locked;
#endif
        }

        // Update is called once per frame
        void Update()
        {
#if UNITY_EDITOR
            // hack to stop taking input in editor when cursor is visible
            if (Input.GetMouseButtonDown(0))
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Cursor.lockState = CursorLockMode.None;
            }
#endif

            if (Cursor.lockState == CursorLockMode.Locked)
            {
                transform.RotateAround(transform.position, Vector3.up,
                        Input.GetAxis("Mouse X") * lookSensitivity);
                mainCamera.transform.RotateAround(mainCamera.transform.position,
                        mainCamera.transform.right, -Input.GetAxis("Mouse Y") *
                        lookSensitivity);
            }

            Vector3 moveVec = Vector3.zero;
            moveVec.z += Input.GetKey(KeyCode.W) ? 1 : 0;
            moveVec.z -= Input.GetKey(KeyCode.S) ? 1 : 0;
            moveVec.x += Input.GetKey(KeyCode.D) ? 1 : 0;
            moveVec.x -= Input.GetKey(KeyCode.A) ? 1 : 0;

            moveVec.Normalize();

            moveVec = transform.rotation * moveVec;

            transform.position += moveVec * Time.deltaTime * moveSpeed;
        }
    }
}
