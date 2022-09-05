// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CoopPointUpdateNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from CoopPointUpdateNotify.proto</summary>
  public static partial class CoopPointUpdateNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for CoopPointUpdateNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CoopPointUpdateNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtDb29wUG9pbnRVcGRhdGVOb3RpZnkucHJvdG8aD0Nvb3BQb2ludC5wcm90",
            "byI3ChVDb29wUG9pbnRVcGRhdGVOb3RpZnkSHgoKY29vcF9wb2ludBgNIAEo",
            "CzIKLkNvb3BQb2ludEIaqgIXV2VlZHdhY2tlci5TZXJ2ZXIuUHJvdG9iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.CoopPointReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.CoopPointUpdateNotify), global::Weedwacker.Server.Proto.CoopPointUpdateNotify.Parser, new[]{ "CoopPoint" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 1991
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class CoopPointUpdateNotify : pb::IMessage<CoopPointUpdateNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CoopPointUpdateNotify> _parser = new pb::MessageParser<CoopPointUpdateNotify>(() => new CoopPointUpdateNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CoopPointUpdateNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.CoopPointUpdateNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CoopPointUpdateNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CoopPointUpdateNotify(CoopPointUpdateNotify other) : this() {
      coopPoint_ = other.coopPoint_ != null ? other.coopPoint_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CoopPointUpdateNotify Clone() {
      return new CoopPointUpdateNotify(this);
    }

    /// <summary>Field number for the "coop_point" field.</summary>
    public const int CoopPointFieldNumber = 13;
    private global::Weedwacker.Server.Proto.CoopPoint coopPoint_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.CoopPoint CoopPoint {
      get { return coopPoint_; }
      set {
        coopPoint_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CoopPointUpdateNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CoopPointUpdateNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CoopPoint, other.CoopPoint)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (coopPoint_ != null) hash ^= CoopPoint.GetHashCode();
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
      if (coopPoint_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(CoopPoint);
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
      if (coopPoint_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(CoopPoint);
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
      if (coopPoint_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CoopPoint);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CoopPointUpdateNotify other) {
      if (other == null) {
        return;
      }
      if (other.coopPoint_ != null) {
        if (coopPoint_ == null) {
          CoopPoint = new global::Weedwacker.Server.Proto.CoopPoint();
        }
        CoopPoint.MergeFrom(other.CoopPoint);
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
          case 106: {
            if (coopPoint_ == null) {
              CoopPoint = new global::Weedwacker.Server.Proto.CoopPoint();
            }
            input.ReadMessage(CoopPoint);
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
          case 106: {
            if (coopPoint_ == null) {
              CoopPoint = new global::Weedwacker.Server.Proto.CoopPoint();
            }
            input.ReadMessage(CoopPoint);
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