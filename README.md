# glTFLib
Various submodules for building a .net gltf sdk from the gltf json schema. The main work has been done by Khronos Group in the glTF-CSharp-Loader project. This repository contains all of the submodules for building the library and facilitates generating a new library if the schema is updated.

### Submodules
This project consists of three submodules:

1. [`glTF`](https://github.com/KhronosGroup/glTF) - The glTF schema from Khronos Group.
2. [`glTF-CSharp-Loader`](https://github.com/KhronosGroup/glTF-CSharp-Loader) - Codegen project from Khronos Group which builds a .net dll from the json schema. Includes unit tests.
3. [`glTF-Sample-Models`](https://github.com/KhronosGroup/glTF-Sample-Models) - Sample glTF models from Khronos Group.

Please make sure submodules are updated, and that the glTF-CSharp-Loader project is built according to these instructions: https://github.com/KhronosGroup/glTF-CSharp-Loader#build-instructions

There is an [example](glTFLibExample) that builds a simple glTF model.

### TODO
- Create some example scenarios in [`glTFLibExample`](https://github.com/mcneel/glTFLib/tree/master/glTFLibExample).
 
