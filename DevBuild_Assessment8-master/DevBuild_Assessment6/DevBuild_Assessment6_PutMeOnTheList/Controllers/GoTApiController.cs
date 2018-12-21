using DevBuild_Assessment6_PutMeOnTheList.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DevBuild_Assessment6_PutMeOnTheList.Controllers
{
    public class GoTApiController : ApiController
    {
        const string userAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0) Gecko/20100101 Firefox/47.0";

        public List<GoTCharacter> Get()
        {
            ShahPartyDBEntities Orm = new ShahPartyDBEntities();
            return Orm.GoTCharacters.ToList();
        }

        public CharacterSheet GetCharacter(string characterName)
        {
            CharacterSheet character = new CharacterSheet();
            HttpWebRequest request = WebRequest.CreateHttp($"https://www.anapioficeandfire.com/api/characters?Name={characterName}");
            request.UserAgent = userAgent;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var serializer = new JsonSerializer();
                using (var data = new StreamReader(response.GetResponseStream()))
                using (var jsonReader = new JsonTextReader(data))
                {
                    character = serializer.Deserialize<CharacterSheet>(jsonReader);
                }
            }
            return character;
        }
    }
}
