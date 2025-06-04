using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public class DineroManager : MonoBehaviour
=======
public class NewBehaviourScript : MonoBehaviour
>>>>>>> 60dd66648c4564b6b9774aa91ebd17a336b93f1e
{
    public float playerMoney;

    public void UpdateMoney(float amount)
    {
<<<<<<< HEAD

=======
>>>>>>> 60dd66648c4564b6b9774aa91ebd17a336b93f1e
        if (playerMoney + amount < 0)
        {
            //impedir compra
        }
        else
        {
            playerMoney += amount;
        }
    }
}
