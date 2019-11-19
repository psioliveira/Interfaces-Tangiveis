using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    

    public bool sliding = false;
    public bool slide = false;

    
    private Vector3 moveDirection = Vector3.zero;

    public float speed = 6.0F;
    public float gravity = 20.0F;
    public float rotateSpeed = 10000f;

    [SerializeField]
    private float ofsetGroundGizmoY = 0.1f;
    [SerializeField]
    private float radWall = 0.1f;
    [SerializeField]
    private float ofsetWallGizmoY = 0.1f;
    
    [SerializeField]
    private string layer;
    public AngleConverter angleConv;
    public CharacterController controller;
    [SerializeField]
    private Vector3 radGround = new Vector3(1, 1, 1);

    void Start()
    {
        angleConv = GetComponent<AngleConverter>();
        controller = GetComponent<CharacterController>();

        //Vector3 pos = new Vector3(transform.position.x - ofsetGizmoX, transform.position.y - ofsetGizmoY, transform.position.z - ofsetGizmoZ);
        //go= new GameObject("Collider");
        //go.transform.parent = transform;
        //go.transform.localPosition = pos;
    }

    void Update()
    {
        if (IsOnSlab())
        {
            moveDirection = Vector3.zero;
        }

        UpdateKeyRotation();
        if (!IsOnSlab())
        {
            moveDirection = Vector3.forward;
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }


    private void UpdateKeyRotation()
    {
        if (FoundWall() || IsOnSlab())
        {
            if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
            {
                Vector2 axis = new Vector2(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));
                float angle = Mathf.Round(angleConv.AngleTranslate(axis));

                Quaternion temp = Quaternion.Euler(0, angle, 0);
                transform.rotation = Quaternion.Slerp(transform.rotation, temp, rotateSpeed);
                moveDirection = Vector3.forward;
                moveDirection = transform.TransformDirection(moveDirection);
                moveDirection *= speed;
            }

        }
    }



    internal bool FoundWall()
    {

        Vector3 pos = new Vector3(transform.position.x, transform.position.y - ofsetWallGizmoY, transform.position.z);
        pos = pos + (transform.forward / 2);

        Collider[] col = Physics.OverlapSphere(pos, radWall, LayerMask.GetMask(layer));

        return (col.Length > 0 && col != null);

    }

    internal bool IsOnSlab()
    {

        Vector3 posGrnd = new Vector3(transform.position.x, transform.position.y - ofsetGroundGizmoY, transform.position.z);


        Collider[] colGrnd = Physics.OverlapBox(posGrnd, radGround,Quaternion.LookRotation(Vector3.forward,Vector3.up), LayerMask.GetMask(layer));



        return (colGrnd.Length > 0 && colGrnd != null);

    }


    private void OnDrawGizmosSelected()
    {
        Vector3 posGrng = new Vector3(transform.position.x, transform.position.y - ofsetGroundGizmoY, transform.position.z);
        Vector3 pos = new Vector3(transform.position.x, transform.position.y - ofsetWallGizmoY, transform.position.z);
        pos = pos + transform.forward;

        Gizmos.color = Color.green;
        Gizmos.DrawSphere(pos, radWall);

        Gizmos.color = Color.red;
        Gizmos.DrawCube(posGrng, radGround);
    }

}


