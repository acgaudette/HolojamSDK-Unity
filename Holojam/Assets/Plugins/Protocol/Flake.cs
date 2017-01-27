// automatically generated by the FlatBuffers compiler, do not modify

namespace Holojam.Protocol
{

using System;
using FlatBuffers;

public struct Flake : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static Flake GetRootAsFlake(ByteBuffer _bb) { return GetRootAsFlake(_bb, new Flake()); }
  public static Flake GetRootAsFlake(ByteBuffer _bb, Flake obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Flake __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Label { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetLabelBytes() { return __p.__vector_as_arraysegment(4); }
  public Vector3? Triples(int j) { int o = __p.__offset(6); return o != 0 ? (Vector3?)(new Vector3()).__assign(__p.__vector(o) + j * 12, __p.bb) : null; }
  public int TriplesLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
  public Vector4? Quads(int j) { int o = __p.__offset(8); return o != 0 ? (Vector4?)(new Vector4()).__assign(__p.__vector(o) + j * 16, __p.bb) : null; }
  public int QuadsLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
  public float Floats(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int FloatsLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetFloatsBytes() { return __p.__vector_as_arraysegment(10); }
  public int Ints(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int IntsLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetIntsBytes() { return __p.__vector_as_arraysegment(12); }
  public sbyte Chars(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetSbyte(__p.__vector(o) + j * 1) : (sbyte)0; }
  public int CharsLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetCharsBytes() { return __p.__vector_as_arraysegment(14); }
  public string Text { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetTextBytes() { return __p.__vector_as_arraysegment(16); }

  public static Offset<Flake> CreateFlake(FlatBufferBuilder builder,
      StringOffset labelOffset = default(StringOffset),
      VectorOffset triplesOffset = default(VectorOffset),
      VectorOffset quadsOffset = default(VectorOffset),
      VectorOffset floatsOffset = default(VectorOffset),
      VectorOffset intsOffset = default(VectorOffset),
      VectorOffset charsOffset = default(VectorOffset),
      StringOffset textOffset = default(StringOffset)) {
    builder.StartObject(7);
    Flake.AddText(builder, textOffset);
    Flake.AddChars(builder, charsOffset);
    Flake.AddInts(builder, intsOffset);
    Flake.AddFloats(builder, floatsOffset);
    Flake.AddQuads(builder, quadsOffset);
    Flake.AddTriples(builder, triplesOffset);
    Flake.AddLabel(builder, labelOffset);
    return Flake.EndFlake(builder);
  }

  public static void StartFlake(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddLabel(FlatBufferBuilder builder, StringOffset labelOffset) { builder.AddOffset(0, labelOffset.Value, 0); }
  public static void AddTriples(FlatBufferBuilder builder, VectorOffset triplesOffset) { builder.AddOffset(1, triplesOffset.Value, 0); }
  public static void StartTriplesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(12, numElems, 4); }
  public static void AddQuads(FlatBufferBuilder builder, VectorOffset quadsOffset) { builder.AddOffset(2, quadsOffset.Value, 0); }
  public static void StartQuadsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(16, numElems, 4); }
  public static void AddFloats(FlatBufferBuilder builder, VectorOffset floatsOffset) { builder.AddOffset(3, floatsOffset.Value, 0); }
  public static VectorOffset CreateFloatsVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static void StartFloatsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddInts(FlatBufferBuilder builder, VectorOffset intsOffset) { builder.AddOffset(4, intsOffset.Value, 0); }
  public static VectorOffset CreateIntsVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartIntsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddChars(FlatBufferBuilder builder, VectorOffset charsOffset) { builder.AddOffset(5, charsOffset.Value, 0); }
  public static VectorOffset CreateCharsVector(FlatBufferBuilder builder, sbyte[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddSbyte(data[i]); return builder.EndVector(); }
  public static void StartCharsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static void AddText(FlatBufferBuilder builder, StringOffset textOffset) { builder.AddOffset(6, textOffset.Value, 0); }
  public static Offset<Flake> EndFlake(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    builder.Required(o, 4);  // label
    return new Offset<Flake>(o);
  }
};


}