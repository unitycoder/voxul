using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Voxul
{
	public class VoxelColorTint : VoxelRendererPropertyModifier
	{
		[ColorUsage(true, true)]
		public Color Color = Color.white;

		protected override void SetPropertyBlock(MaterialPropertyBlock block, VoxelRendererSubmesh submesh)
		{
			block.SetColor("AlbedoTint", Color);
		}
	}
}