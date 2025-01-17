using NaughtyAttributes;
using UnityEngine;

public class RandomGenerator : MonoBehaviour
{

    public int numerator; //분자
    public int denominator;//분모
    [ReadOnly]public float percent; //분자/분모 * 100f


    [Button]
    void generateByRage()
    {
        float probability = (float)numerator / denominator;
       percent= probability * 100f;

        //랜덤 발생후, 성공 실패 판단
        float rnd = Random.Range(0.0f,100.0f);

        if ( rnd < percent ) //성공 영역
        {
            Debug.Log("성공 !! ");
        }
        else //실패영역
        {
            Debug.Log("실패");
        }
        
    
    }

}
