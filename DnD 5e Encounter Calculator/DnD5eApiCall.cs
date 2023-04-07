using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Xml.Linq;

namespace DnD_5e_Encounter_Calculator
{
    //public class DnD5eApiCall
    //{
    //    public static HttpClient DnDAPI { get; set; } = new();

    //    public static void InitializeAPI()
    //    {
    //        DnDAPI = new HttpClient();
    //        Uri BaseAddress = new("https://www.dnd5eapi.co/api/monsters/");
    //        DnDAPI.DefaultRequestHeaders.Accept.Clear();
    //        DnDAPI.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    //    }

    //    internal static async Task<MonsterModel> LoadMonsters(string name)
    //    {
    //        string url = $"https://www.dnd5eapi.co/api/monsters/{ name }/";
    //        using (HttpResponseMessage response = await DnDAPI.GetAsync(url))
    //        {
    //            if (response.IsSuccessStatusCode)
    //            {
    //                MonsterModel monster = await response.Content.ReadAsAsync<MonsterModel>();
    //                return monster;
    //            }
    //            else
    //            {
    //                throw new Exception(response.ReasonPhrase);
    //            }
    //        }
    //    }
    //    async Task LoadResult()
    //    {
    //        var monster = await DnD5eApiCall.LoadMonsters(name);
    //        Console.WriteLine(name);
    //        Console.WriteLine(monster);
    //    }
    //}
}
