using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // �̗�
    private int power = 25; // �U����
    private int mp = 53;

    // �U���p�̊֐�
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    // �h��p�̊֐�
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        // �c��hp�����炷
        this.hp -= damage;
    }
    
    public void Magic( )
    {
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + mp);

        }

        else
        {
            Debug.Log("mp������Ȃ����ߖ��@���g���Ȃ�");
        }
    }

}

public class Test2 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {  
        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();

        // �U���p�̊֐����Ăяo��
        lastboss.Attack();
        // �h��p�̊֐����Ăяo��
        lastboss.Defence(3);

        for (int n = 0; n < 11; n++)
        {
            lastboss.Magic();
        }
    }

  

    // Update is called once per frame
    void Update()
    {
        
    }
}
