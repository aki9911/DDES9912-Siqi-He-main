using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
    
{
   public float zSpeed;
   public Transform pencil;
   public float moveSpeed;
   public float moveDistance;

   public GameObject oldTip;
   public GameObject newTip;
    
   private float movedDistance;
   private bool isMoving = false;
   private bool isReturning = false;
   private bool tipReplaced = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(oldTip!=null)oldTip.SetActive(true);
        if(newTip!=null)newTip.SetActive(false);
    }
   public void pencilSpeed(float nSpeed)
   {
    moveSpeed = nSpeed;
   }
   public void pencilDistance(float dSeep)
   {
    moveDistance = dSeep;
   }
    public void StartPencilMove()
   {
    movedDistance = 0f; 
    isMoving = true;
    isReturning = false;
    tipReplaced = false;  
   }
    public void Stop()
    {
      isMoving = false;
      if(movedDistance>0f)
      {
        isReturning = true;
      }
    }
    // Update is called once per frame
    void Update()
    { 
     transform.Rotate(0f,0f,zSpeed * Time.deltaTime);
        
    

        if(pencil != null && isMoving)
        {
            float moveStep = moveSpeed * Time.deltaTime;
            pencil.Translate(0f,0f,moveStep,Space.Self);
            movedDistance +=moveStep;

            if (movedDistance>= moveDistance)
            {
                isMoving = false;
                ReplaceTip();
            }
        }
        else if (isReturning)
        {
            float moveStep = moveSpeed *  Time. deltaTime;
            if(moveStep>movedDistance)
               moveStep = moveDistance;

             pencil.Translate(0f,0f,-moveStep,Space.Self);
             movedDistance-= moveStep;
             if (movedDistance<=0f) 
             {
                movedDistance = 0f;
                isReturning =   false;
             } 
        }
    }

   public void SetSpeed(float newSpeed)
    {
        zSpeed = newSpeed;
    }

    private void ReplaceTip()
    {
        if(tipReplaced)return;

        if(oldTip!=null)oldTip.SetActive(false);
        if(newTip!=null)newTip.SetActive(true);

        tipReplaced=true;    
    }
  
}
