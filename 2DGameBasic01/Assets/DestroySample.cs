using UnityEngine;

public class DestroySample : MonoBehaviour
{
    [SerializeField]
    private GameObject playerObject;

    private void Awake()
    {
        //playerObject ���ӿ�����Ʈ�� "PlayerController"������Ʈ ����
        //Destroy(playerObject.GetComponent<PlayerController>());

        //playerObject ���ӿ�����Ʈ�� ����
        //Destry(playerObject);

        //playerObject ���ӿ�����Ʈ�� 2�� �ڿ� ����
        Destroy(playerObject, 2.0f);
    }
}
