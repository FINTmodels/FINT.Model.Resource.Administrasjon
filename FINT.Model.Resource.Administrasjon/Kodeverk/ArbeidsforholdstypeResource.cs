// Built from tag v3.5.0

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Felles.Basisklasser;

namespace FINT.Model.Administrasjon.Kodeverk
{

    public class ArbeidsforholdstypeResource : Begrep 
    {

    
        public ArbeidsforholdstypeResource()
        {
            Links = new Dictionary<string, List<Link>>();
        }

        [JsonProperty(PropertyName = "_links")]
        public Dictionary<string, List<Link>> Links { get; private set; }

        protected void AddLink(string key, Link link)
        {
            if (!Links.ContainsKey(key))
            {
                Links.Add(key, new List<Link>());
            }
            Links[key].Add(link);
        }
     
            

        public void AddForelder(Link link)
        {
            AddLink("forelder", link);
        }
    }
}
