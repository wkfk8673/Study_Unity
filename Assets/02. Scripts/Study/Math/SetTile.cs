using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SetTile : MonoBehaviour
{
    public GameObject tilePrefab;
    public int row = 5, col = 5;

    public Button[] buttons;
    public static int turretIndex;

    private void Awake()
    {
        /*
        // Closer 현상 
        // for 문 사용하여 익명함수/람다식이 있는 함수에 지역변수 이용해서 넣을 경우 동작하지 않음
        // 반복문 종료상황에 i 가 5가 되면서 배열의 크기를 넘기기 때문
        // 내부에 다른 매개변수를 담아 사용하면 해결됨
        for (int i = 0; i < buttons.Length; i++) 
        {
            buttons[0].onClick.AddListener(() => ChangeIndex(0));
        }
        */

        for (int i = 0; i < 5; i++)
        {
            int j = i;
            buttons[i].onClick.AddListener(() => ChangeIndex(j));
        }
    }

    private IEnumerator Start()
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                var pos = new Vector3(i, 0, j);
                GameObject Tile = Instantiate(tilePrefab, pos, Quaternion.identity);
                Renderer renderer = Tile.GetComponent<Renderer>();
                if ((i + j) % 2 == 1) // 홀수
                    renderer.material.color = Color.black;
                else
                    renderer.material.color = Color.white;

                yield return new WaitForSeconds(0.1f);
            }
        }
    }

    void ChangeIndex(int index)
    {
        turretIndex = index;
    }
}
