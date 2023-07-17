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
                PlayerName = "흑마법사";
                PlayerSkillName[0] = "해골슛";
                PlayerSkillName[1] = "사령 소환";
                PlayerSkillName[2] = "낫 베기";

                PlayerSkill[0] = "죽은 자의 해골을 날려 공격합니다.";
                PlayerSkill[1] = "사령의 힘을 이용하여 공격합니다.";
                PlayerSkill[2] = "죽음의 낫을 휘둘러 공격합니다.";
                break; 

            case PLAERTYPE.HOLYMAGE:
                PlayerName = "사제";
                PlayerSkillName[0] = "빛의 화살";
                PlayerSkillName[1] = "신의 은총";
                PlayerSkillName[2] = "신성한 구체";

                PlayerSkill[0] = "성스러운 화살을 날려 공격합니다.";
                PlayerSkill[1] = "신의 은총을 빌어 빛을 소환합니다.";
                PlayerSkill[2] = "신성력이 담긴 구체를 만들어 공격합니다.";  
                break;

            case PLAERTYPE.ICEMAGE:
                PlayerName = "얼음법사";
                PlayerSkillName[0] = "얼음 가시";
                PlayerSkillName[1] = "아이스 월";
                PlayerSkillName[2] = "아이스 스피어";

                PlayerSkill[0] = "바닥에서 얼음으로 된 가시가 튀어나와 공격합니다.";
                PlayerSkill[1] = "단단한 얼음의 벽을 만들어 냅니다.";
                PlayerSkill[2] = "날카로운 얼음의 창을 뻗어냅니다.";
                break;

        }
    }
}
