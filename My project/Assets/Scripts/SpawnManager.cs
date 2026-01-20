using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public bool enableSpawn = false;
    public GameObject enemy; // prefab으로 만든 적을 가져온다


    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f, 1.5f);
    }

    //적을 생성하는 함수
    public void SpawnEnemy()
    {
        float randomX = Random.Range(-2.5f, 2.5f); //적이 나타날 x좌표를 랜덤으로 생성한다

        if (enableSpawn)
        {
            Instantiate(enemy, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);
        }
                
    }
   
    //void Spawn()
    //{
    //    Instantiate(Enemy, transform.position, Quaternion.identity);
    //}

    void Update()
    {
        ////움직임을 변수로 만들기
        //float x = moveSpeed * Time.deltaTime;


        //if 
        ////움직이기
        //transform.Translate(x, 0, 0);
    }

    
}
