// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk3000_IPAKLDNKDAO.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from Unk3000_IPAKLDNKDAO.proto</summary>
  public static partial class Unk3000IPAKLDNKDAOReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk3000_IPAKLDNKDAO.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk3000IPAKLDNKDAOReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmszMDAwX0lQQUtMRE5LREFPLnByb3RvIjIKE1VuazMwMDBfSVBBS0xE",
            "TktEQU8SGwoTVW5rMzAwMF9GSklKT0lNSk1QRhgIIAEoDUIiqgIfV2VlZHdh",
            "Y2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.Unk3000_IPAKLDNKDAO), global::Weedwacker.Shared.Network.Proto.Unk3000_IPAKLDNKDAO.Parser, new[]{ "Unk3000FJIJOIMJMPF" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 6275
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class Unk3000_IPAKLDNKDAO : pb::IMessage<Unk3000_IPAKLDNKDAO>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk3000_IPAKLDNKDAO> _parser = new pb::MessageParser<Unk3000_IPAKLDNKDAO>(() => new Unk3000_IPAKLDNKDAO());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk3000_IPAKLDNKDAO> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.Unk3000IPAKLDNKDAOReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3000_IPAKLDNKDAO() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3000_IPAKLDNKDAO(Unk3000_IPAKLDNKDAO other) : this() {
      unk3000FJIJOIMJMPF_ = other.unk3000FJIJOIMJMPF_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3000_IPAKLDNKDAO Clone() {
      return new Unk3000_IPAKLDNKDAO(this);
    }

    /// <summary>Field number for the "Unk3000_FJIJOIMJMPF" field.</summary>
    public const int Unk3000FJIJOIMJMPFFieldNumber = 8;
    private uint unk3000FJIJOIMJMPF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3000FJIJOIMJMPF {
      get { return unk3000FJIJOIMJMPF_; }
      set {
        unk3000FJIJOIMJMPF_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk3000_IPAKLDNKDAO);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk3000_IPAKLDNKDAO other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3000FJIJOIMJMPF != other.Unk3000FJIJOIMJMPF) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3000FJIJOIMJMPF != 0) hash ^= Unk3000FJIJOIMJMPF.GetHashCode();
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
      if (Unk3000FJIJOIMJMPF != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Unk3000FJIJOIMJMPF);
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
      if (Unk3000FJIJOIMJMPF != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Unk3000FJIJOIMJMPF);
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
      if (Unk3000FJIJOIMJMPF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3000FJIJOIMJMPF);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk3000_IPAKLDNKDAO other) {
      if (other == null) {
        return;
      }
      if (other.Unk3000FJIJOIMJMPF != 0) {
        Unk3000FJIJOIMJMPF = other.Unk3000FJIJOIMJMPF;
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
          case 64: {
            Unk3000FJIJOIMJMPF = input.ReadUInt32();
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
          case 64: {
            Unk3000FJIJOIMJMPF = input.ReadUInt32();
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
