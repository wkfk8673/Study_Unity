using UnityEngine;

/// <summary>
/// ĳ���͸� �����̰� �ϴ� ��ũ��Ʈ
/// </summary>

public class Movement : MonoBehaviour
{
    // C# ���� �ʱ�ȭ ���� ���� moveSpeed �� 0f �� ��� ����.
    public float moveSpeed;
    // Position �� ����
    void Start()
    {
        //���� ��ġ = ���� ��ġ + (0,0,1) 
        //���⼭ this �� AmongUs ĳ���� (prefab)

    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position = this.transform.position + Vector3.forward * moveSpeed;
        //transform.position += Vector3.forward * moveSpeed * Time.deltaTime; // ���� ����ϴ� ���

        // ���� input ������� �ۼ��� �ڵ� 2D������Ʈ���� ��� ����

        if (Input.GetKey(KeyCode.W)) // ������ ���� ���
        {
            transform.position += moveSpeed * Time.deltaTime * Vector3.back; // ���� ����ϴ� ���
        }
        if (Input.GetKey(KeyCode.S)) // �ڷ� ���� ���
        {
            transform.position += moveSpeed * Time.deltaTime * Vector3.back; // ���� ����ϴ� ���
        }
        if (Input.GetKey(KeyCode.A)) // �������� ���� ���
        {
            transform.position += moveSpeed * Time.deltaTime * Vector3.back; // ���� ����ϴ� ���
        }
        if (Input.GetKey(KeyCode.D)) // ���������� ���� ���
        {
            transform.position += moveSpeed * Time.deltaTime * Vector3.back; // ���� ����ϴ� ���
        }

    }
}
