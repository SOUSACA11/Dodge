
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody; // 이동에 사용할 리지드바디 컴포넌트
    public float speed = 8f; // 이동속력

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            playerRigidbody.AddForce(0f, 0f, speed);
            // 위쪽 방향키 입력시 z 방향 힘 주기
        }

        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            playerRigidbody.AddForce(0f, 0f, -speed);
            // 아래쪽 방향키 입력시 -z 방향 힘 주기
        }

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            playerRigidbody.AddForce(speed, 0f, 0f);
            // 오른쪽 방향키 입력시 x 방향 힘 주기
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            playerRigidbody.AddForce(-speed, 0f, 0f);
            // 왼쪽 방향키 입력시 -x 방향 힘 주기
        }

    }

    public void Die()
    {
        gameObject.SetActive(false);
        // 자신의 게임 오브젝트 비활성화
    }
}
