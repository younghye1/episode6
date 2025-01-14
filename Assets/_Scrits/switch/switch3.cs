using NaughtyAttributes;
using UnityEngine;

public class switch3 : MonoBehaviour
{
    public Color colorGREEN;
    public Color colorYELLOW;
    public Color colorRED;
    public Color color0;

    public int hp;

    public int Damage1;
    public int Heal1;

    [Button]
    void changeColor()
    {
        Color col;

        if (hp > 70)
        {
            col = colorGREEN;
        }
        else if (hp > 40)
        {
            col = colorYELLOW;
        }

        else if (hp > 0)
        {
            col = colorRED;
        }
        else
        {
            col = color0;
        }

       //GetComponent<MeshRenderer>().material.color = col;
        GetComponent<MeshRenderer>().material.SetFloat("_Color", col );
        GetComponent<MeshRenderer>().material.SetFloat("_Fade", (float) hp/100 );
    }

    [Button]
    void ChangeColorSwitch()
    {
        Color col = hp switch
        {
            >70=> colorGREEN,
            >40=> colorYELLOW,
            >0=>colorRED,
            _=>color0
        };
        GetComponent<MeshRenderer>().material.color = col;
    
    }

    [Button]
    void Damage()
    {
        hp = hp - Damage1; // hp -= Damage1; 이렇게 쓰는거랑 같다

        //hp가 최소 0에서 멈추게 하기
        if (hp<= 0 ) //hp 가 0 이하 입니까? True면 0고정, False면 패스
            hp=0;
        

        //삼항연산  방식 hp = hp <= 0 ? hp = 0 : hp;

        Debug.Log(hp);
        changeColor(); //호출
    }
    
    [Button]
    void Heal()
     {
       hp = hp + Heal1;
       if (hp>= 100 )
            hp=100;
       Debug.Log(hp);
       changeColor();
     }

}

