using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject boxPrefab;

    private void Awake()
    {
        //Instantiate(boxPrefab); //원본 오브젝트

        /*
        //Instantiate(GameObject original, Vector3 position, Quaternion rotation);
        //postion으로 위치, rotation으로 회전 설정 가능(위치만 따로 설정X, 3개의 매개변수 모두 사용해야 함)
        Instantiate(boxPrefab, new Vector3(3,3,0), Quaternion.identity);
        Instantiate(boxPrefab, new Vector3(-1, 2, 0), Quaternion.identity);
        */

        //Euler를 이용해 각도값 설정 가능
        Quaternion rotation = Quaternion.Euler(0, 0, 45);
        //Instantiate(boxPrefab, new Vector3(2, 1, 0), rotation);

        //방금 생성된 복제 정보 받아서 설정하기
        GameObject clone = Instantiate(boxPrefab, Vector3.zero, rotation);

        //clone의 이름 변경
        clone.name = "Box001";
        //clone의 색상 변경
        clone.GetComponent<SpriteRenderer>().color = Color.black;
        //위치 변경
        clone.transform.position = new Vector3(2, 1, 0);
        //크기 변경
        clone.transform.localScale = new Vector3(3, 2, 1);
    }
}
