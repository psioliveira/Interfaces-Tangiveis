using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    public float speed = 6.0F;
    public float gravity = 20.0F;
    public float rotateSpeed = 10000f;

    public bool sliding = false;
    public bool slide = false;

    public AngleConverter angleConv;
    private Vector3 moveDirection = Vector3.zero;
    public CharacterController controller;

    [SerializeField]
    private float radCheck = 0.1f;
    [SerializeField]
    private float ofsetGizmo = 0.1f;
    [SerializeField]
    private string layer;

    void Start()
    {
        angleConv = GetComponent<AngleConverter>();
        controller = GetComponent<CharacterController>();
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
        if (IsOnSlab())
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



    internal bool IsOnSlab()
    {

        Vector3 pos = new Vector3(transform.position.x, transform.position.y - ofsetGizmo, transform.position.z);
        Collider[] col = Physics.OverlapSphere(pos, radCheck, LayerMask.GetMask(layer));

        return (col.Length > 0 && col != null);

    }


    private void OnDrawGizmosSelected()
    {
        Vector3 pos = new Vector3(transform.position.x, transform.position.y - ofsetGizmo, transform.position.z);
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(pos, radCheck);
    }

}


