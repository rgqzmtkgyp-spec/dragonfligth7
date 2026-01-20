using System;
using UnityEngine;
using UnityEngine.Playables;

public class Enemy : MonoBehaviour
{
    //속도
    public float moveSpeed = 1.3f;

    
    void Start()
    {
        //SingletonTest.instance.EnemySound();
    }

    
    void Update()
    {
        //움직임을 변수로 만들기
        float distanceY = moveSpeed * Time.deltaTime;

        //움직이기
        transform.Translate(0, -distanceY, 0);
    }

    //컨트롤 + 쉬프트 + m
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // trigget 충돌일 경우 한 번 실행

        //이게 좀 더 안전한 방법
        if (collision.gameObject.CompareTag("Bullet"))
        {
            //미사일 충돌
            //미사일 삭제
            Destroy(collision.gameObject);

            //자기자신 삭제
            Destroy(gameObject);
        }

        //방법 2
        //if(collision.tag == "Bullet")
        //{

        //}
    }

    ////is trigger 없이 충돌(되는지 확인 안해봄)
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Bullet")
    //    {
    //        Destroy(collision.gameObject);

    //        Destroy(gameObject);
    //    }
    //}





}
