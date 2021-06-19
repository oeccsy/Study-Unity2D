# Raycast (Raycast2D, RaycastHit2D)

�ݶ��̴� �浹���� �����ϰ� ���Ǵ� ����̴�.  
���ϴ� �������� Ray�� ������ Ray�� �ݶ��̴��� �浹�� �����ϴ� ����̴�.

---

## �ڵ�


### Debug.DrawRay()
`Debug.DrawRay(Vector3 origin, Vector3 dir, Color color, float duration);`  
`Debug.DrawRay(gameObject.transform.position, Vector3.down, new Color(0, 1, 0));`  
������ �󿡼� Ray�� �׷��ִ� �Լ�  
origin���� dir �������� Color ������ ���̸� �׷�����.  

### Physics2D.Raycast()
`Physics2D.Raycast(Vector3 origin, Vector3 dir, float maxDistance = Mathf.Infinity, int layerMask = DefualtRaycastLayers);`  
���� ���̸� ����� ���� �Լ�    
origin���� dir�������� ���̸� ������.  
�̶� maxDistance ���� ������ � �ݶ��̴��� ���̰� �浹������ RaycastHit2D�� return�Ѵ�.  
LayerMask�� ���� ĳ���� �� �ݶ��̴��� ���������� �����ϴµ� ���ȴ�.  

### RaycastHit2D
`RaycastHit2D rayHit = Physics2D.Raycast(gameObject.transform.positon, Vector3.down, 1);`  
rayHit ��ü�� ���̿� �ݶ��̴��� �浹������ �����Ѵ�.  
(collider, distance, rigidbody, transform��)  

```C#

        Debug.DrawRay(gameObject.transform.position, Vector3.down, new Color(0, 1, 0));

        RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, Vector3.down, 1, LayerMask.GetMask("Platform"));

        if (rayHit.collider != null)
        {
                Debug.Log(rayHit.collider.name);
        }       
```