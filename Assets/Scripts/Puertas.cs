using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puertas : MonoBehaviour
{
    public GameObject Camera;
    public Vector3 PosicionCamara;
    public GameObject Player;
    public Transform PosicionFutura;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("entre");
        if (collision.gameObject.CompareTag("Player"))
        {

            // Obtener el componente Transform del objeto Player
            Transform playerTransform = Player.GetComponent<Transform>();

            // Cambiar la posición del objeto Player a la posición de PosicionFutura
            playerTransform.position = PosicionFutura.position;

            Transform cameraTransform = Camera.GetComponent<Transform>();
            cameraTransform.position = PosicionCamara;
        }
    }

}
