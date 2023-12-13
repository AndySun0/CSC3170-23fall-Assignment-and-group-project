using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LibrarySystem
{
    //该静态类用于存放一些公用操作和变量
    public static class PublicOperations
    {
        //userID全局变量
        public static string myUID; //userID
        //打开其他窗口
        public static void OpenForm(Form currentForm, Form newForm)
        {
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.Show();
            currentForm.Hide(); //注意，本程序使用Hide，其他时候应该close以节省内存
        }

        //网络模块
        public static async Task<Dictionary<string, List<string>>> NetWork(string requestName, Dictionary<string, List<string>> values)
        {
            var client = new HttpClient();   //创建HttpClient对象
            string json = JsonConvert.SerializeObject(values); //将字典转换为JSON字符串
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json"); //告诉服务器你传过去的是Json格式字符串

            string serverIP= "http://localhost:5000/";
            string path = serverIP + requestName;
            var response = await client.PostAsync(path, content);  //向后端发送HTTP POST请求 

            var responseString = await response.Content.ReadAsStringAsync();
            var responseDict = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(responseString);
            return responseDict; //返回的是字典类型
        }
        //发送：dict->string(Json Format)->Http Object;接收：string(Json Format)->dict

    }
}
