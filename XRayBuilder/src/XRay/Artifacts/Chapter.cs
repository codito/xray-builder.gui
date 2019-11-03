using Newtonsoft.Json;

namespace XRayBuilderGUI.XRay.Artifacts
{
    public sealed class Chapter
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start")]
        public long Start { get; set; }

        [JsonProperty("end")]
        public long End { get; set; }
    }
}