using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Net.Http;

namespace DnD_5e_Encounter_Calculator
{
    public class DnD5eApiCall
    {
        public static HttpClient DnDAPI { get; set; } = new();

        public static void InitializeAPI()
        {
            DnDAPI = new HttpClient
            {
                BaseAddress = new Uri("https://www.dnd5eapi.co/api/monsters/")
            };
            // DnDAPI.DefaultRequestHeaders.Accept.Clear();
            // DnDAPI.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        internal static async Task<MonsterModel> LoadMonsters(string name)
        {
            string url = "";

            url = $"https://www.dnd5eapi.co/api/monsters/{name}/";

            using (HttpResponseMessage response = await DnD5eApiCall.DnDAPI.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    MonsterModel monster = await response.Content.ReadAsAsync<MonsterModel>();

                    return monster;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

    }
}
