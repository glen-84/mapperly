﻿//HintName: Mapper.g.cs
// <auto-generated />
#nullable enable
public partial class Mapper
{
    partial global::B Map(global::A source)
    {
        var target = new global::B();
        target.SetValue(source.GetNested().GetValue());
        return target;
    }
}
    
static file class UnsafeAccessor
{
    [global::System.Runtime.CompilerServices.UnsafeAccessor(global::System.Runtime.CompilerServices.UnsafeAccessorKind.Method, Name = "get_nested")]
    public static extern global::C GetNested(this global::A source);

    [global::System.Runtime.CompilerServices.UnsafeAccessor(global::System.Runtime.CompilerServices.UnsafeAccessorKind.Method, Name = "get_value")]
    public static extern int GetValue(this global::C source);

    [global::System.Runtime.CompilerServices.UnsafeAccessor(global::System.Runtime.CompilerServices.UnsafeAccessorKind.Method, Name = "set_value")]
    public static extern void SetValue(this global::B target, int value);
}