using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Portfolio.Models
{
    public class GetSkillsResponse
    {
        [JsonPropertyName("ms")]
        public int MS { get; set; }

        [JsonPropertyName("query")]
        public string Query { get; set; }

        [JsonPropertyName("result")]
        public Skill[] Result { get; set; }
    }

    /*
     {"ms":23,"query":"*[_type == 'skill']","result":[{"_createdAt":"2021-10-23T02:07:41Z","_id":"9e087fa1-b751-4c4d-bbd4-b4de8bfa9768","_rev":"RWSfxA7dcwWUUcNMBvy8R0","_type":"skill","_updatedAt":"2021-10-23T02:07:41Z","iconClass":"devicon-typescript-plain","name":"Typescript"},{"_createdAt":"2021-10-23T02:06:51Z","_id":"ab35f0fb-35c3-431e-9a79-7f0d680ebb55","_rev":"RWSfxA7dcwWUUcNMBvxscM","_type":"skill","_updatedAt":"2021-10-23T02:06:51Z","iconClass":"devicon-javascript-plain","name":"Javascript"},{"_createdAt":"2021-10-23T02:07:15Z","_id":"c79babb7-5b00-46a0-8b18-fb38af00457d","_rev":"yamysJZJS7mjOVcCaCFLDv","_type":"skill","_updatedAt":"2021-10-23T02:07:15Z","iconClass":"devicon-csharp-plain","name":"C#"}]}
     */
}
