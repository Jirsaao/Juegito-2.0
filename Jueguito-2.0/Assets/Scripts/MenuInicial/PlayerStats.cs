using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats Instance;
    private int total_puntos = 0;
    private int total_puntos_actuales = 0;
    private void Awake()
    {
        if (PlayerStats.Instance == null)
        {
            PlayerStats.Instance = this;    
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public int addPuntosActuales(int puntos)
    {
        total_puntos_actuales += puntos;
        return total_puntos_actuales;
    }
    public int getPuntosActuales()
    {
        return total_puntos_actuales;
    }
    public void setPuntosActuales(int puntos)
    {
        total_puntos_actuales = puntos;   
    }
    public int addPuntosTotales(int puntos)
    {
        total_puntos += puntos;
        return total_puntos;
    }
    public int getPuntosTotales()
    {
        return total_puntos;
    }
    public void setPuntosTotales(int puntos)
    {
        total_puntos = puntos;
    }

}