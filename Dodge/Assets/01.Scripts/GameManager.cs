using UnityEngine;
using UnityEngine.UI; // UI ���� ���̺귯��
using UnityEngine.SceneManagement; // �� ���� ���� ���̺귯��

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText; // ���ӿ��� �� Ȱ��ȭ�� �ؽ�Ʈ ���� ������Ʈ
    public Text timeText; // ���� �ð��� ǥ���� �ؽ�Ʈ ������Ʈ
    public Text recordText; // �ְ� ����� ǥ���� �׽�Ʈ ������Ʈ

    private float surviveTime; // �����ð�
    private bool isGameover; //���ӿ��� ����
    void Start()
    {
        surviveTime = 0;
        isGameover = false;
        // ���� �ð��� ���ӿ��� ���� �ʱ�ȭ
    }

    
    void Update()
    {
        if (!isGameover) // ���ӿ����� �ƴ� ����
        {
            surviveTime += Time.deltaTime; // ���� �ð� ����
            timeText.text = "Time :" + (int)surviveTime; // ������ ���� �ð��� timeText �ؽ�Ʈ ������Ʈ�� �̿��� ǥ��-
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R)) // ���ӿ��� ���¿��� RŰ�� ���� ���
            {
                SceneManager.LoadScene("SampleScene"); // SampleScene ���� �ε�
            }
        }
    }

    public void EndGame() // ���� ������ ���ӿ��� ���·� �����ϴ� �޼���
    {
        isGameover = true; // ���� ���¸� ���ӿ��� ���·� ��ȯ
        gameoverText.SetActive(true); // ���ӿ��� �ؽ�Ʈ ���� ������Ʈ�� Ȱ��ȭ

        float bestTime = PlayerPrefs.GetFloat("BestTime"); // BestTime Ű�� ����� ���������� �ְ� ��� ��������

        if (surviveTime > bestTime)
        {
            bestTime = surviveTime; // �ְ� ��� ���� ���� ���� �ð� ������ ����
            PlayerPrefs.SetFloat("BestTime", bestTime); // ����� �ְ� ����� BestTime Ű�� ����
        }

        recordText.text = "Best Time:" + (int)bestTime; // �ְ� ����� rexordText �ؽ�Ʈ ������Ʈ�� �̿��� ǥ��
    }
}
