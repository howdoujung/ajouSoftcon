using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindObject : MonoBehaviour
{
    //1. hero와 patient가 있음
    //2. patient는 list임 또는 태그 기능을 이용해보기(리스트 말고 obj)
    //3. patient 중 가까운 patient를 찾음
    //4. 네비게이션 기능으로 이동 or vector 이동
    public List<GameObject> patient;
    GameObject hero;
    float shortDis;
    Transform target;
    bool isTrue = false;

    UnityEngine.AI.NavMeshAgent agent;

    void Start()
    {
       
        //patient = new List<GameObject>(GameObject.FindGameObjectsWithTag("patient")); //태그를 이용해 찾음
        //shortDis = Vector3.Distance(gameObject.transform.position, patient[0].transform.position); // 첫번째를 기준으로 잡아주기 

        //hero = patient[0]; // 첫번째를 먼저 

        //foreach (GameObject found in patient)
        //{
        //    float Distance = Vector3.Distance(gameObject.transform.position, found.transform.position);

        //    if (Distance < shortDis) // 위에서 잡은 기준으로 거리 재기, 이 조건이 안 들어가짐
        //    {
        //        hero = found;
        //        shortDis = Distance;
        //        target.transform.position = found.transform.position;
        //        isTrue = true;
        //    }
            
        //}
    }

    private void FindTarget()
    {
        //Enemy[] enemies = FindObjectOfType<Enemy>();
        Transform target = null;
       
    }


    // Update is called once per frame
    void Update()
    {
        if (isTrue == true)
        {
            //agent.SetDestination(target.position);
    
        }
    }

}