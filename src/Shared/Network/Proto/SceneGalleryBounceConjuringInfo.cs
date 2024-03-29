// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneGalleryBounceConjuringInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from SceneGalleryBounceConjuringInfo.proto</summary>
  public static partial class SceneGalleryBounceConjuringInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneGalleryBounceConjuringInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneGalleryBounceConjuringInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVTY2VuZUdhbGxlcnlCb3VuY2VDb25qdXJpbmdJbmZvLnByb3RvIl0KH1Nj",
            "ZW5lR2FsbGVyeUJvdW5jZUNvbmp1cmluZ0luZm8SJQoddG90YWxfZGVzdHJv",
            "eWVkX21hY2hpbmVfY291bnQYBCABKA0SEwoLdG90YWxfc2NvcmUYBiABKA1C",
            "IqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.SceneGalleryBounceConjuringInfo), global::Weedwacker.Shared.Network.Proto.SceneGalleryBounceConjuringInfo.Parser, new[]{ "TotalDestroyedMachineCount", "TotalScore" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SceneGalleryBounceConjuringInfo : pb::IMessage<SceneGalleryBounceConjuringInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneGalleryBounceConjuringInfo> _parser = new pb::MessageParser<SceneGalleryBounceConjuringInfo>(() => new SceneGalleryBounceConjuringInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneGalleryBounceConjuringInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.SceneGalleryBounceConjuringInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryBounceConjuringInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryBounceConjuringInfo(SceneGalleryBounceConjuringInfo other) : this() {
      totalDestroyedMachineCount_ = other.totalDestroyedMachineCount_;
      totalScore_ = other.totalScore_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryBounceConjuringInfo Clone() {
      return new SceneGalleryBounceConjuringInfo(this);
    }

    /// <summary>Field number for the "total_destroyed_machine_count" field.</summary>
    public const int TotalDestroyedMachineCountFieldNumber = 4;
    private uint totalDestroyedMachineCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalDestroyedMachineCount {
      get { return totalDestroyedMachineCount_; }
      set {
        totalDestroyedMachineCount_ = value;
      }
    }

    /// <summary>Field number for the "total_score" field.</summary>
    public const int TotalScoreFieldNumber = 6;
    private uint totalScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalScore {
      get { return totalScore_; }
      set {
        totalScore_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneGalleryBounceConjuringInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneGalleryBounceConjuringInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TotalDestroyedMachineCount != other.TotalDestroyedMachineCount) return false;
      if (TotalScore != other.TotalScore) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TotalDestroyedMachineCount != 0) hash ^= TotalDestroyedMachineCount.GetHashCode();
      if (TotalScore != 0) hash ^= TotalScore.GetHashCode();
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
      if (TotalDestroyedMachineCount != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(TotalDestroyedMachineCount);
      }
      if (TotalScore != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(TotalScore);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (TotalDestroyedMachineCount != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(TotalDestroyedMachineCount);
      }
      if (TotalScore != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(TotalScore);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (TotalDestroyedMachineCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalDestroyedMachineCount);
      }
      if (TotalScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalScore);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneGalleryBounceConjuringInfo other) {
      if (other == null) {
        return;
      }
      if (other.TotalDestroyedMachineCount != 0) {
        TotalDestroyedMachineCount = other.TotalDestroyedMachineCount;
      }
      if (other.TotalScore != 0) {
        TotalScore = other.TotalScore;
      }
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
          case 32: {
            TotalDestroyedMachineCount = input.ReadUInt32();
            break;
          }
          case 48: {
            TotalScore = input.ReadUInt32();
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
          case 32: {
            TotalDestroyedMachineCount = input.ReadUInt32();
            break;
          }
          case 48: {
            TotalScore = input.ReadUInt32();
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
