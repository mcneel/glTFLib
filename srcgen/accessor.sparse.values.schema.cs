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
    
    /// <summary>Array of size `accessor.sparse.count` times number of components storing the displaced accessor attributes pointed by `accessor.sparse.indices`.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.49.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Json : GlTFProperty
    {
        /// <summary>The index of the bufferView with sparse values. Referenced bufferView can't have ARRAY_BUFFER or ELEMENT_ARRAY_BUFFER target.</summary>
        [Newtonsoft.Json.JsonProperty("bufferView", Required = Newtonsoft.Json.Required.Always)]
        public int BufferView { get; set; }
    
        /// <summary>The offset relative to the start of the bufferView in bytes. Must be aligned.</summary>
        [Newtonsoft.Json.JsonProperty("byteOffset", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
        public int ByteOffset { get; set; } = 0;
    
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
}