using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float zSpeed=360f;
    public Transform pencil;
    public float moveSpeed=0.05f;
    public float moveDistance=0.2f;

    private float movedDistance=0f;
    private bool isMoving = false;
    private bool isRotating = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        if (isRotating)
        {
        transform.Rotate(0f,0f,zSpeed * Time.deltaTime);
        }
       

        if(pencil != null && isMoving)
        {
            float moveStep = moveSpeed *  Time.deltaTime;
            pencil.Translate(0f,0f,moveStep,Space.Self);
            movedDistance +=moveStep;

            if (movedDistance>= moveDistance)
            {
                isMoving = false;
            }
        }
    }
    void OnMouseDown()
    {
        isRotating =!isRotating;
        if(isRotating)
        {
            isMoving=true;
            movedDistance=0f;
        }
        else
        {
            isMoving=false;
        }
    }

}
