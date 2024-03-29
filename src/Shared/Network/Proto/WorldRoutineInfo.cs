// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WorldRoutineInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from WorldRoutineInfo.proto</summary>
  public static partial class WorldRoutineInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for WorldRoutineInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WorldRoutineInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZXb3JsZFJvdXRpbmVJbmZvLnByb3RvImYKEFdvcmxkUm91dGluZUluZm8S",
            "EAoIcHJvZ3Jlc3MYBCABKA0SEwoLaXNfZmluaXNoZWQYDiABKAgSFwoPZmlu",
            "aXNoX3Byb2dyZXNzGAMgASgNEhIKCnJvdXRpbmVfaWQYCyABKA1CIqoCH1dl",
            "ZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.WorldRoutineInfo), global::Weedwacker.Shared.Network.Proto.WorldRoutineInfo.Parser, new[]{ "Progress", "IsFinished", "FinishProgress", "RoutineId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class WorldRoutineInfo : pb::IMessage<WorldRoutineInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WorldRoutineInfo> _parser = new pb::MessageParser<WorldRoutineInfo>(() => new WorldRoutineInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WorldRoutineInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.WorldRoutineInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WorldRoutineInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WorldRoutineInfo(WorldRoutineInfo other) : this() {
      progress_ = other.progress_;
      isFinished_ = other.isFinished_;
      finishProgress_ = other.finishProgress_;
      routineId_ = other.routineId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WorldRoutineInfo Clone() {
      return new WorldRoutineInfo(this);
    }

    /// <summary>Field number for the "progress" field.</summary>
    public const int ProgressFieldNumber = 4;
    private uint progress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Progress {
      get { return progress_; }
      set {
        progress_ = value;
      }
    }

    /// <summary>Field number for the "is_finished" field.</summary>
    public const int IsFinishedFieldNumber = 14;
    private bool isFinished_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFinished {
      get { return isFinished_; }
      set {
        isFinished_ = value;
      }
    }

    /// <summary>Field number for the "finish_progress" field.</summary>
    public const int FinishProgressFieldNumber = 3;
    private uint finishProgress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FinishProgress {
      get { return finishProgress_; }
      set {
        finishProgress_ = value;
      }
    }

    /// <summary>Field number for the "routine_id" field.</summary>
    public const int RoutineIdFieldNumber = 11;
    private uint routineId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RoutineId {
      get { return routineId_; }
      set {
        routineId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WorldRoutineInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WorldRoutineInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Progress != other.Progress) return false;
      if (IsFinished != other.IsFinished) return false;
      if (FinishProgress != other.FinishProgress) return false;
      if (RoutineId != other.RoutineId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Progress != 0) hash ^= Progress.GetHashCode();
      if (IsFinished != false) hash ^= IsFinished.GetHashCode();
      if (FinishProgress != 0) hash ^= FinishProgress.GetHashCode();
      if (RoutineId != 0) hash ^= RoutineId.GetHashCode();
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
      if (FinishProgress != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(FinishProgress);
      }
      if (Progress != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Progress);
      }
      if (RoutineId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(RoutineId);
      }
      if (IsFinished != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsFinished);
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
      if (FinishProgress != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(FinishProgress);
      }
      if (Progress != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Progress);
      }
      if (RoutineId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(RoutineId);
      }
      if (IsFinished != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsFinished);
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
      if (Progress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Progress);
      }
      if (IsFinished != false) {
        size += 1 + 1;
      }
      if (FinishProgress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinishProgress);
      }
      if (RoutineId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RoutineId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WorldRoutineInfo other) {
      if (other == null) {
        return;
      }
      if (other.Progress != 0) {
        Progress = other.Progress;
      }
      if (other.IsFinished != false) {
        IsFinished = other.IsFinished;
      }
      if (other.FinishProgress != 0) {
        FinishProgress = other.FinishProgress;
      }
      if (other.RoutineId != 0) {
        RoutineId = other.RoutineId;
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
          case 24: {
            FinishProgress = input.ReadUInt32();
            break;
          }
          case 32: {
            Progress = input.ReadUInt32();
            break;
          }
          case 88: {
            RoutineId = input.ReadUInt32();
            break;
          }
          case 112: {
            IsFinished = input.ReadBool();
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
          case 24: {
            FinishProgress = input.ReadUInt32();
            break;
          }
          case 32: {
            Progress = input.ReadUInt32();
            break;
          }
          case 88: {
            RoutineId = input.ReadUInt32();
            break;
          }
          case 112: {
            IsFinished = input.ReadBool();
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
