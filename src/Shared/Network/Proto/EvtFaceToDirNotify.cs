// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtFaceToDirNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from EvtFaceToDirNotify.proto</summary>
  public static partial class EvtFaceToDirNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for EvtFaceToDirNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EvtFaceToDirNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhFdnRGYWNlVG9EaXJOb3RpZnkucHJvdG8aFkV2dEZhY2VUb0RpckluZm8u",
            "cHJvdG8aEUZvcndhcmRUeXBlLnByb3RvImkKEkV2dEZhY2VUb0Rpck5vdGlm",
            "eRIiCgxmb3J3YXJkX3R5cGUYDSABKA4yDC5Gb3J3YXJkVHlwZRIvChRldnRf",
            "ZmFjZV90b19kaXJfaW5mbxgFIAEoCzIRLkV2dEZhY2VUb0RpckluZm9CIqoC",
            "H1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.EvtFaceToDirInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.ForwardTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.EvtFaceToDirNotify), global::Weedwacker.Shared.Network.Proto.EvtFaceToDirNotify.Parser, new[]{ "ForwardType", "EvtFaceToDirInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 390
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class EvtFaceToDirNotify : pb::IMessage<EvtFaceToDirNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EvtFaceToDirNotify> _parser = new pb::MessageParser<EvtFaceToDirNotify>(() => new EvtFaceToDirNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EvtFaceToDirNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.EvtFaceToDirNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtFaceToDirNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtFaceToDirNotify(EvtFaceToDirNotify other) : this() {
      forwardType_ = other.forwardType_;
      evtFaceToDirInfo_ = other.evtFaceToDirInfo_ != null ? other.evtFaceToDirInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtFaceToDirNotify Clone() {
      return new EvtFaceToDirNotify(this);
    }

    /// <summary>Field number for the "forward_type" field.</summary>
    public const int ForwardTypeFieldNumber = 13;
    private global::Weedwacker.Shared.Network.Proto.ForwardType forwardType_ = global::Weedwacker.Shared.Network.Proto.ForwardType.Local;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.ForwardType ForwardType {
      get { return forwardType_; }
      set {
        forwardType_ = value;
      }
    }

    /// <summary>Field number for the "evt_face_to_dir_info" field.</summary>
    public const int EvtFaceToDirInfoFieldNumber = 5;
    private global::Weedwacker.Shared.Network.Proto.EvtFaceToDirInfo evtFaceToDirInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.EvtFaceToDirInfo EvtFaceToDirInfo {
      get { return evtFaceToDirInfo_; }
      set {
        evtFaceToDirInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EvtFaceToDirNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EvtFaceToDirNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ForwardType != other.ForwardType) return false;
      if (!object.Equals(EvtFaceToDirInfo, other.EvtFaceToDirInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ForwardType != global::Weedwacker.Shared.Network.Proto.ForwardType.Local) hash ^= ForwardType.GetHashCode();
      if (evtFaceToDirInfo_ != null) hash ^= EvtFaceToDirInfo.GetHashCode();
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
      if (evtFaceToDirInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(EvtFaceToDirInfo);
      }
      if (ForwardType != global::Weedwacker.Shared.Network.Proto.ForwardType.Local) {
        output.WriteRawTag(104);
        output.WriteEnum((int) ForwardType);
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
      if (evtFaceToDirInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(EvtFaceToDirInfo);
      }
      if (ForwardType != global::Weedwacker.Shared.Network.Proto.ForwardType.Local) {
        output.WriteRawTag(104);
        output.WriteEnum((int) ForwardType);
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
      if (ForwardType != global::Weedwacker.Shared.Network.Proto.ForwardType.Local) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ForwardType);
      }
      if (evtFaceToDirInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EvtFaceToDirInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EvtFaceToDirNotify other) {
      if (other == null) {
        return;
      }
      if (other.ForwardType != global::Weedwacker.Shared.Network.Proto.ForwardType.Local) {
        ForwardType = other.ForwardType;
      }
      if (other.evtFaceToDirInfo_ != null) {
        if (evtFaceToDirInfo_ == null) {
          EvtFaceToDirInfo = new global::Weedwacker.Shared.Network.Proto.EvtFaceToDirInfo();
        }
        EvtFaceToDirInfo.MergeFrom(other.EvtFaceToDirInfo);
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
          case 42: {
            if (evtFaceToDirInfo_ == null) {
              EvtFaceToDirInfo = new global::Weedwacker.Shared.Network.Proto.EvtFaceToDirInfo();
            }
            input.ReadMessage(EvtFaceToDirInfo);
            break;
          }
          case 104: {
            ForwardType = (global::Weedwacker.Shared.Network.Proto.ForwardType) input.ReadEnum();
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
          case 42: {
            if (evtFaceToDirInfo_ == null) {
              EvtFaceToDirInfo = new global::Weedwacker.Shared.Network.Proto.EvtFaceToDirInfo();
            }
            input.ReadMessage(EvtFaceToDirInfo);
            break;
          }
          case 104: {
            ForwardType = (global::Weedwacker.Shared.Network.Proto.ForwardType) input.ReadEnum();
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
