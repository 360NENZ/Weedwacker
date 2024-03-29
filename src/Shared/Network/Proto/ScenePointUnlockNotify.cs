// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ScenePointUnlockNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ScenePointUnlockNotify.proto</summary>
  public static partial class ScenePointUnlockNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ScenePointUnlockNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ScenePointUnlockNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxTY2VuZVBvaW50VW5sb2NrTm90aWZ5LnByb3RvIo0BChZTY2VuZVBvaW50",
            "VW5sb2NrTm90aWZ5EhIKCnBvaW50X2xpc3QYDSADKA0SEAoIc2NlbmVfaWQY",
            "BiABKA0SGQoRdW5oaWRlX3BvaW50X2xpc3QYDCADKA0SFwoPaGlkZV9wb2lu",
            "dF9saXN0GAEgAygNEhkKEWxvY2tlZF9wb2ludF9saXN0GAggAygNQiKqAh9X",
            "ZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ScenePointUnlockNotify), global::Weedwacker.Shared.Network.Proto.ScenePointUnlockNotify.Parser, new[]{ "PointList", "SceneId", "UnhidePointList", "HidePointList", "LockedPointList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 247
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class ScenePointUnlockNotify : pb::IMessage<ScenePointUnlockNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ScenePointUnlockNotify> _parser = new pb::MessageParser<ScenePointUnlockNotify>(() => new ScenePointUnlockNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ScenePointUnlockNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ScenePointUnlockNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScenePointUnlockNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScenePointUnlockNotify(ScenePointUnlockNotify other) : this() {
      pointList_ = other.pointList_.Clone();
      sceneId_ = other.sceneId_;
      unhidePointList_ = other.unhidePointList_.Clone();
      hidePointList_ = other.hidePointList_.Clone();
      lockedPointList_ = other.lockedPointList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScenePointUnlockNotify Clone() {
      return new ScenePointUnlockNotify(this);
    }

    /// <summary>Field number for the "point_list" field.</summary>
    public const int PointListFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_pointList_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> pointList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> PointList {
      get { return pointList_; }
    }

    /// <summary>Field number for the "scene_id" field.</summary>
    public const int SceneIdFieldNumber = 6;
    private uint sceneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneId {
      get { return sceneId_; }
      set {
        sceneId_ = value;
      }
    }

    /// <summary>Field number for the "unhide_point_list" field.</summary>
    public const int UnhidePointListFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_unhidePointList_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> unhidePointList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UnhidePointList {
      get { return unhidePointList_; }
    }

    /// <summary>Field number for the "hide_point_list" field.</summary>
    public const int HidePointListFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_hidePointList_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> hidePointList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> HidePointList {
      get { return hidePointList_; }
    }

    /// <summary>Field number for the "locked_point_list" field.</summary>
    public const int LockedPointListFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_lockedPointList_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> lockedPointList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> LockedPointList {
      get { return lockedPointList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ScenePointUnlockNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ScenePointUnlockNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!pointList_.Equals(other.pointList_)) return false;
      if (SceneId != other.SceneId) return false;
      if(!unhidePointList_.Equals(other.unhidePointList_)) return false;
      if(!hidePointList_.Equals(other.hidePointList_)) return false;
      if(!lockedPointList_.Equals(other.lockedPointList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= pointList_.GetHashCode();
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
      hash ^= unhidePointList_.GetHashCode();
      hash ^= hidePointList_.GetHashCode();
      hash ^= lockedPointList_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      hidePointList_.WriteTo(output, _repeated_hidePointList_codec);
      if (SceneId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(SceneId);
      }
      lockedPointList_.WriteTo(output, _repeated_lockedPointList_codec);
      unhidePointList_.WriteTo(output, _repeated_unhidePointList_codec);
      pointList_.WriteTo(output, _repeated_pointList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      hidePointList_.WriteTo(ref output, _repeated_hidePointList_codec);
      if (SceneId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(SceneId);
      }
      lockedPointList_.WriteTo(ref output, _repeated_lockedPointList_codec);
      unhidePointList_.WriteTo(ref output, _repeated_unhidePointList_codec);
      pointList_.WriteTo(ref output, _repeated_pointList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += pointList_.CalculateSize(_repeated_pointList_codec);
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneId);
      }
      size += unhidePointList_.CalculateSize(_repeated_unhidePointList_codec);
      size += hidePointList_.CalculateSize(_repeated_hidePointList_codec);
      size += lockedPointList_.CalculateSize(_repeated_lockedPointList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ScenePointUnlockNotify other) {
      if (other == null) {
        return;
      }
      pointList_.Add(other.pointList_);
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
      }
      unhidePointList_.Add(other.unhidePointList_);
      hidePointList_.Add(other.hidePointList_);
      lockedPointList_.Add(other.lockedPointList_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10:
          case 8: {
            hidePointList_.AddEntriesFrom(input, _repeated_hidePointList_codec);
            break;
          }
          case 48: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 66:
          case 64: {
            lockedPointList_.AddEntriesFrom(input, _repeated_lockedPointList_codec);
            break;
          }
          case 98:
          case 96: {
            unhidePointList_.AddEntriesFrom(input, _repeated_unhidePointList_codec);
            break;
          }
          case 106:
          case 104: {
            pointList_.AddEntriesFrom(input, _repeated_pointList_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10:
          case 8: {
            hidePointList_.AddEntriesFrom(ref input, _repeated_hidePointList_codec);
            break;
          }
          case 48: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 66:
          case 64: {
            lockedPointList_.AddEntriesFrom(ref input, _repeated_lockedPointList_codec);
            break;
          }
          case 98:
          case 96: {
            unhidePointList_.AddEntriesFrom(ref input, _repeated_unhidePointList_codec);
            break;
          }
          case 106:
          case 104: {
            pointList_.AddEntriesFrom(ref input, _repeated_pointList_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
