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
    private float ofsetWallGizmoX = 0.1f;
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


    }

    void Update()
    {
        if (FoundWall())
        {
            moveDirection = Vector3.zero;
        }

        UpdateKeyRotation();
        if (!FoundWall())
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
        if (FoundWall())
        {
            if (Input.GetAxis("Vertical") != 0)
            {
                Vector2 axis = new Vector2(Input.GetAxis("Vertical"), 0);
                float angle = Mathf.Round(angleConv.AngleTranslate(axis));

                Quaternion temp = Quaternion.Euler(0, angle, 0);
                transform.rotation = Quaternion.Slerp(transform.rotation, temp, rotateSpeed);
                moveDirection = Vector3.forward;
                moveDirection = transform.TransformDirection(moveDirection);
                moveDirection *= speed;
            }
            else if (Input.GetAxis("Horizontal") != 0)
            {
                Vector2 axis = new Vector2(0, Input.GetAxis("Horizontal"));
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
        pos = pos + (ofsetWallGizmoX * transform.forward / 2);

        Collider[] col = Physics.OverlapSphere(pos, radWall, LayerMask.GetMask(layer));

        return (col.Length > 0 && col != null);

    }




    private void OnDrawGizmosSelected()
    {
        Vector3 pos = new Vector3(transform.position.x, transform.position.y - ofsetWallGizmoY, transform.position.z);
        pos = pos + (ofsetWallGizmoX * transform.forward / 2);

        Gizmos.color = Color.green;
        Gizmos.DrawSphere(pos, radWall);
    }

}


