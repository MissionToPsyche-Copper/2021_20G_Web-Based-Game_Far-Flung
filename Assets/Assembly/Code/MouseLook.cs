using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public float lookUpLimit;
    public float lookDownLimit;

    static GameObject menu;

    public static GameObject MenuObject 
    {get {return menu? menu: (menu = GameObject.Find("Menus").transform.Find("PauseMenu").gameObject);}}
    
    float xRotation = 0f;
    float yRotation = 0f;

    public Transform playerBody;

    void Update() {
        
        if ( Input.GetButtonDown("Cancel") ) {
            if (Cursor.lockState == CursorLockMode.Locked )
            {
                ShowMenu();
            
            } else if(MenuObject.activeSelf){
            
                HideMenu();
            }
        }
        if (Cursor.lockState == CursorLockMode.Locked) {
            LookUpdate();
        }
    }

    public static void PauseAssembly() {

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        // Time.timeScale = 0;
    }

    public static void ResumeAssembly() {

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
    }

    public static void ShowMenu() {
        PauseAssembly();
        MenuObject.SetActive(true);
    }

    public static void HideMenu() {
        MenuObject.SetActive(false);
        ResumeAssembly();
    }

    void LookUpdate() {
 
        yRotation += Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

        xRotation -= Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        xRotation = Mathf.Clamp(xRotation, -lookUpLimit, lookDownLimit);

        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
    }

    void OnDestroy() {
        Cursor.lockState = CursorLockMode.None;
    }
}