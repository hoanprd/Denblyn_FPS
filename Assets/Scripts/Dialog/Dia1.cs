using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dia1 : MonoBehaviour
{
    public GameObject Image1;
    public GameObject Image2;
    public GameObject DiaText;
    public int dem = 1;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            dem++;
        }

        if (dem == 1)
        {
            DiaText.GetComponent<Text>().text = "Sau Thế chiến II, phát xít Nhật Bản đã thất bại.";
        }
        if (dem == 2)
        {
            DiaText.GetComponent<Text>().text = "Nhưng có một số tin đồn thất thường về một lâu đài Osas ở Nhật Bản đang nghiên cứu vũ khí chiến tranh.";
        }
        if (dem == 3)
        {
            DiaText.GetComponent<Text>().text = "Vào thời điểm này, một người lính Mỹ dũng cảm đã đảm nhận nhiệm vụ đột nhập vào thành trì này.";
        }
        if (dem == 4)
        {
            Image1.SetActive(false);
            Image2.SetActive(true);
            DiaText.GetComponent<Text>().text = "Alia: Morro! Anh có nghe thấy tôi không?";
        }
        if (dem == 5)
        {
            DiaText.GetComponent<Text>().text = "Morro: Ừm! Tôi nghe đây, cũng như đã sẵn sàng cho nhiệm vụ này.";
        }
        if (dem == 6)
        {
            DiaText.GetComponent<Text>().text = "Alia: Tôi không ngờ anh lại chấp nhận nhiệm vụ bất khả thi này, đặc biệt là một người lính đã nghỉ hưu sau Thế chiến thứ II.";
        }
        if (dem == 7)
        {
            DiaText.GetComponent<Text>().text = "Morro: Chỉ vì nghe tin đồn họ nghiên cứu vũ khí chiến tranh nên tôi mới đến để xác nhận.";
        }
        if (dem == 8)
        {
            DiaText.GetComponent<Text>().text = "Alia: Nhưng chưa từng có ai trở về sau khi đột nhập vào lâu đài đó.";
        }
        if (dem == 9)
        {
            DiaText.GetComponent<Text>().text = "Morro: Alia, tôi không còn gì để mất sau chiến tranh nữa.";
        }
        if (dem == 10)
        {
            DiaText.GetComponent<Text>().text = "Alia: Cũng có bản lĩnh đấy.";
        }
        if (dem == 11)
        {
            DiaText.GetComponent<Text>().text = "Morro: Được rồi, tôi đang ở bên ngoài ngôi làng, tôi sẽ gọi lại khi vào trong lâu đài.";
        }
        if (dem == 12)
        {
            DiaText.GetComponent<Text>().text = "Alia: Chúc may mắn!";
        }
        if (dem == 13)
        {
            SceneManager.LoadScene("Level000");
        }
    }
}
