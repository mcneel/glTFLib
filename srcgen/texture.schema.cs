//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v9.10.49.0 (Newtonsoft.Json v11.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace glTFLib.Gen
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.49.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class GlTFProperty 
    {
        [Newtonsoft.Json.JsonProperty("extensions", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.Dictionary<string, object> Extensions { get; set; } = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonProperty("extras", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Extras { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static GlTFProperty FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<GlTFProperty>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.49.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class GlTFChildOfRootProperty : GlTFProperty
    {
        /// <summary>The user-defined name of this object.</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static GlTFChildOfRootProperty FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<GlTFChildOfRootProperty>(data);
        }
    
    }
    
    /// <summary>A texture and its sampler.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.49.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Texture : GlTFChildOfRootProperty
    {
        /// <summary>The index of the sampler used by this texture. When undefined, a sampler with repeat wrapping and auto filtering should be used.</summary>
        [Newtonsoft.Json.JsonProperty("sampler", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Sampler { get; set; }
    
        /// <summary>The index of the image used by this texture.</summary>
        [Newtonsoft.Json.JsonProperty("source", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Source { get; set; }
    
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("extensions", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Extensions { get; set; }
    
        [Newtonsoft.Json.JsonProperty("extras", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Extras { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Texture FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Texture>(data);
        }
    
    }
}