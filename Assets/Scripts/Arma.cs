using UnityEngine;

public class Arma : MonoBehaviour
{
    public Transform saidaDoTiro;
    public GameObject bala;
    public float intevaloDeDisparo = 0.2f;

    private float tempoDeDisparo = 0;

    private Camera camera;
    public GameObject cursor;

    private Vector3 escalaOriginal; 

    void Start()
    {
        camera = Camera.main;
        escalaOriginal = transform.localScale; 
    }

    void Update()
    {
        float camDis = camera.transform.position.y - transform.position.y;

        Vector3 mouse = camera.ScreenToWorldPoint(
            new Vector3(Input.mousePosition.x, Input.mousePosition.y, camDis)
        );

        float AngleRad = Mathf.Atan2(mouse.y - transform.position.y, mouse.x - transform.position.x);
        float angle = AngleRad * Mathf.Rad2Deg;

        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        
        if (angle > 90 || angle < -90)
        {
            transform.localScale = new Vector3(
                escalaOriginal.x,
                -Mathf.Abs(escalaOriginal.y),
                escalaOriginal.z
            );
        }
        else
        {
            transform.localScale = new Vector3(
                escalaOriginal.x,
                Mathf.Abs(escalaOriginal.y),
                escalaOriginal.z
            );
        }

        cursor.transform.position = new Vector3(mouse.x, mouse.y, cursor.transform.position.z);

        Debug.DrawLine(transform.position, mouse, Color.red);

        if (tempoDeDisparo <= 0 && Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bala, saidaDoTiro.position, saidaDoTiro.rotation);
            tempoDeDisparo = intevaloDeDisparo;
        }

        if (tempoDeDisparo > 0)
        {
            tempoDeDisparo -= Time.deltaTime;
        }
    }
}