using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
private Vector3 startPos;
    private Camera cam;
    public float speed;
    float targetposX;
    float targetposY;
    void Start()
    {
        cam  = gameObject.GetComponent<Camera>();
        targetposX = transform.position.x;
        targetposY = transform.position.z;
    }
    void Update()

    {

        if (Input.GetMouseButtonDown(0)) startPos = cam.ScreenToWorldPoint(Input.mousePosition);
        else if (Input.GetMouseButton(0))
        {

            float posX = cam.ScreenToWorldPoint(Input.mousePosition).x - startPos.x;
            float posY = cam.ScreenToWorldPoint(Input.mousePosition).z - startPos.z;
            targetposX = Mathf.Clamp(transform.position.x - posX, -20f, 65f);
            targetposY = Mathf.Clamp(transform.position.z - posY, -65f, 15f);






        }
        transform.position = new Vector3(Mathf.Lerp(transform.position.x, targetposX, speed * Time.deltaTime),transform.position.y, Mathf.Lerp(transform.position.z, targetposY, speed * Time.deltaTime));
    }
    public void Transform_to_cabinet(GameObject cabinet)
    {
        gameObject.transform.position = new Vector3(cabinet.transform.position.x, transform.position.y, cabinet.transform.position.z);
    }
}

