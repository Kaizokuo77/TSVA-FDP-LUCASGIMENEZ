using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity;
    public GameObject player;
    float xRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        if (PlayerPrefs.GetFloat("MouseSensitivity") > 0) mouseSensitivity = PlayerPrefs.GetFloat("MouseSensitivity");
        else
        {
            mouseSensitivity = 275
                ;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        player.transform.Rotate(Vector3.up * mouseX);
    }
}