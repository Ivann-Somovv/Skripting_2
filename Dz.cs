using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //������� ��� �������� �������
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //������� ��� ������ ����� crickets
        print(crickets);
    }
}
