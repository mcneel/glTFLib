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
    
    /// <summary>The index of the node and TRS property that an animation channel targets.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.49.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Json : GlTFProperty
    {
        /// <summary>The index of the node to target.</summary>
        [Newtonsoft.Json.JsonProperty("node", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Node { get; set; }
    
        /// <summary>The name of the node's TRS property to modify, or the "weights" of the Morph Targets it instantiates. For the "translation" property, the values that are provided by the sampler are the translation along the x, y, and z axes. For the "rotation" property, the values are a quaternion in the order (x, y, z, w), where w is the scalar. For the "scale" property, the values are the scaling factors along the x, y, and z axes.</summary>
        [Newtonsoft.Json.JsonProperty("path", Required = Newtonsoft.Json.Required.Always)]
        public Path Path { get; set; }
    
        [Newtonsoft.Json.JsonProperty("extensions", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Extensions { get; set; }
    
        [Newtonsoft.Json.JsonProperty("extras", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Extras { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Json FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Json>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.49.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Path 
    {
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Path FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Path>(data);
        }
    
    }
}