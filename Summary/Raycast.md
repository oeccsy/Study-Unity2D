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
`RaycastHit2D rayHit = Physics2D.Raycast(gameObject.transform.positon, Vector3.down, 1, LayerMask.GetMask("Platform"));`  
rayHit ��ü�� ���̿� �ݶ��̴��� �浹������ �����Ѵ�.  
(collider, distance, rigidbody, transform��)  

LayerMask.GetMask("Platform") ���ڸ� ������, "Platform" ���̾��� ������Ʈ�� ��ĵ�� �� �� �ִ�.

```C#

        Debug.DrawRay(gameObject.transform.position, Vector3.down, new Color(0, 1, 0));

        RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, Vector3.down, 1, LayerMask.GetMask("Platform"));

        if (rayHit.collider != null)
        {
                Debug.Log(rayHit.collider.name);
        }       
```


### [����ũ]
* https://www.youtube.com/watch?v=2SikOdH7xvQ&list=PLO-mt5Iu5TeZGR_y6mHmTWyo0RyGgO0N_&index=4
* https://docs.unity3d.com/kr/530/ScriptReference/Physics2D.Raycast.html
* https://docs.unity3d.com/kr/530/ScriptReference/RaycastHit2D.html
* https://chameleonstudio.tistory.com/63
