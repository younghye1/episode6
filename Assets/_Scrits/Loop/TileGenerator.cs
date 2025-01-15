using System.Linq.Expressions;
using System.Numerics;
using NaughtyAttributes;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{
    [Foldout("프리팹")]
    public GameObject tilePrefab;


    public int horzCnt;
    public int vertCnt;
    public int floorCnt;
    public float gap; //타일 사이 거리

    //int n
    //n 만큼 x 축 으로 순차적으로 생성 되게

    [Button]
    void Build()
    {
        // 인스턴스 ? 객체, 오브젝트, 
        // 클래스 틀(Template) 에서 생성한 제품 중 하나

        //for( int h=0; h<horzCnt ; h++)
        //for( int v=0; v<vertCnt ; v++)
        //for( int f=0; f<floorCnt ; f++)
        //for( float g=0f; g<gap ; g++)
        // {
        // Instantiate(tilePrefab, new UnityEngine.Vector3(h,f,v), quaternion.identity);
        // }

GameObject Empty= 
        for (int h = 0; h < horzCnt; h++)
        {
            for (int f = 0; f < floorCnt; f++)
            {
                for (int v = 0; v < vertCnt; v++)
                {

                    Instantiate(tilePrefab, new UnityEngine.Vector3(gap * h, gap * f, gap * v), quaternion.identity);
                object.transform.Setparent(Empty.transform);
                }
            }
        }

    }

}
