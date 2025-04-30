using Friflo.EcGui;
using Godot;

// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Demo;

internal sealed class Vector2Drawer : TypeDrawer
{
    public  override    string[]    SortFields      => ["X", "Y"];
    public  override    string[]    FormatFields    => ["Y", "Y"];
    public override     int         DefaultWidth    => 250;

    public override ItemFlags DrawValue(in DrawValue drawValue)
    {
        if (!drawValue.GetValue<Vector2>(out var value, out var exception)) {
            return drawValue.DrawException(exception);
        }
        if (EcUtils.InputFloat2(ref value.X, ref value.Y, drawValue, out var flags)) {
            drawValue.SetValue(value);
        }
        return flags;
    }
    
    public  override void Format(MemberFormat format) {
        format.GetValue<Vector2>(out var value, out var exception);
        format.Append(value.X, exception);
        format.Append(value.Y, exception);
    }
}

internal sealed class Vector3Drawer : TypeDrawer
{
    public  override     int        DefaultWidth    => 400;
    public  override     string[]   SortFields      => ["X", "Y", "Z"];
    public  override     string[]   FormatFields    => ["X", "Y", "Z"];

    public override ItemFlags DrawValue(in DrawValue drawValue) {
        if (!drawValue.GetValue<Vector3>(out var value, out var exception)) {
            return drawValue.DrawException(exception);
        }
        if (EcUtils.InputFloat3(ref value.X, ref value.Y, ref value.Z, drawValue, out var flags)) {
            drawValue.SetValue(value);
        }
        return flags;
    }
    
    public  override void Format(MemberFormat format) {
        format.GetValue<Vector3>(out var value, out var exception);
        format.Append(value.X, exception);
        format.Append(value.Y, exception);
        format.Append(value.Z, exception);
    }
}

internal sealed class Vector4Drawer : TypeDrawer
{
    public  override     int        DefaultWidth    => 500;
    public  override     string[]   SortFields      => ["X", "Y", "Z", "W"];
    public  override     string[]   FormatFields    => ["X", "Y", "Z", "W"];

    public override ItemFlags DrawValue(in DrawValue drawValue) {
        if (!drawValue.GetValue<Vector4>(out var value, out var exception)) {
            return drawValue.DrawException(exception);
        }
        if (EcUtils.InputFloat4(ref value.X, ref value.Y, ref value.Z, ref value.W, drawValue, out var flags)) {
            drawValue.SetValue(value);
        }
        return flags;
    }
    
    public  override void Format(MemberFormat format) {
        format.GetValue<Vector4>(out var value, out var exception);
        format.Append(value.X, exception);
        format.Append(value.Y, exception);
        format.Append(value.Z, exception);
        format.Append(value.W, exception);
    }
}


internal sealed class ColorDrawer : TypeDrawer
{
    public  override    string[]    SortFields      => ["R", "G", "B", "A"];
    public  override    string[]    FormatFields    => ["R", "G", "B", "A"];
    public override     int         DefaultWidth    => 400;

    public override ItemFlags DrawValue(in DrawValue drawValue)
    {
        if (!drawValue.GetValue<Color>(out var value, out var exception)) {
            return drawValue.DrawException(exception);
        }
        if (EcUtils.ColorEdit4(ref value.R, ref value.G, ref value.B, ref value.A, drawValue, out var flags)) {
            drawValue.SetValue(value);
        }
        return flags;
    }
    
    public  override void Format(MemberFormat format) {
        format.GetValue<Color>(out var value, out var exception);
        format.Append(value.R, exception);
        format.Append(value.G, exception);
        format.Append(value.B, exception);
        format.Append(value.A, exception);
    }
}


