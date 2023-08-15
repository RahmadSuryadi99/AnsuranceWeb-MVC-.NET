using AsuransiXYZ.Repository;
using AsuransiXYZ.Utility;
using AsuransiXYZ.ViewModel.Prospect;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace AsuransiXYZ.Provider
{
    public class ProspectProvider
    {
        private static ProspectProvider _instance = new ProspectProvider();
        public static ProspectProvider GetProvider()
        {
            return _instance;
        }
        public List<GridViewModel> GetAllIndex()
        {
            var prospects = ProspectRepository.GetRepository().GetAll();
            var nasabah = NasabahRepository.GetRepository().GetAll();
            var model = (from pros in prospects.ToList()
                         join nasab in nasabah on pros.IdProspect equals nasab.IdProspect into full
                         from fullProspect in full.DefaultIfEmpty()
                         select new GridViewModel
                         {
                             NomorProspect = pros.IdProspect,
                             FullName = pros.FirstName + pros.LastName,
                             BrithDate = pros.BirthDate.ToString("dd MMMM yyyyy"),
                             BrithPlace = pros.BirthPlace,
                             Gender = pros.Gender.Equals("P") ? "Perempuan" : "Laki-Laki",
                             Pekerjaan = pros.Pekerjaan,
                             status = fullProspect==null ? "Prospect" : "Nasabah"

                         }).ToList();
            return model;
        }

        public async Task<List<GridViewModel>> GetAPIyuk()
        {
            string apiUrl = "https://moviesdatabase.p.rapidapi.com/titles/{seriesId}";
            //string requestUrl = "https://www.emsifa.com/api-wilayah-indonesia/api/provinces.json";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Add necessary headers
                    client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "61189905demshc1fc5cef4984370p1c936djsn4c27e1b43c4c");
                    client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "moviesdatabase.p.rapidapi.com");

                    // Replace {seriesId} with the actual series ID you want to query
                    string seriesId = "tt12451520";
                    string requestUrl = apiUrl.Replace("{seriesId}", seriesId);

                    HttpResponseMessage response = await client.GetAsync(requestUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        Console.WriteLine(responseBody);
                    }
                    else
                    {
                        Console.WriteLine($"HTTP Error: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
                var tes = new List<GridViewModel>();
                return tes;
            }
        }

        public async Task GetApidanAir()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://www.emsifa.com/api-wilayah-indonesia/api/provinces.json"),
                Headers = {}
                //RequestUri = new Uri("https://moviesdatabase.p.rapidapi.com/titles/tt12451520"),
                //Headers =
                        //{
                        //    { "X-RapidAPI-Key", "61189905demshc1fc5cef4984370p1c936djsn4c27e1b43c4c" },
                        //    { "X-RapidAPI-Host", "moviesdatabase.p.rapidapi.com" },
                        //},
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }
        }
    }
}
