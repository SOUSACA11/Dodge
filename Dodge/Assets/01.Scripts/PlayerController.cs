
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody; // �̵��� ����� ������ٵ� ������Ʈ
    public float speed = 8f; // �̵��ӷ�

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        // ���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� playerRigidbody�� �Ҵ�
    }


    void Update()
    {
        //if (Input.GetKey(KeyCode.UpArrow) == true)
        //{
        //    playerRigidbody.AddForce(0f, 0f, speed);
        //    // ���� ����Ű �Է½� z ���� �� �ֱ�
        //}

        //if (Input.GetKey(KeyCode.DownArrow) == true)
        //{
        //    playerRigidbody.AddForce(0f, 0f, -speed);
        //    // �Ʒ��� ����Ű �Է½� -z ���� �� �ֱ�
        //}

        //if (Input.GetKey(KeyCode.RightArrow) == true)
        //{
        //    playerRigidbody.AddForce(speed, 0f, 0f);
        //    // ������ ����Ű �Է½� x ���� �� �ֱ�
        //}

        //if (Input.GetKey(KeyCode.LeftArrow) == true)
        //{
        //    playerRigidbody.AddForce(-speed, 0f, 0f);
        //    // ���� ����Ű �Է½� -x ���� �� �ֱ�
        //}



        // ������� �������� �Է°��� �����Ͽ� ����
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        // ���� �̵� �ӵ��� �Է°��� �̵� �ӷ��� ����� ����
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        // Vector3 �ӵ��� (xSpeed, 0, zSpeed)�� ����
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);

        //������ٵ��� �ӵ��� newVelcovity �Ҵ�
        playerRigidbody.velocity = newVelocity;
    }

    public void Die() // �Ѿ��� ����
    {
        gameObject.SetActive(false);
        // �ڽ��� ���� ������Ʈ ��Ȱ��ȭ

        GameManager gameManager = FindAnyObjectByType<GameManager>(); // ���� �����ϴ� GameManager Ÿ���� ������Ʈ�� ã�Ƽ� ��������
        gameManager.EndGame(); // ������ GameManager ������Ʈ�� EndGame() �޼��� ����
    }
}
