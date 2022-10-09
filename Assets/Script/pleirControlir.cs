using UnityEngine;

public class pleirControlir : MonoBehaviour
{
    [Header("mov")]
    public float Speed;
    public float Jamp;
    private Rigidbody rb;

    [Header("Raycast")]
    public bool isDebag;
    public float distansia;
    public LayerMask Mask;

    [Header("Camera")]
    public GameObject cam;
    public float sensitiX;
    public float sensitiY;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        
    }

    private void FixedUpdate()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        Vector3 muv = new Vector3(Horizontal, 0, Vertical);
        transform.Translate(muv * Speed);

    }

    private void Update()
    {
        Cursor.lockState = Input.GetKey(KeyCode.E) ?CursorLockMode.None: CursorLockMode.Locked;
        if (isDebag) Debug.DrawRay(transform.position, Vector3.down * distansia);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bool zemla = Physics.Raycast(transform.position, Vector3.down, distansia, Mask);

            if (zemla)
                rb.AddForce(Vector3.up * Jamp, ForceMode.Impulse);
        }

        //
        float yRot = Input.GetAxisRaw("Mouse X");
        float xRot = Input.GetAxisRaw("Mouse Y");

        cam.transform.Rotate(new Vector3(xRot * sensitiX, 0, 0));
        transform.Rotate(new Vector3(0, yRot * sensitiY, 0));
    }
}
