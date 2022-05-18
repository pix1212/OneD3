using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpBarScript : MonoBehaviour
{
    [SerializeField] GameObject m_goPrefab = null;  // 프리팹 변수 선언

    List<Transform> m_objectList = new List<Transform>();   // 몬스터 위치 담을 리스트
    List<GameObject> m_hpBarList = new List<GameObject>();

    Camera m_cam = null;


    public void UsingHpBar()
    {
        m_cam = Camera.main;

        GameObject[] t_objects = GameObject.FindGameObjectsWithTag("Enemy"); // 임시배열에 채워넣기

        for (int i = 0; i < t_objects.Length; i++)
        {
            m_objectList.Add(t_objects[i].transform);
            GameObject t_hpBar = Instantiate(m_goPrefab, t_objects[i].transform.position,Quaternion.identity, transform); // 몬스터 위치에 프리팹 생성

            m_hpBarList.Add(t_hpBar); // 생성된 객체는 hpBar 리스트에 추가(이거 플레이어, 몬스터 위치변경할때 한번 써보기)


        }

        
    }

    public void Update()
    {
        for(int i = 0; i < m_objectList.Count; i++)
        {
            m_hpBarList[i].transform.position = m_cam.WorldToScreenPoint(m_objectList[i].position + new Vector3(0, 1.15f, 0));
        }
    }

}
