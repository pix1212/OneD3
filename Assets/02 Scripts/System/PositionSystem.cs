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

    public GameObject heroList;
    public GameObject enemyList;

    [SerializeField] GameObject[] m_enemyPrefab;
    List<GameObject> m_enemySelect = new List<GameObject>();

    public Transform[] heroPosition;
    
    public Transform[] enemyPosition;



    public void HeroSpwan()
    {
        for(int i = 0; i < PartySystem.instance.heros.Length; i++)
        {
            for(int j = 0; j < heroPosition.Length; j++ )
            {
                if(j == i)
                Instantiate(PartySystem.instance.heros[i], heroPosition[j]).transform.parent = heroList.transform;        
            }
            
        }

    }

    public void EnemyRandomSpwan()
    {
        

        
            for(int j = 0; j < enemyPosition.Length; j++ )
            {
                var element = m_enemyPrefab[Random.Range(0, m_enemyPrefab.Length)];

                m_enemySelect.Add(element);

                Instantiate(element, enemyPosition[j]).transform.parent = enemyList.transform;      
            }

            

    }
}
