using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text contador;
    public TMP_Text contadorvida;
    public DineroManager dineroManager;
    public VidaManager vidaManager;
    float plata;
    float vida;

    private void Start()
    {
        dineroManager = FindObjectOfType<DineroManager>();
        vidaManager = FindObjectOfType<VidaManager>();
    }

    private void Update()
    {
        plata = dineroManager.playerMoney;
        vida = vidaManager.playerVida;
        contador.text = "Plata" + plata.ToString();
        contadorvida.text = "Vida" + vida.ToString();
    }
}