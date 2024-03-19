using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{

    float speed = 5f;
    public float rotationSpeed = 5f;
    public float Jumpv = 5f;
    private Rigidbody rb;
    public float thrust = 10;
    bool m_isGrounded;
    public static int puntajeTotal = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        m_isGrounded = true; 
    }

    void Update()
    {
        // Movimiento del personaje
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(movimientoHorizontal, 0f, movimientoVertical);
        movementDirection.Normalize();

        transform.position = transform.position + movementDirection * speed * Time.deltaTime;

        if(movementDirection != Vector3.zero) transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.LookRotation(movementDirection),rotationSpeed * Time.deltaTime);

        //salto//
        if (Input.GetKeyDown(KeyCode.Space) && m_isGrounded == true)
        {
            Jump();
        }
    }

    public void Jump()
    {
        m_isGrounded = false;
        rb.AddForce(0, thrust, 0, ForceMode.Impulse);
    }
    void OnCollisionEnter(Collision other)
        {
        if (other.gameObject.CompareTag("Ground"))
        {
            m_isGrounded = true;
        }
        }
}


