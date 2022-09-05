// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FoundationInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from FoundationInfo.proto</summary>
  public static partial class FoundationInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for FoundationInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FoundationInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRGb3VuZGF0aW9uSW5mby5wcm90bxoWRm91bmRhdGlvblN0YXR1cy5wcm90",
            "byJ/Cg5Gb3VuZGF0aW9uSW5mbxIhCgZzdGF0dXMYASABKA4yES5Gb3VuZGF0",
            "aW9uU3RhdHVzEhAKCHVpZF9saXN0GAIgAygNEhsKE2N1cnJlbnRfYnVpbGRp",
            "bmdfaWQYAyABKA0SGwoTYmVnaW5fYnVpbGRfdGltZV9tcxgEIAEoDUIaqgIX",
            "V2VlZHdhY2tlci5TZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.FoundationStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.FoundationInfo), global::Weedwacker.Server.Proto.FoundationInfo.Parser, new[]{ "Status", "UidList", "CurrentBuildingId", "BeginBuildTimeMs" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FoundationInfo : pb::IMessage<FoundationInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FoundationInfo> _parser = new pb::MessageParser<FoundationInfo>(() => new FoundationInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FoundationInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.FoundationInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FoundationInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FoundationInfo(FoundationInfo other) : this() {
      status_ = other.status_;
      uidList_ = other.uidList_.Clone();
      currentBuildingId_ = other.currentBuildingId_;
      beginBuildTimeMs_ = other.beginBuildTimeMs_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FoundationInfo Clone() {
      return new FoundationInfo(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::Weedwacker.Server.Proto.FoundationStatus status_ = global::Weedwacker.Server.Proto.FoundationStatus.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.FoundationStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "uid_list" field.</summary>
    public const int UidListFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_uidList_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> uidList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UidList {
      get { return uidList_; }
    }

    /// <summary>Field number for the "current_building_id" field.</summary>
    public const int CurrentBuildingIdFieldNumber = 3;
    private uint currentBuildingId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurrentBuildingId {
      get { return currentBuildingId_; }
      set {
        currentBuildingId_ = value;
      }
    }

    /// <summary>Field number for the "begin_build_time_ms" field.</summary>
    public const int BeginBuildTimeMsFieldNumber = 4;
    private uint beginBuildTimeMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BeginBuildTimeMs {
      get { return beginBuildTimeMs_; }
      set {
        beginBuildTimeMs_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FoundationInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FoundationInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if(!uidList_.Equals(other.uidList_)) return false;
      if (CurrentBuildingId != other.CurrentBuildingId) return false;
      if (BeginBuildTimeMs != other.BeginBuildTimeMs) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != global::Weedwacker.Server.Proto.FoundationStatus.None) hash ^= Status.GetHashCode();
      hash ^= uidList_.GetHashCode();
      if (CurrentBuildingId != 0) hash ^= CurrentBuildingId.GetHashCode();
      if (BeginBuildTimeMs != 0) hash ^= BeginBuildTimeMs.GetHashCode();
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
      if (Status != global::Weedwacker.Server.Proto.FoundationStatus.None) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
      }
      uidList_.WriteTo(output, _repeated_uidList_codec);
      if (CurrentBuildingId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CurrentBuildingId);
      }
      if (BeginBuildTimeMs != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(BeginBuildTimeMs);
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
      if (Status != global::Weedwacker.Server.Proto.FoundationStatus.None) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
      }
      uidList_.WriteTo(ref output, _repeated_uidList_codec);
      if (CurrentBuildingId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CurrentBuildingId);
      }
      if (BeginBuildTimeMs != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(BeginBuildTimeMs);
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
      if (Status != global::Weedwacker.Server.Proto.FoundationStatus.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      size += uidList_.CalculateSize(_repeated_uidList_codec);
      if (CurrentBuildingId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurrentBuildingId);
      }
      if (BeginBuildTimeMs != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BeginBuildTimeMs);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FoundationInfo other) {
      if (other == null) {
        return;
      }
      if (other.Status != global::Weedwacker.Server.Proto.FoundationStatus.None) {
        Status = other.Status;
      }
      uidList_.Add(other.uidList_);
      if (other.CurrentBuildingId != 0) {
        CurrentBuildingId = other.CurrentBuildingId;
      }
      if (other.BeginBuildTimeMs != 0) {
        BeginBuildTimeMs = other.BeginBuildTimeMs;
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
          case 8: {
            Status = (global::Weedwacker.Server.Proto.FoundationStatus) input.ReadEnum();
            break;
          }
          case 18:
          case 16: {
            uidList_.AddEntriesFrom(input, _repeated_uidList_codec);
            break;
          }
          case 24: {
            CurrentBuildingId = input.ReadUInt32();
            break;
          }
          case 32: {
            BeginBuildTimeMs = input.ReadUInt32();
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
          case 8: {
            Status = (global::Weedwacker.Server.Proto.FoundationStatus) input.ReadEnum();
            break;
          }
          case 18:
          case 16: {
            uidList_.AddEntriesFrom(ref input, _repeated_uidList_codec);
            break;
          }
          case 24: {
            CurrentBuildingId = input.ReadUInt32();
            break;
          }
          case 32: {
            BeginBuildTimeMs = input.ReadUInt32();
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