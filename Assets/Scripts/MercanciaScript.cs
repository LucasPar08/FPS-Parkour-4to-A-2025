using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
<<<<<<< HEAD
    public int precio = 10;
=======
    public int precio;
>>>>>>> 60dd66648c4564b6b9774aa91ebd17a336b93f1e
    public DineroManager dineroManager;

    void Start()
    {
        dineroManager = FindObjectOfType<DineroManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
<<<<<<< HEAD
            //restar precio al dinero del player
            dineroManager.UpdateMoney(-precio);
            Destroy(gameObject);
        } 
=======
            dineroManager.UpdateMoney(precio);
            Destroy(gameObject);
        }
>>>>>>> 60dd66648c4564b6b9774aa91ebd17a336b93f1e
    }
}
