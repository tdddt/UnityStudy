using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    [SerializeField]
    private GameObject moveObject;
    [SerializeField]
    private Vector3 moveDirection;
    private float moveSpeed;

    private void Awake()
    {
        moveSpeed = 5.0f;
    }

    //�浹�� �Ͼ�� ���� 1ȸ ȣ��
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //moveObject ������ ���������� ����
        moveObject.GetComponent<SpriteRenderer>().color = Color.black;
    }

    //�浹�� �����Ǵ� ���� �� ������ ȣ��
    private void OnTriggerStay2D(Collider2D collision)
    {
        //moveObject�� moveDirection�������� �̵�
        moveObject.transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }

    //�浹�� ����Ǵ� ���� 1ȸ ȣ��
    private void OnTriggerExit2D(Collider2D collision)
    {
        //moveObject�� ������ ������� ����
        moveObject.GetComponent<SpriteRenderer>().color = Color.white;

        //moveObject�� ��ġ�� (0,4,0)���� ����
        moveObject.transform.position = new Vector3(0, 4, 0);
    }
}
