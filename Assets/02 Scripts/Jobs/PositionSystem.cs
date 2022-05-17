using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionSystem : MonoBehaviour
{
   static PositionSystem _instance;

    public static PositionSystem instance{ get { return _instance;}}

    void Awake()
    {
        if(_instance == null)
            _instance = this;
    }

    public Transform[] heroPosition;
    public Transform[] enemyPosition;

    public void HeroSpwan()
    {
        Instantiate(PartySystem.instance.heros[0], heroPosition[0]);
        Instantiate(PartySystem.instance.heros[1], heroPosition[1]);
        Instantiate(PartySystem.instance.heros[2], heroPosition[2]);
        Instantiate(PartySystem.instance.heros[3], heroPosition[3]);
    }

    public void EnemySpwan()
    {
        
    }
}
