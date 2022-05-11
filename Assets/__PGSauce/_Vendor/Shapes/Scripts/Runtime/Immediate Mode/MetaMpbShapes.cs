using System.Collections.Generic;
using UnityEngine;

// Shapes © Freya Holmér - https://twitter.com/FreyaHolmer/
// Website & Documentation - https://acegikmo.com/shapes/
// this file is auto-generated by CodegenMpbs
namespace Shapes {

	internal class MpbCone : MetaMpb {

		internal readonly List<float> length = InitList<float>();
		internal readonly List<float> radius = InitList<float>();
		internal readonly List<float> sizeSpace = InitList<float>();

		protected override void TransferShapeProperties() {
			Transfer( ShapesMaterialUtils.propLength, length );
			Transfer( ShapesMaterialUtils.propRadius, radius );
			Transfer( ShapesMaterialUtils.propSizeSpace, sizeSpace );
		}

	}

	internal class MpbCuboid : MetaMpb {

		internal readonly List<Vector4> size = InitList<Vector4>();
		internal readonly List<float> sizeSpace = InitList<float>();

		protected override void TransferShapeProperties() {
			Transfer( ShapesMaterialUtils.propSize, size );
			Transfer( ShapesMaterialUtils.propSizeSpace, sizeSpace );
		}

	}

	internal class MpbDisc : MetaMpb, IDashableMpb {

		internal readonly List<float> alignment = InitList<float>();
		internal readonly List<float> angleEnd = InitList<float>();
		internal readonly List<float> angleStart = InitList<float>();
		internal readonly List<Vector4> colorInnerEnd = InitList<Vector4>();
		internal readonly List<Vector4> colorOuterEnd = InitList<Vector4>();
		internal readonly List<Vector4> colorOuterStart = InitList<Vector4>();
		internal readonly List<float> radius = InitList<float>();
		internal readonly List<float> radiusSpace = InitList<float>();
		internal readonly List<float> roundCaps = InitList<float>();
		internal readonly List<float> scaleMode = InitList<float>();
		internal readonly List<float> thickness = InitList<float>();
		internal readonly List<float> thicknessSpace = InitList<float>();

		// dash boilerplate
		List<float> IDashableMpb.dashOffset { get; } = InitList<float>();
		List<float> IDashableMpb.dashShapeModifier { get; } = InitList<float>();
		List<float> IDashableMpb.dashSize { get; } = InitList<float>();
		List<float> IDashableMpb.dashSnap { get; } = InitList<float>();
		List<float> IDashableMpb.dashSpace { get; } = InitList<float>();
		List<float> IDashableMpb.dashSpacing { get; } = InitList<float>();
		List<float> IDashableMpb.dashType { get; } = InitList<float>();

		protected override void TransferShapeProperties() {
			Transfer( ShapesMaterialUtils.propAlignment, alignment );
			Transfer( ShapesMaterialUtils.propAngEnd, angleEnd );
			Transfer( ShapesMaterialUtils.propAngStart, angleStart );
			Transfer( ShapesMaterialUtils.propColorInnerEnd, colorInnerEnd );
			Transfer( ShapesMaterialUtils.propColorOuterEnd, colorOuterEnd );
			Transfer( ShapesMaterialUtils.propColorOuterStart, colorOuterStart );
			Transfer( ShapesMaterialUtils.propRadius, radius );
			Transfer( ShapesMaterialUtils.propRadiusSpace, radiusSpace );
			Transfer( ShapesMaterialUtils.propRoundCaps, roundCaps );
			Transfer( ShapesMaterialUtils.propScaleMode, scaleMode );
			Transfer( ShapesMaterialUtils.propThickness, thickness );
			Transfer( ShapesMaterialUtils.propThicknessSpace, thicknessSpace );
		}

	}

	internal class MpbLine2D : MetaMpb, IDashableMpb {

		internal readonly List<float> alignment = InitList<float>();
		internal readonly List<Vector4> colorEnd = InitList<Vector4>();
		internal readonly List<Vector4> pointEnd = InitList<Vector4>();
		internal readonly List<Vector4> pointStart = InitList<Vector4>();
		internal readonly List<float> scaleMode = InitList<float>();
		internal readonly List<float> thickness = InitList<float>();
		internal readonly List<float> thicknessSpace = InitList<float>();

		// dash boilerplate
		List<float> IDashableMpb.dashOffset { get; } = InitList<float>();
		List<float> IDashableMpb.dashShapeModifier { get; } = InitList<float>();
		List<float> IDashableMpb.dashSize { get; } = InitList<float>();
		List<float> IDashableMpb.dashSnap { get; } = InitList<float>();
		List<float> IDashableMpb.dashSpace { get; } = InitList<float>();
		List<float> IDashableMpb.dashSpacing { get; } = InitList<float>();
		List<float> IDashableMpb.dashType { get; } = InitList<float>();

		protected override void TransferShapeProperties() {
			Transfer( ShapesMaterialUtils.propAlignment, alignment );
			Transfer( ShapesMaterialUtils.propColorEnd, colorEnd );
			Transfer( ShapesMaterialUtils.propPointEnd, pointEnd );
			Transfer( ShapesMaterialUtils.propPointStart, pointStart );
			Transfer( ShapesMaterialUtils.propScaleMode, scaleMode );
			Transfer( ShapesMaterialUtils.propThickness, thickness );
			Transfer( ShapesMaterialUtils.propThicknessSpace, thicknessSpace );
		}

	}

	internal class MpbLine3D : MetaMpb, IDashableMpb {

		internal readonly List<Vector4> colorEnd = InitList<Vector4>();
		internal readonly List<Vector4> pointEnd = InitList<Vector4>();
		internal readonly List<Vector4> pointStart = InitList<Vector4>();
		internal readonly List<float> scaleMode = InitList<float>();
		internal readonly List<float> thickness = InitList<float>();
		internal readonly List<float> thicknessSpace = InitList<float>();

		// dash boilerplate
		List<float> IDashableMpb.dashOffset { get; } = InitList<float>();
		List<float> IDashableMpb.dashShapeModifier { get; } = InitList<float>();
		List<float> IDashableMpb.dashSize { get; } = InitList<float>();
		List<float> IDashableMpb.dashSnap { get; } = InitList<float>();
		List<float> IDashableMpb.dashSpace { get; } = InitList<float>();
		List<float> IDashableMpb.dashSpacing { get; } = InitList<float>();
		List<float> IDashableMpb.dashType { get; } = InitList<float>();

		protected override void TransferShapeProperties() {
			Transfer( ShapesMaterialUtils.propColorEnd, colorEnd );
			Transfer( ShapesMaterialUtils.propPointEnd, pointEnd );
			Transfer( ShapesMaterialUtils.propPointStart, pointStart );
			Transfer( ShapesMaterialUtils.propScaleMode, scaleMode );
			Transfer( ShapesMaterialUtils.propThickness, thickness );
			Transfer( ShapesMaterialUtils.propThicknessSpace, thicknessSpace );
		}

	}

	internal class MpbPolygon : MetaMpb, IFillableMpb {

		// fill boilerplate
		List<Vector4> IFillableMpb.fillColorEnd { get; } = InitList<Vector4>();
		List<Vector4> IFillableMpb.fillEnd { get; } = InitList<Vector4>();
		List<float> IFillableMpb.fillSpace { get; } = InitList<float>();
		List<Vector4> IFillableMpb.fillStart { get; } = InitList<Vector4>();
		List<float> IFillableMpb.fillType { get; } = InitList<float>();

		protected override void TransferShapeProperties() => _ = 0; // :>

	}

	internal class MpbPolyline2D : MetaMpb {

		internal readonly List<float> alignment = InitList<float>();
		internal readonly List<float> scaleMode = InitList<float>();
		internal readonly List<float> thickness = InitList<float>();
		internal readonly List<float> thicknessSpace = InitList<float>();

		protected override void TransferShapeProperties() {
			Transfer( ShapesMaterialUtils.propAlignment, alignment );
			Transfer( ShapesMaterialUtils.propScaleMode, scaleMode );
			Transfer( ShapesMaterialUtils.propThickness, thickness );
			Transfer( ShapesMaterialUtils.propThicknessSpace, thicknessSpace );
		}

	}

	internal class MpbQuad : MetaMpb {

		internal readonly List<Vector4> a = InitList<Vector4>();
		internal readonly List<Vector4> b = InitList<Vector4>();
		internal readonly List<Vector4> c = InitList<Vector4>();
		internal readonly List<Vector4> colorB = InitList<Vector4>();
		internal readonly List<Vector4> colorC = InitList<Vector4>();
		internal readonly List<Vector4> colorD = InitList<Vector4>();
		internal readonly List<Vector4> d = InitList<Vector4>();

		protected override void TransferShapeProperties() {
			Transfer( ShapesMaterialUtils.propA, a );
			Transfer( ShapesMaterialUtils.propB, b );
			Transfer( ShapesMaterialUtils.propC, c );
			Transfer( ShapesMaterialUtils.propColorB, colorB );
			Transfer( ShapesMaterialUtils.propColorC, colorC );
			Transfer( ShapesMaterialUtils.propColorD, colorD );
			Transfer( ShapesMaterialUtils.propD, d );
		}

	}

	internal class MpbRect : MetaMpb, IFillableMpb, IDashableMpb {

		internal readonly List<Vector4> cornerRadii = InitList<Vector4>();
		internal readonly List<Vector4> rect = InitList<Vector4>();
		internal readonly List<float> scaleMode = InitList<float>();
		internal readonly List<float> thickness = InitList<float>();
		internal readonly List<float> thicknessSpace = InitList<float>();

		// fill boilerplate
		List<Vector4> IFillableMpb.fillColorEnd { get; } = InitList<Vector4>();
		List<Vector4> IFillableMpb.fillEnd { get; } = InitList<Vector4>();
		List<float> IFillableMpb.fillSpace { get; } = InitList<float>();
		List<Vector4> IFillableMpb.fillStart { get; } = InitList<Vector4>();
		List<float> IFillableMpb.fillType { get; } = InitList<float>();

		// dash boilerplate
		List<float> IDashableMpb.dashOffset { get; } = InitList<float>();
		List<float> IDashableMpb.dashShapeModifier { get; } = InitList<float>();
		List<float> IDashableMpb.dashSize { get; } = InitList<float>();
		List<float> IDashableMpb.dashSnap { get; } = InitList<float>();
		List<float> IDashableMpb.dashSpace { get; } = InitList<float>();
		List<float> IDashableMpb.dashSpacing { get; } = InitList<float>();
		List<float> IDashableMpb.dashType { get; } = InitList<float>();

		protected override void TransferShapeProperties() {
			Transfer( ShapesMaterialUtils.propCornerRadii, cornerRadii );
			Transfer( ShapesMaterialUtils.propRect, rect );
			Transfer( ShapesMaterialUtils.propScaleMode, scaleMode );
			Transfer( ShapesMaterialUtils.propThickness, thickness );
			Transfer( ShapesMaterialUtils.propThicknessSpace, thicknessSpace );
		}

	}

	internal class MpbRegularPolygon : MetaMpb, IFillableMpb, IDashableMpb {

		internal readonly List<float> alignment = InitList<float>();
		internal readonly List<float> angle = InitList<float>();
		internal readonly List<float> hollow = InitList<float>();
		internal readonly List<float> radius = InitList<float>();
		internal readonly List<float> radiusSpace = InitList<float>();
		internal readonly List<float> roundness = InitList<float>();
		internal readonly List<float> scaleMode = InitList<float>();
		internal readonly List<float> sides = InitList<float>();
		internal readonly List<float> thickness = InitList<float>();
		internal readonly List<float> thicknessSpace = InitList<float>();

		// fill boilerplate
		List<Vector4> IFillableMpb.fillColorEnd { get; } = InitList<Vector4>();
		List<Vector4> IFillableMpb.fillEnd { get; } = InitList<Vector4>();
		List<float> IFillableMpb.fillSpace { get; } = InitList<float>();
		List<Vector4> IFillableMpb.fillStart { get; } = InitList<Vector4>();
		List<float> IFillableMpb.fillType { get; } = InitList<float>();

		// dash boilerplate
		List<float> IDashableMpb.dashOffset { get; } = InitList<float>();
		List<float> IDashableMpb.dashShapeModifier { get; } = InitList<float>();
		List<float> IDashableMpb.dashSize { get; } = InitList<float>();
		List<float> IDashableMpb.dashSnap { get; } = InitList<float>();
		List<float> IDashableMpb.dashSpace { get; } = InitList<float>();
		List<float> IDashableMpb.dashSpacing { get; } = InitList<float>();
		List<float> IDashableMpb.dashType { get; } = InitList<float>();

		protected override void TransferShapeProperties() {
			Transfer( ShapesMaterialUtils.propAlignment, alignment );
			Transfer( ShapesMaterialUtils.propAng, angle );
			Transfer( ShapesMaterialUtils.propBorder, hollow );
			Transfer( ShapesMaterialUtils.propRadius, radius );
			Transfer( ShapesMaterialUtils.propRadiusSpace, radiusSpace );
			Transfer( ShapesMaterialUtils.propRoundness, roundness );
			Transfer( ShapesMaterialUtils.propScaleMode, scaleMode );
			Transfer( ShapesMaterialUtils.propSides, sides );
			Transfer( ShapesMaterialUtils.propThickness, thickness );
			Transfer( ShapesMaterialUtils.propThicknessSpace, thicknessSpace );
		}

	}

	internal class MpbSphere : MetaMpb {

		internal readonly List<float> radius = InitList<float>();
		internal readonly List<float> radiusSpace = InitList<float>();

		protected override void TransferShapeProperties() {
			Transfer( ShapesMaterialUtils.propRadius, radius );
			Transfer( ShapesMaterialUtils.propRadiusSpace, radiusSpace );
		}

	}

	internal class MpbTorus : MetaMpb {

		internal readonly List<float> radius = InitList<float>();
		internal readonly List<float> radiusSpace = InitList<float>();
		internal readonly List<float> scaleMode = InitList<float>();
		internal readonly List<float> thickness = InitList<float>();
		internal readonly List<float> thicknessSpace = InitList<float>();

		protected override void TransferShapeProperties() {
			Transfer( ShapesMaterialUtils.propRadius, radius );
			Transfer( ShapesMaterialUtils.propRadiusSpace, radiusSpace );
			Transfer( ShapesMaterialUtils.propScaleMode, scaleMode );
			Transfer( ShapesMaterialUtils.propThickness, thickness );
			Transfer( ShapesMaterialUtils.propThicknessSpace, thicknessSpace );
		}

	}

	internal class MpbTriangle : MetaMpb, IDashableMpb {

		internal readonly List<Vector4> a = InitList<Vector4>();
		internal readonly List<Vector4> b = InitList<Vector4>();
		internal readonly List<Vector4> c = InitList<Vector4>();
		internal readonly List<Vector4> colorB = InitList<Vector4>();
		internal readonly List<Vector4> colorC = InitList<Vector4>();
		internal readonly List<float> hollow = InitList<float>();
		internal readonly List<float> roundness = InitList<float>();
		internal readonly List<float> scaleMode = InitList<float>();
		internal readonly List<float> thickness = InitList<float>();
		internal readonly List<float> thicknessSpace = InitList<float>();

		// dash boilerplate
		List<float> IDashableMpb.dashOffset { get; } = InitList<float>();
		List<float> IDashableMpb.dashShapeModifier { get; } = InitList<float>();
		List<float> IDashableMpb.dashSize { get; } = InitList<float>();
		List<float> IDashableMpb.dashSnap { get; } = InitList<float>();
		List<float> IDashableMpb.dashSpace { get; } = InitList<float>();
		List<float> IDashableMpb.dashSpacing { get; } = InitList<float>();
		List<float> IDashableMpb.dashType { get; } = InitList<float>();

		protected override void TransferShapeProperties() {
			Transfer( ShapesMaterialUtils.propA, a );
			Transfer( ShapesMaterialUtils.propB, b );
			Transfer( ShapesMaterialUtils.propC, c );
			Transfer( ShapesMaterialUtils.propColorB, colorB );
			Transfer( ShapesMaterialUtils.propColorC, colorC );
			Transfer( ShapesMaterialUtils.propBorder, hollow );
			Transfer( ShapesMaterialUtils.propRoundness, roundness );
			Transfer( ShapesMaterialUtils.propScaleMode, scaleMode );
			Transfer( ShapesMaterialUtils.propThickness, thickness );
			Transfer( ShapesMaterialUtils.propThicknessSpace, thicknessSpace );
		}

	}

	internal class MpbText : MetaMpb {
		protected override void TransferShapeProperties() => _ = 0; // :>
	}

}
