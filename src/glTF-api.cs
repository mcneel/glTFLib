// Please help improve quicktype by enabling anonymous telemetry with:
//
//   $ quicktype --telemetry enable
//
// You can also enable telemetry on any quicktype invocation:
//
//   $ quicktype pokedex.json -o Pokedex.cs --telemetry enable
//
// This helps us improve quicktype by measuring:
//
//   * How many people use quicktype
//   * Which features are popular or unpopular
//   * Performance
//   * Errors
//
// quicktype does not collect:
//
//   * Your filenames or input data
//   * Any personally identifiable information (PII)
//   * Anything not directly related to quicktype's usage
//
// If you don't want to help improve quicktype, you can dismiss this message with:
//
//   $ quicktype --telemetry disable
//
// For a full privacy policy, visit app.quicktype.io/privacy
//

namespace glTFLib
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The root object for a glTF asset.
    /// </summary>
    public partial class GlTF
    {
        /// <summary>
        /// An array of accessors.
        /// </summary>
        public List<Accessor> Accessors { get; set; }

        /// <summary>
        /// An array of keyframe animations.
        /// </summary>
        public List<Animation> Animations { get; set; }

        /// <summary>
        /// Metadata about the glTF asset.
        /// </summary>
        public AssetClass Asset { get; set; }

        /// <summary>
        /// An array of buffers.
        /// </summary>
        public List<Buffer> Buffers { get; set; }

        /// <summary>
        /// An array of bufferViews.
        /// </summary>
        public List<BufferView> BufferViews { get; set; }

        /// <summary>
        /// An array of cameras.
        /// </summary>
        public List<Camera> Cameras { get; set; }

        public Dictionary<string, Dictionary<string, object>> Extensions { get; set; }

        /// <summary>
        /// Names of glTF extensions required to properly load this asset.
        /// </summary>
        public List<string> ExtensionsRequired { get; set; }

        /// <summary>
        /// Names of glTF extensions used somewhere in this asset.
        /// </summary>
        public List<string> ExtensionsUsed { get; set; }

        public object Extras { get; set; }

        /// <summary>
        /// An array of images.
        /// </summary>
        public List<Image> Images { get; set; }

        /// <summary>
        /// An array of materials.
        /// </summary>
        public List<Material> Materials { get; set; }

        /// <summary>
        /// An array of meshes.
        /// </summary>
        public List<Mesh> Meshes { get; set; }

        /// <summary>
        /// An array of nodes.
        /// </summary>
        public List<Node> Nodes { get; set; }

        /// <summary>
        /// An array of samplers.
        /// </summary>
        public List<Sampler> Samplers { get; set; }

        /// <summary>
        /// The index of the default scene.
        /// </summary>
        public long? Scene { get; set; }

        /// <summary>
        /// An array of scenes.
        /// </summary>
        public List<Scene> Scenes { get; set; }

        /// <summary>
        /// An array of skins.
        /// </summary>
        public List<Skin> Skins { get; set; }

        /// <summary>
        /// An array of textures.
        /// </summary>
        public List<Texture> Textures { get; set; }
    }

    /// <summary>
    /// An array of accessors.
    ///
    /// A typed view into a bufferView.  A bufferView contains raw binary data.  An accessor
    /// provides a typed view into a bufferView or a subset of a bufferView similar to how
    /// WebGL's `vertexAttribPointer()` defines an attribute in a buffer.
    /// </summary>
    public partial class Accessor
    {
        /// <summary>
        /// The index of the bufferView.
        /// </summary>
        public long? BufferView { get; set; }

        /// <summary>
        /// The offset relative to the start of the bufferView in bytes.
        /// </summary>
        public long? ByteOffset { get; set; }

        /// <summary>
        /// The datatype of components in the attribute.
        /// </summary>
        public Extras ComponentType { get; set; }

        /// <summary>
        /// The number of attributes referenced by this accessor.
        /// </summary>
        public long Count { get; set; }

        public Dictionary<string, Dictionary<string, object>> Extensions { get; set; }

        public object Extras { get; set; }

        /// <summary>
        /// Maximum value of each component in this attribute.
        /// </summary>
        public List<double> Max { get; set; }

        /// <summary>
        /// Minimum value of each component in this attribute.
        /// </summary>
        public List<double> Min { get; set; }

        /// <summary>
        /// The user-defined name of this object.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Specifies whether integer data values should be normalized.
        /// </summary>
        public bool? Normalized { get; set; }

        /// <summary>
        /// Sparse storage of attributes that deviate from their initialization value.
        /// </summary>
        public AccessorSparse Sparse { get; set; }

        /// <summary>
        /// Specifies if the attribute is a scalar, vector, or matrix.
        /// </summary>
        public string Type { get; set; }
    }

    /// <summary>
    /// Application-specific data.
    ///
    /// Sparse storage of attributes that deviate from their initialization value.
    /// </summary>
    public partial class AccessorSparse
    {
        /// <summary>
        /// Number of entries stored in the sparse array.
        /// </summary>
        public long Count { get; set; }

        public Dictionary<string, Dictionary<string, object>> Extensions { get; set; }

        public object Extras { get; set; }

        /// <summary>
        /// Index array of size `count` that points to those accessor attributes that deviate from
        /// their initialization value. Indices must strictly increase.
        /// </summary>
        public AccessorSparseIndices Indices { get; set; }

        /// <summary>
        /// Array of size `count` times number of components, storing the displaced accessor
        /// attributes pointed by `indices`. Substituted values must have the same `componentType`
        /// and number of components as the base accessor.
        /// </summary>
        public AccessorSparseValues Values { get; set; }
    }

    /// <summary>
    /// Application-specific data.
    ///
    /// Index array of size `count` that points to those accessor attributes that deviate from
    /// their initialization value. Indices must strictly increase.
    ///
    /// Indices of those attributes that deviate from their initialization value.
    /// </summary>
    public partial class AccessorSparseIndices
    {
        /// <summary>
        /// The index of the bufferView with sparse indices. Referenced bufferView can't have
        /// ARRAY_BUFFER or ELEMENT_ARRAY_BUFFER target.
        /// </summary>
        public long BufferView { get; set; }

        /// <summary>
        /// The offset relative to the start of the bufferView in bytes. Must be aligned.
        /// </summary>
        public long? ByteOffset { get; set; }

        /// <summary>
        /// The indices data type.
        /// </summary>
        public Extras ComponentType { get; set; }

        public Dictionary<string, Dictionary<string, object>> Extensions { get; set; }

        public object Extras { get; set; }
    }

    /// <summary>
    /// Application-specific data.
    ///
    /// Array of size `count` times number of components, storing the displaced accessor
    /// attributes pointed by `indices`. Substituted values must have the same `componentType`
    /// and number of components as the base accessor.
    ///
    /// Array of size `accessor.sparse.count` times number of components storing the displaced
    /// accessor attributes pointed by `accessor.sparse.indices`.
    /// </summary>
    public partial class AccessorSparseValues
    {
        /// <summary>
        /// The index of the bufferView with sparse values. Referenced bufferView can't have
        /// ARRAY_BUFFER or ELEMENT_ARRAY_BUFFER target.
        /// </summary>
        public long BufferView { get; set; }

        /// <summary>
        /// The offset relative to the start of the bufferView in bytes. Must be aligned.
        /// </summary>
        public long? ByteOffset { get; set; }

        public Dictionary<string, Dictionary<string, object>> Extensions { get; set; }

        public object Extras { get; set; }
    }

    /// <summary>
    /// An array of keyframe animations.
    ///
    /// A keyframe animation.
    /// </summary>
    public partial class Animation
    {
        /// <summary>
        /// An array of channels, each of which targets an animation's sampler at a node's property.
        /// Different channels of the same animation can't have equal targets.
        /// </summary>
        public List<AnimationChannel> Channels { get; set; }

        public Dictionary<string, Dictionary<string, object>> Extensions { get; set; }

        public object Extras { get; set; }

        /// <summary>
        /// The user-defined name of this object.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// An array of samplers that combines input and output accessors with an interpolation
        /// algorithm to define a keyframe graph (but not its target).
        /// </summary>
        public List<AnimationSampler> Samplers { get; set; }
    }

    /// <summary>
    /// An array of channels, each of which targets an animation's sampler at a node's property.
    /// Different channels of the same animation can't have equal targets.
    ///
    /// Targets an animation's sampler at a node's property.
    /// </summary>
    public partial class AnimationChannel
    {
        public Dictionary<string, Dictionary<string, object>> Extensions { get; set; }

        public object Extras { get; set; }

        /// <summary>
        /// The index of a sampler in this animation used to compute the value for the target.
        /// </summary>
        public long Sampler { get; set; }

        /// <summary>
        /// The index of the node and TRS property to target.
        /// </summary>
        public AnimationChannelTargetClass Target { get; set; }
    }

    /// <summary>
    /// Application-specific data.
    ///
    /// The index of the node and TRS property to target.
    ///
    /// The index of the node and TRS property that an animation channel targets.
    /// </summary>
    public partial class AnimationChannelTargetClass
    {
        public Dictionary<string, Dictionary<string, object>> Extensions { get; set; }

        public object Extras { get; set; }

        /// <summary>
        /// The index of the node to target.
        /// </summary>
        public long? Node { get; set; }

        /// <summary>
        /// The name of the node's TRS property to modify, or the "weights" of the Morph Targets it
        /// instantiates. For the "translation" property, the values that are provided by the sampler
        /// are the translation along the x, y, and z axes. For the "rotation" property, the values
        /// are a quaternion in the order (x, y, z, w), where w is the scalar. For the "scale"
        /// property, the values are the scaling factors along the x, y, and z axes.
        /// </summary>
        public string Path { get; set; }
    }

    /// <summary>
    /// An array of samplers that combines input and output accessors with an interpolation
    /// algorithm to define a keyframe graph (but not its target).
    ///
    /// Combines input and output accessors with an interpolation algorithm to define a keyframe
    /// graph (but not its target).
    /// </summary>
    public partial class AnimationSampler
    {
        public Dictionary<string, Dictionary<string, object>> Extensions { get; set; }

        public object Extras { get; set; }

        /// <summary>
        /// The index of an accessor containing keyframe input values, e.g., time.
        /// </summary>
        public long Input { get; set; }

        /// <summary>
        /// Interpolation algorithm.
        /// </summary>
        public string Interpolation { get; set; }

        /// <summary>
        /// The index of an accessor, containing keyframe output values.
        /// </summary>
        public long Output { get; set; }
    }

    /// <summary>
    /// Application-specific data.
    ///
    /// Metadata about the glTF asset.
    /// </summary>
    public partial class AssetClass
    {
        /// <summary>
        /// A copyright message suitable for display to credit the content creator.
        /// </summary>
        public string Copyright { get; set; }

        public Dictionary<string, Dictionary<string, object>> Extensions { get; set; }

        public object Extras { get; set; }

        /// <summary>
        /// Tool that generated this glTF model.  Useful for debugging.
        /// </summary>
        public string Generator { get; set; }

        /// <summary>
        /// The minimum glTF version that this asset targets.
        /// </summary>
        public string MinVersion { get; set; }

        /// <summary>
        /// The glTF version that this asset targets.
        /// </summary>
        public string Version { get; set; }
    }

    /// <summary>
    /// An array of bufferViews.
    ///
    /// A view into a buffer generally representing a subset of the buffer.
    /// </summary>
    public partial class BufferView
    {
        /// <summary>
        /// The index of the buffer.
        /// </summary>
        public long Buffer { get; set; }

        /// <summary>
        /// The length of the bufferView in bytes.
        /// </summary>
        public long ByteLength { get; set; }

        /// <summary>
        /// The offset into the buffer in bytes.
        /// </summary>
        public long? ByteOffset { get; set; }

        /// <summary>
        /// The stride, in bytes.
        /// </summary>
        public long? ByteStride { get; set; }

        public Dictionary<string, Dictionary<string, object>> Extensions { get; set; }

        public object Extras { get; set; }

        /// <summary>
        /// The user-defined name of this object.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The target that the GPU buffer should be bound to.
        /// </summary>
        public Extras? Target { get; set; }
    }

    /// <summary>
    /// An array of buffers.
    ///
    /// A buffer points to binary geometry, animation, or skins.
    /// </summary>
    public partial class Buffer
    {
        /// <summary>
        /// The length of the buffer in bytes.
        /// </summary>
        public long ByteLength { get; set; }

        public Dictionary<string, Dictionary<string, object>> Extensions { get; set; }

        public object Extras { get; set; }

        /// <summary>
        /// The user-defined name of this object.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The uri of the buffer.
        /// </summary>
        public string Uri { get; set; }
    }

    /// <summary>
    /// An array of cameras.
    ///
    /// A camera's projection.  A node can reference a camera to apply a transform to place the
    /// camera in the scene.
    /// </summary>
    public partial class Camera
    {
        public Dictionary<string, Dictionary<string, object>> Extensions { get; set; }

        public object Extras { get; set; }

        /// <summary>
        /// The user-defined name of this object.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// An orthographic camera containing properties to create an orthographic projection matrix.
        /// </summary>
        public CameraOrthographic Orthographic { get; set; }

        /// <summary>
        /// A perspective camera containing properties to create a perspective projection matrix.
        /// </summary>
        public CameraPerspective Perspective { get; set; }

        /// <summary>
        /// Specifies if the camera uses a perspective or orthographic projection.
        /// </summary>
        public string Type { get; set; }
    }

    /// <summary>
    /// Application-specific data.
    ///
    /// An orthographic camera containing properties to create an orthographic projection matrix.
    /// </summary>
    public partial class CameraOrthographic
    {
        public Dictionary<string, Dictionary<string, object>> Extensions { get; set; }

        public object Extras { get; set; }

        /// <summary>
        /// The floating-point horizontal magnification of the view. Must not be zero.
        /// </summary>
        public double Xmag { get; set; }

        /// <summary>
        /// The floating-point vertical magnification of the view. Must not be zero.
        /// </summary>
        public double Ymag { get; set; }

        /// <summary>
        /// The floating-point distance to the far clipping plane. `zfar` must be greater than
        /// `znear`.
        /// </summary>
        public double Zfar { get; set; }

        /// <summary>
        /// The floating-point distance to the near clipping plane.
        /// </summary>
        public double Znear { get; set; }
    }

    /// <summary>
    /// Application-specific data.
    ///
    /// A perspective camera containing properties to create a perspective projection matrix.
    /// </summary>
    public partial class CameraPerspective
    {
        /// <summary>
        /// The floating-point aspect ratio of the field of view.
        /// </summary>
        public double? AspectRatio { get; set; }

        public Dictionary<string, Dictionary<string, object>> Extensions { get; set; }

        public object Extras { get; set; }

        /// <summary>
        /// The floating-point vertical field of view in radians.
        /// </summary>
        public double Yfov { get; set; }

        /// <summary>
        /// The floating-point distance to the far clipping plane.
        /// </summary>
        public double? Zfar { get; set; }

        /// <summary>
        /// The floating-point distance to the near clipping plane.
        /// </summary>
        public double Znear { get; set; }
    }

    /// <summary>
    /// An array of images.
    ///
    /// Image data used to create a texture. Image can be referenced by URI or `bufferView`
    /// index. `mimeType` is required in the latter case.
    /// </summary>
    public partial class Image
    {
        /// <summary>
        /// The index of the bufferView that contains the image. Use this instead of the image's uri
        /// property.
        /// </summary>
        public long? BufferView { get; set; }

        public Dictionary<string, Dictionary<string, object>> Extensions { get; set; }

        public object Extras { get; set; }

        /// <summary>
        /// The image's MIME type.
        /// </summary>
        public string MimeType { get; set; }

        /// <summary>
        /// The user-defined name of this object.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The uri of the image.
        /// </summary>
        public string Uri { get; set; }
    }

    /// <summary>
    /// An array of materials.
    ///
    /// The material appearance of a primitive.
    /// </summary>
    public partial class Material
    {
        /// <summary>
        /// The alpha cutoff value of the material.
        /// </summary>
        public double? AlphaCutoff { get; set; }

        /// <summary>
        /// The alpha rendering mode of the material.
        /// </summary>
        public string AlphaMode { get; set; }

        /// <summary>
        /// Specifies whether the material is double sided.
        /// </summary>
        public bool? DoubleSided { get; set; }

        /// <summary>
        /// The emissive color of the material.
        /// </summary>
        public List<double> EmissiveFactor { get; set; }

        /// <summary>
        /// The emissive map texture.
        /// </summary>
        public TextureInfo EmissiveTexture { get; set; }

        public Dictionary<string, Dictionary<string, object>> Extensions { get; set; }

        public object Extras { get; set; }

        /// <summary>
        /// The user-defined name of this object.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The normal map texture.
        /// </summary>
        public MaterialNormalTextureInfoClass NormalTexture { get; set; }

        /// <summary>
        /// The occlusion map texture.
        /// </summary>
        public MaterialOcclusionTextureInfoClass OcclusionTexture { get; set; }

        /// <summary>
        /// A set of parameter values that are used to define the metallic-roughness material model
        /// from Physically-Based Rendering (PBR) methodology. When not specified, all the default
        /// values of `pbrMetallicRoughness` apply.
        /// </summary>
        public MaterialPbrMetallicRoughness PbrMetallicRoughness { get; set; }
    }

    /// <summary>
    /// Application-specific data.
    ///
    /// The emissive map texture.
    ///
    /// The base color texture.
    ///
    /// The metallic-roughness texture.
    ///
    /// Reference to a texture.
    /// </summary>
    public partial class TextureInfo
    {
        public Dictionary<string, Dictionary<string, object>> Extensions { get; set; }

        public object Extras { get; set; }

        /// <summary>
        /// The index of the texture.
        /// </summary>
        public long Index { get; set; }

        /// <summary>
        /// The set index of texture's TEXCOORD attribute used for texture coordinate mapping.
        /// </summary>
        public long? TexCoord { get; set; }
    }

    /// <summary>
    /// Application-specific data.
    ///
    /// The normal map texture.
    ///
    /// Reference to a texture.
    /// </summary>
    public partial class MaterialNormalTextureInfoClass
    {
        public Dictionary<string, Dictionary<string, object>> Extensions { get; set; }

        public object Extras { get; set; }

        /// <summary>
        /// The index of the texture.
        /// </summary>
        public long Index { get; set; }

        /// <summary>
        /// The scalar multiplier applied to each normal vector of the normal texture.
        /// </summary>
        public double? Scale { get; set; }

        /// <summary>
        /// The set index of texture's TEXCOORD attribute used for texture coordinate mapping.
        /// </summary>
        public long? TexCoord { get; set; }
    }

    /// <summary>
    /// Application-specific data.
    ///
    /// The occlusion map texture.
    ///
    /// Reference to a texture.
    /// </summary>
    public partial class MaterialOcclusionTextureInfoClass
    {
        public Dictionary<string, Dictionary<string, object>> Extensions { get; set; }

        public object Extras { get; set; }

        /// <summary>
        /// The index of the texture.
        /// </summary>
        public long Index { get; set; }

        /// <summary>
        /// A scalar multiplier controlling the amount of occlusion applied.
        /// </summary>
        public double? Strength { get; set; }

        /// <summary>
        /// The set index of texture's TEXCOORD attribute used for texture coordinate mapping.
        /// </summary>
        public long? TexCoord { get; set; }
    }

    /// <summary>
    /// Application-specific data.
    ///
    /// A set of parameter values that are used to define the metallic-roughness material model
    /// from Physically-Based Rendering (PBR) methodology. When not specified, all the default
    /// values of `pbrMetallicRoughness` apply.
    ///
    /// A set of parameter values that are used to define the metallic-roughness material model
    /// from Physically-Based Rendering (PBR) methodology.
    /// </summary>
    public partial class MaterialPbrMetallicRoughness
    {
        /// <summary>
        /// The material's base color factor.
        /// </summary>
        public List<double> BaseColorFactor { get; set; }

        /// <summary>
        /// The base color texture.
        /// </summary>
        public TextureInfo BaseColorTexture { get; set; }

        public Dictionary<string, Dictionary<string, object>> Extensions { get; set; }

        public object Extras { get; set; }

        /// <summary>
        /// The metalness of the material.
        /// </summary>
        public double? MetallicFactor { get; set; }

        /// <summary>
        /// The metallic-roughness texture.
        /// </summary>
        public TextureInfo MetallicRoughnessTexture { get; set; }

        /// <summary>
        /// The roughness of the material.
        /// </summary>
        public double? RoughnessFactor { get; set; }
    }

    /// <summary>
    /// An array of meshes.
    ///
    /// A set of primitives to be rendered.  A node can contain one mesh.  A node's transform
    /// places the mesh in the scene.
    /// </summary>
    public partial class Mesh
    {
        public Dictionary<string, Dictionary<string, object>> Extensions { get; set; }

        public object Extras { get; set; }

        /// <summary>
        /// The user-defined name of this object.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// An array of primitives, each defining geometry to be rendered with a material.
        /// </summary>
        public List<MeshPrimitive> Primitives { get; set; }

        /// <summary>
        /// Array of weights to be applied to the Morph Targets.
        /// </summary>
        public List<double> Weights { get; set; }
    }

    /// <summary>
    /// An array of primitives, each defining geometry to be rendered with a material.
    ///
    /// Geometry to be rendered with the given material.
    /// </summary>
    public partial class MeshPrimitive
    {
        /// <summary>
        /// A dictionary object, where each key corresponds to mesh attribute semantic and each value
        /// is the index of the accessor containing attribute's data.
        /// </summary>
        public Dictionary<string, long> Attributes { get; set; }

        public Dictionary<string, Dictionary<string, object>> Extensions { get; set; }

        public object Extras { get; set; }

        /// <summary>
        /// The index of the accessor that contains the indices.
        /// </summary>
        public long? Indices { get; set; }

        /// <summary>
        /// The index of the material to apply to this primitive when rendering.
        /// </summary>
        public long? Material { get; set; }

        /// <summary>
        /// The type of primitives to render.
        /// </summary>
        public Extras? Mode { get; set; }

        /// <summary>
        /// An array of Morph Targets, each  Morph Target is a dictionary mapping attributes (only
        /// `POSITION`, `NORMAL`, and `TANGENT` supported) to their deviations in the Morph Target.
        /// </summary>
        public List<Dictionary<string, long>> Targets { get; set; }
    }

    /// <summary>
    /// An array of nodes.
    ///
    /// A node in the node hierarchy.  When the node contains `skin`, all `mesh.primitives` must
    /// contain `JOINTS_0` and `WEIGHTS_0` attributes.  A node can have either a `matrix` or any
    /// combination of `translation`/`rotation`/`scale` (TRS) properties. TRS properties are
    /// converted to matrices and postmultiplied in the `T * R * S` order to compose the
    /// transformation matrix; first the scale is applied to the vertices, then the rotation, and
    /// then the translation. If none are provided, the transform is the identity. When a node is
    /// targeted for animation (referenced by an animation.channel.target), only TRS properties
    /// may be present; `matrix` will not be present.
    /// </summary>
    public partial class Node
    {
        /// <summary>
        /// The index of the camera referenced by this node.
        /// </summary>
        public long? Camera { get; set; }

        /// <summary>
        /// The indices of this node's children.
        /// </summary>
        public List<long> Children { get; set; }

        public Dictionary<string, Dictionary<string, object>> Extensions { get; set; }

        public object Extras { get; set; }

        /// <summary>
        /// A floating-point 4x4 transformation matrix stored in column-major order.
        /// </summary>
        public List<double> Matrix { get; set; }

        /// <summary>
        /// The index of the mesh in this node.
        /// </summary>
        public long? Mesh { get; set; }

        /// <summary>
        /// The user-defined name of this object.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The node's unit quaternion rotation in the order (x, y, z, w), where w is the scalar.
        /// </summary>
        public List<double> Rotation { get; set; }

        /// <summary>
        /// The node's non-uniform scale, given as the scaling factors along the x, y, and z axes.
        /// </summary>
        public List<double> Scale { get; set; }

        /// <summary>
        /// The index of the skin referenced by this node.
        /// </summary>
        public long? Skin { get; set; }

        /// <summary>
        /// The node's translation along the x, y, and z axes.
        /// </summary>
        public List<double> Translation { get; set; }

        /// <summary>
        /// The weights of the instantiated Morph Target. Number of elements must match number of
        /// Morph Targets of used mesh.
        /// </summary>
        public List<double> Weights { get; set; }
    }

    /// <summary>
    /// An array of samplers.
    ///
    /// Texture sampler properties for filtering and wrapping modes.
    /// </summary>
    public partial class Sampler
    {
        public Dictionary<string, Dictionary<string, object>> Extensions { get; set; }

        public object Extras { get; set; }

        /// <summary>
        /// Magnification filter.
        /// </summary>
        public Extras? MagFilter { get; set; }

        /// <summary>
        /// Minification filter.
        /// </summary>
        public Extras? MinFilter { get; set; }

        /// <summary>
        /// The user-defined name of this object.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// s wrapping mode.
        /// </summary>
        public Extras? WrapS { get; set; }

        /// <summary>
        /// t wrapping mode.
        /// </summary>
        public Extras? WrapT { get; set; }
    }

    /// <summary>
    /// An array of scenes.
    ///
    /// The root nodes of a scene.
    /// </summary>
    public partial class Scene
    {
        public Dictionary<string, Dictionary<string, object>> Extensions { get; set; }

        public object Extras { get; set; }

        /// <summary>
        /// The user-defined name of this object.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The indices of each root node.
        /// </summary>
        public List<long> Nodes { get; set; }
    }

    /// <summary>
    /// An array of skins.
    ///
    /// Joints and matrices defining a skin.
    /// </summary>
    public partial class Skin
    {
        public Dictionary<string, Dictionary<string, object>> Extensions { get; set; }

        public object Extras { get; set; }

        /// <summary>
        /// The index of the accessor containing the floating-point 4x4 inverse-bind matrices.  The
        /// default is that each matrix is a 4x4 identity matrix, which implies that inverse-bind
        /// matrices were pre-applied.
        /// </summary>
        public long? InverseBindMatrices { get; set; }

        /// <summary>
        /// Indices of skeleton nodes, used as joints in this skin.
        /// </summary>
        public List<long> Joints { get; set; }

        /// <summary>
        /// The user-defined name of this object.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The index of the node used as a skeleton root. When undefined, joints transforms resolve
        /// to scene root.
        /// </summary>
        public long? Skeleton { get; set; }
    }

    /// <summary>
    /// An array of textures.
    ///
    /// A texture and its sampler.
    /// </summary>
    public partial class Texture
    {
        public Dictionary<string, Dictionary<string, object>> Extensions { get; set; }

        public object Extras { get; set; }

        /// <summary>
        /// The user-defined name of this object.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The index of the sampler used by this texture. When undefined, a sampler with repeat
        /// wrapping and auto filtering should be used.
        /// </summary>
        public long? Sampler { get; set; }

        /// <summary>
        /// The index of the image used by this texture.
        /// </summary>
        public long? Source { get; set; }
    }

    /// <summary>
    /// Application-specific data.
    /// </summary>
    public partial struct Extras
    {
        public double? Double;
        public long? Integer;

        public bool IsNull => Double == null && Integer == null;
    }

    public partial class GlTF
    {
        public static GlTF FromJson(string json) => JsonConvert.DeserializeObject<GlTF>(json, glTFLib.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this GlTF self) => JsonConvert.SerializeObject(self, glTFLib.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new ExtrasConverter(),
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
            
            //Manual edits
            NullValueHandling = NullValueHandling.Ignore,
            DefaultValueHandling = DefaultValueHandling.Ignore,
            ContractResolver = new CamelCaseCustomResolver()
        };
    }

    internal class ExtrasConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Extras) || t == typeof(Extras?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new Extras { Integer = integerValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new Extras { Double = doubleValue };
            }
            throw new Exception("Cannot unmarshal type Extras");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Extras)untypedValue;
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer); return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double); return;
            }
            throw new Exception("Cannot marshal type Extras");
        }
    }
}
