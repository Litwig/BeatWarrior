using UnityEngine;

public class CharacterData : MonoBehaviour
{

    public enum PLAERTYPE { BLACKMAGE, HOLYMAGE, ICEMAGE, MAGE_COUNT}
    public PLAERTYPE playerType = PLAERTYPE.MAGE_COUNT;

    public string PlayerName;
    public string[] PlayerSkill;
    public string[] PlayerSkillName;
    // Start is called before the first frame update
    void Start()
    {
        PlayerSkill = new string[3];
        PlayerSkillName = new string[3];
    }

    // Update is called once per frame
    void Update()
    {
        PlayerInfo();
    }

    private void PlayerInfo()
    {
        switch(playerType)
        {
            case PLAERTYPE.BLACKMAGE:
                PlayerName = "�渶����";
                PlayerSkillName[0] = "�ذ�";
                PlayerSkillName[1] = "��� ��ȯ";
                PlayerSkillName[2] = "�� ����";

                PlayerSkill[0] = "���� ���� �ذ��� ���� �����մϴ�.";
                PlayerSkill[1] = "����� ���� �̿��Ͽ� �����մϴ�.";
                PlayerSkill[2] = "������ ���� �ֵѷ� �����մϴ�.";
                break; 

            case PLAERTYPE.HOLYMAGE:
                PlayerName = "����";
                PlayerSkillName[0] = "���� ȭ��";
                PlayerSkillName[1] = "���� ����";
                PlayerSkillName[2] = "�ż��� ��ü";

                PlayerSkill[0] = "�������� ȭ���� ���� �����մϴ�.";
                PlayerSkill[1] = "���� ������ ���� ���� ��ȯ�մϴ�.";
                PlayerSkill[2] = "�ż����� ��� ��ü�� ����� �����մϴ�.";  
                break;

            case PLAERTYPE.ICEMAGE:
                PlayerName = "��������";
                PlayerSkillName[0] = "���� ����";
                PlayerSkillName[1] = "���̽� ��";
                PlayerSkillName[2] = "���̽� ���Ǿ�";

                PlayerSkill[0] = "�ٴڿ��� �������� �� ���ð� Ƣ��� �����մϴ�.";
                PlayerSkill[1] = "�ܴ��� ������ ���� ����� ���ϴ�.";
                PlayerSkill[2] = "��ī�ο� ������ â�� ������ϴ�.";
                break;

        }
    }
}
