using UnityEngine;

public class Player : MonoBehaviour
{
    //스피드
    public float moveSpeed = 3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //x쪽 값 설정 vector 방향 * 시가ㄴ * 스피드
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        //x쪽 이동 설정
        transform.Translate(distanceX, 0, 0);
        
    }
}
