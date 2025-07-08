using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SacaVida : MonoBehaviour
{

    public int danio = 10;
    public VidaManager vidaManager;

    void Start()
    {
        vidaManager = FindObjectOfType<VidaManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (vidaManager.UpdateHealth(-danio) == true)
            {
                Destroy(gameObject);
            }
            else { }
        }
    }
}
