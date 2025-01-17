using UnityEngine;
using NaughtyAttributes;

public class Random1 : MonoBehaviour
{
    [Button] //확률형 아이템
    void RandomRate() 
    {
        //float 형 1 개()
        float result = Random.value * 100f;
        Debug.Log($"랜덤(value)={result}");
        if( result < 5f)
        {
            Debug.Log("당첨");
        }
        else
        {
            Debug.Log("실패");
        }


    }
}
