using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DnD_5e_Encounter_Calculator
{
    public class DnD5eApiCall
    {
        public static HttpClient DnDAPI { get; set; } = new();

        public static void InitializeAPI()
        {
            DnDAPI = new HttpClient();
            DnDAPI.BaseAddress = new Uri("https://www.dnd5eapi.co/api/monsters/");
           // DnDAPI.DefaultRequestHeaders.Accept.Clear();
           // DnDAPI.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task LoadMonsters(string monster)
        {
            string url = "";

            url = $"https://www.dnd5eapi.co/api/monsters/{monster}/";

            using (HttpResponseMessage response = await DnD5eApiCall.DnDAPI.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {

                }
            }
        }

    }
}
