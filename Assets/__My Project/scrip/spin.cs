using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
    
{
   public float zSpeed;
   public Transform pencil;
   public float moveSpeed;
   public float moveDistance;
    
   private float movedDistance;
   private bool isMoving = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
            }
        }
    }

   public void SetSpeed(float newSpeed)
    {
        zSpeed = newSpeed;
    }
  
}
