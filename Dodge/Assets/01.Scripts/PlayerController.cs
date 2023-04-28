
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody; // 이동에 사용할 리지드바디 컴포넌트
    public float speed = 8f; // 이동속력

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        // 게임 오브젝트에서 Rigidbody 컴포넌트를 찾아 playerRigidbody에 할당
    }


    void Update()
    {
        //if (Input.GetKey(KeyCode.UpArrow) == true)
        //{
        //    playerRigidbody.AddForce(0f, 0f, speed);
        //    // 위쪽 방향키 입력시 z 방향 힘 주기
        //}

        //if (Input.GetKey(KeyCode.DownArrow) == true)
        //{
        //    playerRigidbody.AddForce(0f, 0f, -speed);
        //    // 아래쪽 방향키 입력시 -z 방향 힘 주기
        //}

        //if (Input.GetKey(KeyCode.RightArrow) == true)
        //{
        //    playerRigidbody.AddForce(speed, 0f, 0f);
        //    // 오른쪽 방향키 입력시 x 방향 힘 주기
        //}

        //if (Input.GetKey(KeyCode.LeftArrow) == true)
        //{
        //    playerRigidbody.AddForce(-speed, 0f, 0f);
        //    // 왼쪽 방향키 입력시 -x 방향 힘 주기
        //}



        // 수평축과 수직축의 입력값을 감지하여 저장
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        // 실제 이동 속도를 입력값과 이동 속력을 사용해 결정
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        // Vector3 속도를 (xSpeed, 0, zSpeed)로 생성
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);

        //리지드바디의 속도에 newVelcovity 할당
        playerRigidbody.velocity = newVelocity;
    }

    public void Die() // 총알이 실행
    {
        gameObject.SetActive(false);
        // 자신의 게임 오브젝트 비활성화

        GameManager gameManager = FindAnyObjectByType<GameManager>(); // 씬에 존재하는 GameManager 타입의 오브젝트를 찾아서 가져오기
        gameManager.EndGame(); // 기져온 GameManager 오브젝트의 EndGame() 메서드 실행
    }
}
