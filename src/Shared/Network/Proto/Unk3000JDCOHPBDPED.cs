// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk3000_JDCOHPBDPED.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from Unk3000_JDCOHPBDPED.proto</summary>
  public static partial class Unk3000JDCOHPBDPEDReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk3000_JDCOHPBDPED.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk3000JDCOHPBDPEDReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmszMDAwX0pEQ09IUEJEUEVELnByb3RvGhdDb21wb3VuZFF1ZXVlRGF0",
            "YS5wcm90bxoZVW5rMzAwMF9QS0hQQk9JRExFQS5wcm90byKNAQoTVW5rMzAw",
            "MF9KRENPSFBCRFBFRBIxChNVbmszMDAwX0NOT0FCTk5DUE9MGAYgASgOMhQu",
            "VW5rMzAwMF9QS0hQQk9JRExFQRIyChZjb21wb3VuZF9xdWVfZGF0YV9saXN0",
            "GAEgAygLMhIuQ29tcG91bmRRdWV1ZURhdGESDwoHcmV0Y29kZRgHIAEoBUIi",
            "qgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.CompoundQueueDataReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.Unk3000PKHPBOIDLEAReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.Unk3000_JDCOHPBDPED), global::Weedwacker.Shared.Network.Proto.Unk3000_JDCOHPBDPED.Parser, new[]{ "Unk3000CNOABNNCPOL", "CompoundQueDataList", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 125
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class Unk3000_JDCOHPBDPED : pb::IMessage<Unk3000_JDCOHPBDPED>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk3000_JDCOHPBDPED> _parser = new pb::MessageParser<Unk3000_JDCOHPBDPED>(() => new Unk3000_JDCOHPBDPED());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk3000_JDCOHPBDPED> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.Unk3000JDCOHPBDPEDReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3000_JDCOHPBDPED() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3000_JDCOHPBDPED(Unk3000_JDCOHPBDPED other) : this() {
      unk3000CNOABNNCPOL_ = other.unk3000CNOABNNCPOL_;
      compoundQueDataList_ = other.compoundQueDataList_.Clone();
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3000_JDCOHPBDPED Clone() {
      return new Unk3000_JDCOHPBDPED(this);
    }

    /// <summary>Field number for the "Unk3000_CNOABNNCPOL" field.</summary>
    public const int Unk3000CNOABNNCPOLFieldNumber = 6;
    private global::Weedwacker.Shared.Network.Proto.Unk3000_PKHPBOIDLEA unk3000CNOABNNCPOL_ = global::Weedwacker.Shared.Network.Proto.Unk3000_PKHPBOIDLEA.Unk3000Kanmgbljehc;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Unk3000_PKHPBOIDLEA Unk3000CNOABNNCPOL {
      get { return unk3000CNOABNNCPOL_; }
      set {
        unk3000CNOABNNCPOL_ = value;
      }
    }

    /// <summary>Field number for the "compound_que_data_list" field.</summary>
    public const int CompoundQueDataListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.CompoundQueueData> _repeated_compoundQueDataList_codec
        = pb::FieldCodec.ForMessage(10, global::Weedwacker.Shared.Network.Proto.CompoundQueueData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.CompoundQueueData> compoundQueDataList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.CompoundQueueData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.CompoundQueueData> CompoundQueDataList {
      get { return compoundQueDataList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 7;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk3000_JDCOHPBDPED);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk3000_JDCOHPBDPED other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3000CNOABNNCPOL != other.Unk3000CNOABNNCPOL) return false;
      if(!compoundQueDataList_.Equals(other.compoundQueDataList_)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3000CNOABNNCPOL != global::Weedwacker.Shared.Network.Proto.Unk3000_PKHPBOIDLEA.Unk3000Kanmgbljehc) hash ^= Unk3000CNOABNNCPOL.GetHashCode();
      hash ^= compoundQueDataList_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      compoundQueDataList_.WriteTo(output, _repeated_compoundQueDataList_codec);
      if (Unk3000CNOABNNCPOL != global::Weedwacker.Shared.Network.Proto.Unk3000_PKHPBOIDLEA.Unk3000Kanmgbljehc) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Unk3000CNOABNNCPOL);
      }
      if (Retcode != 0) {
        output.WriteRawTag(56);
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
      compoundQueDataList_.WriteTo(ref output, _repeated_compoundQueDataList_codec);
      if (Unk3000CNOABNNCPOL != global::Weedwacker.Shared.Network.Proto.Unk3000_PKHPBOIDLEA.Unk3000Kanmgbljehc) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Unk3000CNOABNNCPOL);
      }
      if (Retcode != 0) {
        output.WriteRawTag(56);
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
      if (Unk3000CNOABNNCPOL != global::Weedwacker.Shared.Network.Proto.Unk3000_PKHPBOIDLEA.Unk3000Kanmgbljehc) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Unk3000CNOABNNCPOL);
      }
      size += compoundQueDataList_.CalculateSize(_repeated_compoundQueDataList_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk3000_JDCOHPBDPED other) {
      if (other == null) {
        return;
      }
      if (other.Unk3000CNOABNNCPOL != global::Weedwacker.Shared.Network.Proto.Unk3000_PKHPBOIDLEA.Unk3000Kanmgbljehc) {
        Unk3000CNOABNNCPOL = other.Unk3000CNOABNNCPOL;
      }
      compoundQueDataList_.Add(other.compoundQueDataList_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
          case 10: {
            compoundQueDataList_.AddEntriesFrom(input, _repeated_compoundQueDataList_codec);
            break;
          }
          case 48: {
            Unk3000CNOABNNCPOL = (global::Weedwacker.Shared.Network.Proto.Unk3000_PKHPBOIDLEA) input.ReadEnum();
            break;
          }
          case 56: {
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
          case 10: {
            compoundQueDataList_.AddEntriesFrom(ref input, _repeated_compoundQueDataList_codec);
            break;
          }
          case 48: {
            Unk3000CNOABNNCPOL = (global::Weedwacker.Shared.Network.Proto.Unk3000_PKHPBOIDLEA) input.ReadEnum();
            break;
          }
          case 56: {
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
