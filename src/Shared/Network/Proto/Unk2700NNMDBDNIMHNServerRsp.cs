// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_NNMDBDNIMHN_ServerRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_NNMDBDNIMHN_ServerRsp.proto</summary>
  public static partial class Unk2700NNMDBDNIMHNServerRspReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_NNMDBDNIMHN_ServerRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700NNMDBDNIMHNServerRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNVbmsyNzAwX05OTURCRE5JTUhOX1NlcnZlclJzcC5wcm90bxoZVW5rMjcw",
            "MF9LUE5QSlBQSE9LQS5wcm90byKAAQodVW5rMjcwMF9OTk1EQkROSU1ITl9T",
            "ZXJ2ZXJSc3ASMQoTVW5rMjcwMF9JRk5MSkRDSkpFRBgHIAEoCzIULlVuazI3",
            "MDBfS1BOUEpQUEhPS0ESDwoHcmV0Y29kZRgLIAEoBRIbChNVbmsyNzAwX01B",
            "UEpMSURBQ1BOGAEgASgNQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3Jr",
            "LlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.Unk2700KPNPJPPHOKAReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.Unk2700_NNMDBDNIMHN_ServerRsp), global::Weedwacker.Shared.Network.Proto.Unk2700_NNMDBDNIMHN_ServerRsp.Parser, new[]{ "Unk2700IFNLJDCJJED", "Retcode", "Unk2700MAPJLIDACPN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 4538
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class Unk2700_NNMDBDNIMHN_ServerRsp : pb::IMessage<Unk2700_NNMDBDNIMHN_ServerRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_NNMDBDNIMHN_ServerRsp> _parser = new pb::MessageParser<Unk2700_NNMDBDNIMHN_ServerRsp>(() => new Unk2700_NNMDBDNIMHN_ServerRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_NNMDBDNIMHN_ServerRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.Unk2700NNMDBDNIMHNServerRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_NNMDBDNIMHN_ServerRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_NNMDBDNIMHN_ServerRsp(Unk2700_NNMDBDNIMHN_ServerRsp other) : this() {
      unk2700IFNLJDCJJED_ = other.unk2700IFNLJDCJJED_ != null ? other.unk2700IFNLJDCJJED_.Clone() : null;
      retcode_ = other.retcode_;
      unk2700MAPJLIDACPN_ = other.unk2700MAPJLIDACPN_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_NNMDBDNIMHN_ServerRsp Clone() {
      return new Unk2700_NNMDBDNIMHN_ServerRsp(this);
    }

    /// <summary>Field number for the "Unk2700_IFNLJDCJJED" field.</summary>
    public const int Unk2700IFNLJDCJJEDFieldNumber = 7;
    private global::Weedwacker.Shared.Network.Proto.Unk2700_KPNPJPPHOKA unk2700IFNLJDCJJED_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Unk2700_KPNPJPPHOKA Unk2700IFNLJDCJJED {
      get { return unk2700IFNLJDCJJED_; }
      set {
        unk2700IFNLJDCJJED_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 11;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_MAPJLIDACPN" field.</summary>
    public const int Unk2700MAPJLIDACPNFieldNumber = 1;
    private uint unk2700MAPJLIDACPN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700MAPJLIDACPN {
      get { return unk2700MAPJLIDACPN_; }
      set {
        unk2700MAPJLIDACPN_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_NNMDBDNIMHN_ServerRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_NNMDBDNIMHN_ServerRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Unk2700IFNLJDCJJED, other.Unk2700IFNLJDCJJED)) return false;
      if (Retcode != other.Retcode) return false;
      if (Unk2700MAPJLIDACPN != other.Unk2700MAPJLIDACPN) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (unk2700IFNLJDCJJED_ != null) hash ^= Unk2700IFNLJDCJJED.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (Unk2700MAPJLIDACPN != 0) hash ^= Unk2700MAPJLIDACPN.GetHashCode();
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
      if (Unk2700MAPJLIDACPN != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Unk2700MAPJLIDACPN);
      }
      if (unk2700IFNLJDCJJED_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Unk2700IFNLJDCJJED);
      }
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(Retcode);
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
      if (Unk2700MAPJLIDACPN != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Unk2700MAPJLIDACPN);
      }
      if (unk2700IFNLJDCJJED_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Unk2700IFNLJDCJJED);
      }
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(Retcode);
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
      if (unk2700IFNLJDCJJED_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unk2700IFNLJDCJJED);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (Unk2700MAPJLIDACPN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700MAPJLIDACPN);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_NNMDBDNIMHN_ServerRsp other) {
      if (other == null) {
        return;
      }
      if (other.unk2700IFNLJDCJJED_ != null) {
        if (unk2700IFNLJDCJJED_ == null) {
          Unk2700IFNLJDCJJED = new global::Weedwacker.Shared.Network.Proto.Unk2700_KPNPJPPHOKA();
        }
        Unk2700IFNLJDCJJED.MergeFrom(other.Unk2700IFNLJDCJJED);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.Unk2700MAPJLIDACPN != 0) {
        Unk2700MAPJLIDACPN = other.Unk2700MAPJLIDACPN;
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
            Unk2700MAPJLIDACPN = input.ReadUInt32();
            break;
          }
          case 58: {
            if (unk2700IFNLJDCJJED_ == null) {
              Unk2700IFNLJDCJJED = new global::Weedwacker.Shared.Network.Proto.Unk2700_KPNPJPPHOKA();
            }
            input.ReadMessage(Unk2700IFNLJDCJJED);
            break;
          }
          case 88: {
            Retcode = input.ReadInt32();
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
            Unk2700MAPJLIDACPN = input.ReadUInt32();
            break;
          }
          case 58: {
            if (unk2700IFNLJDCJJED_ == null) {
              Unk2700IFNLJDCJJED = new global::Weedwacker.Shared.Network.Proto.Unk2700_KPNPJPPHOKA();
            }
            input.ReadMessage(Unk2700IFNLJDCJJED);
            break;
          }
          case 88: {
            Retcode = input.ReadInt32();
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
