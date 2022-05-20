using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class BattleManager : MonoBehaviour
{
    #region 싱글톤 
    static BattleManager _instance;

    public static BattleManager instance{ get { return _instance;}}

    void Awake()
    {
        if(_instance == null)
            _instance = this;
    }

    #endregion

    public GameObject playerPrefab;
	public GameObject enemyPrefab;

    public Transform playerBattleStation;
	public Transform enemyBattleStation;

    Unit playerUnit;
	Unit enemyUnit;

    public BattleState state;

    void StartBattle()
    {
		state = BattleState.START;
		//StartCoroutine(SetupBattle());
    }

    void SetupBattle()
    {

    }



















    public Enemy[] enemy;

    public List<Oder> oderCharaters;

    
    void Start() 
    {
        oderCharaters = new List<Oder>();
    }

    
    public void StartBattle2()
    {

        //TODO: oderCharaters에다가 캐릭터&몬스터들 넣어주기.
        
        
        for(int i = 0; i < 4; i++)
        {
            //oderCharaters.Add(PartySystem.instance.heros[i]);
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



   


    
    
}
