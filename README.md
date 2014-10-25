ColliderIsHitExtention
======================

UnityにてCollider(とrigidbody)を使って当たり判定すると、どうしても物理エンジンの影響を受けます。
其処で物理エンジンの影響を排除する為にCPU側で自前判定しようと言うものです。
負荷は度外視と為ります。

|                   |Box|Sphere|Capsule|Character|Mesh|Terrain|Wheel|
|:-----------------:|:-:|:----:|:-----:|:-------:|:--:|:-----:|:---:|
|BoxCollider        |✓ |✓    |✓     |         |    |       |     |
|SphereCollider     |✓ |✓    |✓     |         |    |       |     |
|CapsuleCollider    |✓ |✓    |✓     |         |    |       |     |
|CharacterController|   |      |       |         |    |       |     |
|MeshCollider       |   |      |       |         |    |       |     |
|TerrainCollider    |   |      |       |         |    |       |     |
|WheelCollider      |   |      |       |         |    |       |     |

|                 |Box|Circle|Edge|Polygon|
|:---------------:|:-:|:----:|:--:|:-----:|
|BoxCollider2D    |✓ |      |    |       |
|CircleCollider2D |   |      |    |       |
|EdgeCollider2D   |   |      |    |       |
|PolygonCollider2D|   |      |    |       |
