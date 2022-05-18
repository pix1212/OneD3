using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    static BattleManager _instance;

    public static BattleManager instance{ get { return _instance;}}

    void Awake()
    {
        if(_instance == null)
            _instance = this;
    }

    public Enemy[] enemy;

    public List<Oder> oderCharaters;

    
    void Start() 
    {
        oderCharaters = new List<Oder>();
    }

    public void StartBattle()
    {

        //TODO: oderCharaters에다가 캐릭터&몬스터들 넣어주기.
        
        
        for(int i = 0; i < 4; i++)
        {
            oderCharaters.Add(PartySystem.instance.heros[i]);
        }


        //for(int i = 0; i < 3; i++)
        //{
        //    enemy[i].speed = Random.Range(5,9);
        //    oderCharaters.Add(enemy[i]);
        //}
//
        oderCharaters = oderCharaters.OrderBy(x => x.speed).ToList();
        foreach (Oder t in oderCharaters)
            Debug.Log(t.name + ": "+ t.speed);
        
        /*
        testData = testData.OrderBy(x => x.data).ToList();
        foreach (TestData t in testData)
         */
        
    }


    public void AddOder(Jobs unit)
    {
        oderCharaters.Add(unit);
        int a = unit.speed;
        //unit.Shot();
        

    }


    
    
}
