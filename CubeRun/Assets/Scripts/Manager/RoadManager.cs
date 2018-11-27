using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour {

    public GameObject road;
    public int length;
    private Vector3 posBegin;
    
	void Start () {
        CreateRoads();
	}
	void Update () {
		
	}
    void CreateRoads()
    {
        // Vị trí xuất hiện của road đầu tiên là chính tọa độ của RoadManager
        posBegin = transform.position;
        for (int i = 0; i < length; ++i)
        {
            GameObject obj;
            // Xuất đối tượng nào (GameObject), tại vị trí nào (Vector3), không quay(Quaternion.identity)
            obj = Instantiate(road, posBegin, Quaternion.identity);
            // Lệnh cho obj tạo Obstancle
            obj.GetComponent<RoadController>().CreateObstancle();
            // gán đối tượng vừa sinh ra làm con của RoadManager
            obj.transform.parent = transform;
            // gán tên cho Road mới sinh
            obj.name = "Road " + i;
            // cập nhật cho vị trí tiếp theo
            // mõi road cách nhau 2 đơn vị
            posBegin.z += transform.localScale.z;
        }
    }
}
