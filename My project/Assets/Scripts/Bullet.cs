using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 1f;
    public GameObject effect;

    void Start()
    {
        
    }

    
    void Update()
    {
        //y축 이동
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    //화면 밖으로 나가면 호출되는 함수
    private void OnBecameInvisible()
    {
        //미사일 지우기
        Destroy(gameObject);


    }


    //Bullet에 작성해도 똑같은 결과
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // trigget 충돌일 경우 한 번 실행
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // 이펙트 생성
            GameObject go = Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(go, 1);

            SoundManager.instance.SoundDie();
        }

        //if (collision.gameObject.CompareTag("Enemy"))
        //{
        //    //적 충돌
        //    //적 삭제
        //    Destroy(collision.gameObject);

        //    //자기자신 삭제
        //    Destroy(gameObject);
        //}

    }

}
