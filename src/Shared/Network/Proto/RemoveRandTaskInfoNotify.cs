// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RemoveRandTaskInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from RemoveRandTaskInfoNotify.proto</summary>
  public static partial class RemoveRandTaskInfoNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for RemoveRandTaskInfoNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RemoveRandTaskInfoNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5SZW1vdmVSYW5kVGFza0luZm9Ob3RpZnkucHJvdG8i8wEKGFJlbW92ZVJh",
            "bmRUYXNrSW5mb05vdGlmeRIPCgdpc19zdWNjGAkgASgIEjYKBnJlYXNvbhgK",
            "IAEoDjImLlJlbW92ZVJhbmRUYXNrSW5mb05vdGlmeS5GaW5pc2hSZWFzb24S",
            "FAoMcmFuZF90YXNrX2lkGA0gASgNIngKDEZpbmlzaFJlYXNvbhIZChVGSU5J",
            "U0hfUkVBU09OX0RFRkFVTFQQABIXChNGSU5JU0hfUkVBU09OX0NMRUFSEAES",
            "GgoWRklOSVNIX1JFQVNPTl9ESVNUQU5DRRACEhgKFEZJTklTSF9SRUFTT05f",
            "RklOSVNIEANCIqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9i",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.RemoveRandTaskInfoNotify), global::Weedwacker.Shared.Network.Proto.RemoveRandTaskInfoNotify.Parser, new[]{ "IsSucc", "Reason", "RandTaskId" }, null, new[]{ typeof(global::Weedwacker.Shared.Network.Proto.RemoveRandTaskInfoNotify.Types.FinishReason) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 161
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class RemoveRandTaskInfoNotify : pb::IMessage<RemoveRandTaskInfoNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RemoveRandTaskInfoNotify> _parser = new pb::MessageParser<RemoveRandTaskInfoNotify>(() => new RemoveRandTaskInfoNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RemoveRandTaskInfoNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.RemoveRandTaskInfoNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RemoveRandTaskInfoNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RemoveRandTaskInfoNotify(RemoveRandTaskInfoNotify other) : this() {
      isSucc_ = other.isSucc_;
      reason_ = other.reason_;
      randTaskId_ = other.randTaskId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RemoveRandTaskInfoNotify Clone() {
      return new RemoveRandTaskInfoNotify(this);
    }

    /// <summary>Field number for the "is_succ" field.</summary>
    public const int IsSuccFieldNumber = 9;
    private bool isSucc_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSucc {
      get { return isSucc_; }
      set {
        isSucc_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 10;
    private global::Weedwacker.Shared.Network.Proto.RemoveRandTaskInfoNotify.Types.FinishReason reason_ = global::Weedwacker.Shared.Network.Proto.RemoveRandTaskInfoNotify.Types.FinishReason.Default;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.RemoveRandTaskInfoNotify.Types.FinishReason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    /// <summary>Field number for the "rand_task_id" field.</summary>
    public const int RandTaskIdFieldNumber = 13;
    private uint randTaskId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RandTaskId {
      get { return randTaskId_; }
      set {
        randTaskId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RemoveRandTaskInfoNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RemoveRandTaskInfoNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsSucc != other.IsSucc) return false;
      if (Reason != other.Reason) return false;
      if (RandTaskId != other.RandTaskId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsSucc != false) hash ^= IsSucc.GetHashCode();
      if (Reason != global::Weedwacker.Shared.Network.Proto.RemoveRandTaskInfoNotify.Types.FinishReason.Default) hash ^= Reason.GetHashCode();
      if (RandTaskId != 0) hash ^= RandTaskId.GetHashCode();
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
      if (IsSucc != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsSucc);
      }
      if (Reason != global::Weedwacker.Shared.Network.Proto.RemoveRandTaskInfoNotify.Types.FinishReason.Default) {
        output.WriteRawTag(80);
        output.WriteEnum((int) Reason);
      }
      if (RandTaskId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(RandTaskId);
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
      if (IsSucc != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsSucc);
      }
      if (Reason != global::Weedwacker.Shared.Network.Proto.RemoveRandTaskInfoNotify.Types.FinishReason.Default) {
        output.WriteRawTag(80);
        output.WriteEnum((int) Reason);
      }
      if (RandTaskId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(RandTaskId);
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
      if (IsSucc != false) {
        size += 1 + 1;
      }
      if (Reason != global::Weedwacker.Shared.Network.Proto.RemoveRandTaskInfoNotify.Types.FinishReason.Default) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (RandTaskId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RandTaskId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RemoveRandTaskInfoNotify other) {
      if (other == null) {
        return;
      }
      if (other.IsSucc != false) {
        IsSucc = other.IsSucc;
      }
      if (other.Reason != global::Weedwacker.Shared.Network.Proto.RemoveRandTaskInfoNotify.Types.FinishReason.Default) {
        Reason = other.Reason;
      }
      if (other.RandTaskId != 0) {
        RandTaskId = other.RandTaskId;
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
          case 72: {
            IsSucc = input.ReadBool();
            break;
          }
          case 80: {
            Reason = (global::Weedwacker.Shared.Network.Proto.RemoveRandTaskInfoNotify.Types.FinishReason) input.ReadEnum();
            break;
          }
          case 104: {
            RandTaskId = input.ReadUInt32();
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
          case 72: {
            IsSucc = input.ReadBool();
            break;
          }
          case 80: {
            Reason = (global::Weedwacker.Shared.Network.Proto.RemoveRandTaskInfoNotify.Types.FinishReason) input.ReadEnum();
            break;
          }
          case 104: {
            RandTaskId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the RemoveRandTaskInfoNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum FinishReason {
        [pbr::OriginalName("FINISH_REASON_DEFAULT")] Default = 0,
        [pbr::OriginalName("FINISH_REASON_CLEAR")] Clear = 1,
        [pbr::OriginalName("FINISH_REASON_DISTANCE")] Distance = 2,
        [pbr::OriginalName("FINISH_REASON_FINISH")] Finish = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
