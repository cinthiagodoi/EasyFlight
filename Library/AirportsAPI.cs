using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using System.Text.Json.Nodes;
using System.Reflection.Metadata.Ecma335;
using System.Diagnostics.CodeAnalysis;

namespace Library;

public class AirportsAPI
{
   
    public static HttpClient? AiportsApi { get; set; }

    public static void InitializeApi()
    { 

        AiportsApi = new HttpClient();
        AiportsApi.DefaultRequestHeaders.Accept.Clear();
        AiportsApi.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

    }

    /// <summary>
    /// request API and convert JSON answer in a List
    /// </summary>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public async Task<ListConvertAiports.Root> GetJson()
    {
        string url = ("");

        using (HttpResponseMessage response = await AirportsAPI.AiportsApi!.GetAsync(url))
        {
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                return JsonConvert.DeserializeObject<ListConvertAiports.Root>(responseBody)!;
                
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }
    }
 
  
}