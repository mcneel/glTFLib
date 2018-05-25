using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFLib
{






    public class Camera
    {
        public string schema { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string description { get; set; }
        public Allof2[] allOf { get; set; }
        public Properties properties { get; set; }
        public string[] required { get; set; }
        public Not not { get; set; }
    }

    public class Properties
    {
        public Orthographic orthographic { get; set; }
        public Perspective perspective { get; set; }
        public Type type { get; set; }
        public Name name { get; set; }
        public Extensions extensions { get; set; }
        public Extras extras { get; set; }
    }

    public class Orthographic
    {
        public Allof[] allOf { get; set; }
        public string description { get; set; }
    }

    public class Allof
    {
        public string _ref { get; set; }
    }

    public class Perspective
    {
        public Allof1[] allOf { get; set; }
        public string description { get; set; }
    }

    public class Allof1
    {
        public string _ref { get; set; }
    }

    public class Type
    {
        public string description { get; set; }
        public string gltf_detailedDescription { get; set; }
        public Anyof[] anyOf { get; set; }
    }

    public class Anyof
    {
        public string[] _enum { get; set; }
        public string type { get; set; }
    }

    public class Name
    {
    }

    public class Extensions
    {
    }

    public class Extras
    {
    }

    public class Not
    {
        public string[] required { get; set; }
    }

    public class Allof2
    {
        public string _ref { get; set; }
    }


}
