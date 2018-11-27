using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadController : MonoBehaviour {

    public GameObject[] listObatancle;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void CreateObstancle()
    {
        // Vị trí xuất hiện vật cản
        Vector3 posCreate = transform.position;
        // Thứ tự của Obstancle trong  listObstancle
        // Lấy ngẫu nhiên từ thứ tự 0 -> thứ tự cuối cùng là listObatancle.Length
        int index = Random.Range(0, listObatancle.Length);
        // Xuất đối tượng tại thứ tự index ra vị trí posCreate.
        GameObject obj;
        obj = Instantiate(listObatancle[index], posCreate, Quaternion.identity);
        // gán đối tượng vừa tạo, là con của Road hiện tại.
        obj.transform.parent = transform;
    }
}
