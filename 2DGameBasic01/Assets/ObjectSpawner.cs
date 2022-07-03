using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject boxPrefab;

    private void Awake()
    {
        //Instantiate(boxPrefab); //���� ������Ʈ

        /*
        //Instantiate(GameObject original, Vector3 position, Quaternion rotation);
        //postion���� ��ġ, rotation���� ȸ�� ���� ����(��ġ�� ���� ����X, 3���� �Ű����� ��� ����ؾ� ��)
        Instantiate(boxPrefab, new Vector3(3,3,0), Quaternion.identity);
        Instantiate(boxPrefab, new Vector3(-1, 2, 0), Quaternion.identity);
        */

        //Euler�� �̿��� ������ ���� ����
        Quaternion rotation = Quaternion.Euler(0, 0, 45);
        //Instantiate(boxPrefab, new Vector3(2, 1, 0), rotation);

        //��� ������ ���� ���� �޾Ƽ� �����ϱ�
        GameObject clone = Instantiate(boxPrefab, Vector3.zero, rotation);

        //clone�� �̸� ����
        clone.name = "Box001";
        //clone�� ���� ����
        clone.GetComponent<SpriteRenderer>().color = Color.black;
        //��ġ ����
        clone.transform.position = new Vector3(2, 1, 0);
        //ũ�� ����
        clone.transform.localScale = new Vector3(3, 2, 1);
    }
}
