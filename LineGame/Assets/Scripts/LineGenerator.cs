using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineGenerator : MonoBehaviour
{
 
    
    public GameObject Obj;
    public Transform starPos, EndPos;
    public List<AssetsLine> AssetsLines;
    int randomIndex;
    
    // Start is called before the first frame update
    void Start()
    {

        Init();

       

    }
    void RandomAssets()
    {
        randomIndex = Random.Range(0, AssetsLines.Count);
       
        
    }
    
    

    private void Init()
    {
        RandomAssets();

         GameObject a = Instantiate(Obj, starPos.position, starPos.rotation);
        a.GetComponent<LineController>().GetInfo(AssetsLines[randomIndex].speed, EndPos, AssetsLines[randomIndex].InitialColor, AssetsLines[randomIndex].index);

        
        StartCoroutine(CreateLine(AssetsLines[randomIndex].time));
      


    }
   

    IEnumerator CreateLine(float t)
    {
        yield return new WaitForSeconds(t);
        Init();
    }


}
