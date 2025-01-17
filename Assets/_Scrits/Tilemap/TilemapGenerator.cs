using System.Security.Cryptography.X509Certificates;
using NaughtyAttributes;
using Unity.Collections;
using UnityEditorInternal;
using UnityEngine;

public class TilemapGenerator : MonoBehaviour
{
    [Header("하이트맵 소스")]
    [SerializeField] Texture2D heightmap;


    [Button]
    void GetInfo()
    {
        float w = heightmap.width;  //Horizontal
        float h = heightmap.height; //vertical
        Debug.Log($"widht={w},height={h}");
        for (int x = 0; x <= w; x++)
        {
            for (int y = 0; y <= h; y++)
            {
                Color col = heightmap.GetPixel( x, y );
                Debug.Log($"컬러r={col.r}");
            
                {
                    col.r= y;   

                
                    {
                        col.r= y;     
                    }
                }
            }
        }


        //col.r 이 0.5 기준으로 크면 (x,y,z) y를 1로 판단한다
        //col.r 이 0.5 기준으로 작으면 (x,y,z) y를 0으로 판단한다
        //Instantiate 함수를 활용해서 Cube 프리팹을 생성한다.
    }
}


