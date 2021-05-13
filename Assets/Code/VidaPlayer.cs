using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaPlayer : MonoBehaviour
{
    public GameObject Furro;
    public float vida = 100;
    public Image barraDeVida;
    public float damage = 10;
    void Update()
    {
        vida = Mathf.Clamp(vida, 0, 100);
        barraDeVida.fillAmount = vida / 100;
        if(vida == 0)
        {
            //Aqui va el método del respawn :3 <2
            Destroy(Furro);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("aquiVaElTag"))
        {
            vida = (vida - damage);
            Debug.Log("Si colisiona pero no baja vida :c");
        }
    }
}
