// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UgcActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from UgcActivityDetailInfo.proto</summary>
  public static partial class UgcActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for UgcActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UgcActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtVZ2NBY3Rpdml0eURldGFpbEluZm8ucHJvdG8aGVVuazI3MDBfTU1KSk1L",
            "TUhBTkwucHJvdG8ioQEKFVVnY0FjdGl2aXR5RGV0YWlsSW5mbxIbChNVbmsy",
            "NzAwX0dNSUNGQURMQU1DGAogASgIEhsKE1VuazI3MDBfRkREQ01HS0RPQ0MY",
            "DCABKA0SMQoTVW5rMjcwMF9JTENBUEpCQUZPSRgFIAMoCzIULlVuazI3MDBf",
            "TU1KSk1LTUhBTkwSGwoTVW5rMjcwMF9QTk9DRUxDT0ZOSxgLIAEoCEIiqgIf",
            "V2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.Unk2700MMJJMKMHANLReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.UgcActivityDetailInfo), global::Weedwacker.Shared.Network.Proto.UgcActivityDetailInfo.Parser, new[]{ "Unk2700GMICFADLAMC", "Unk2700FDDCMGKDOCC", "Unk2700ILCAPJBAFOI", "Unk2700PNOCELCOFNK" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UgcActivityDetailInfo : pb::IMessage<UgcActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UgcActivityDetailInfo> _parser = new pb::MessageParser<UgcActivityDetailInfo>(() => new UgcActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UgcActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.UgcActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UgcActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UgcActivityDetailInfo(UgcActivityDetailInfo other) : this() {
      unk2700GMICFADLAMC_ = other.unk2700GMICFADLAMC_;
      unk2700FDDCMGKDOCC_ = other.unk2700FDDCMGKDOCC_;
      unk2700ILCAPJBAFOI_ = other.unk2700ILCAPJBAFOI_.Clone();
      unk2700PNOCELCOFNK_ = other.unk2700PNOCELCOFNK_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UgcActivityDetailInfo Clone() {
      return new UgcActivityDetailInfo(this);
    }

    /// <summary>Field number for the "Unk2700_GMICFADLAMC" field.</summary>
    public const int Unk2700GMICFADLAMCFieldNumber = 10;
    private bool unk2700GMICFADLAMC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk2700GMICFADLAMC {
      get { return unk2700GMICFADLAMC_; }
      set {
        unk2700GMICFADLAMC_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_FDDCMGKDOCC" field.</summary>
    public const int Unk2700FDDCMGKDOCCFieldNumber = 12;
    private uint unk2700FDDCMGKDOCC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700FDDCMGKDOCC {
      get { return unk2700FDDCMGKDOCC_; }
      set {
        unk2700FDDCMGKDOCC_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_ILCAPJBAFOI" field.</summary>
    public const int Unk2700ILCAPJBAFOIFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.Unk2700_MMJJMKMHANL> _repeated_unk2700ILCAPJBAFOI_codec
        = pb::FieldCodec.ForMessage(42, global::Weedwacker.Shared.Network.Proto.Unk2700_MMJJMKMHANL.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk2700_MMJJMKMHANL> unk2700ILCAPJBAFOI_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk2700_MMJJMKMHANL>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk2700_MMJJMKMHANL> Unk2700ILCAPJBAFOI {
      get { return unk2700ILCAPJBAFOI_; }
    }

    /// <summary>Field number for the "Unk2700_PNOCELCOFNK" field.</summary>
    public const int Unk2700PNOCELCOFNKFieldNumber = 11;
    private bool unk2700PNOCELCOFNK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk2700PNOCELCOFNK {
      get { return unk2700PNOCELCOFNK_; }
      set {
        unk2700PNOCELCOFNK_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UgcActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UgcActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk2700GMICFADLAMC != other.Unk2700GMICFADLAMC) return false;
      if (Unk2700FDDCMGKDOCC != other.Unk2700FDDCMGKDOCC) return false;
      if(!unk2700ILCAPJBAFOI_.Equals(other.unk2700ILCAPJBAFOI_)) return false;
      if (Unk2700PNOCELCOFNK != other.Unk2700PNOCELCOFNK) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk2700GMICFADLAMC != false) hash ^= Unk2700GMICFADLAMC.GetHashCode();
      if (Unk2700FDDCMGKDOCC != 0) hash ^= Unk2700FDDCMGKDOCC.GetHashCode();
      hash ^= unk2700ILCAPJBAFOI_.GetHashCode();
      if (Unk2700PNOCELCOFNK != false) hash ^= Unk2700PNOCELCOFNK.GetHashCode();
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
      unk2700ILCAPJBAFOI_.WriteTo(output, _repeated_unk2700ILCAPJBAFOI_codec);
      if (Unk2700GMICFADLAMC != false) {
        output.WriteRawTag(80);
        output.WriteBool(Unk2700GMICFADLAMC);
      }
      if (Unk2700PNOCELCOFNK != false) {
        output.WriteRawTag(88);
        output.WriteBool(Unk2700PNOCELCOFNK);
      }
      if (Unk2700FDDCMGKDOCC != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Unk2700FDDCMGKDOCC);
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
      unk2700ILCAPJBAFOI_.WriteTo(ref output, _repeated_unk2700ILCAPJBAFOI_codec);
      if (Unk2700GMICFADLAMC != false) {
        output.WriteRawTag(80);
        output.WriteBool(Unk2700GMICFADLAMC);
      }
      if (Unk2700PNOCELCOFNK != false) {
        output.WriteRawTag(88);
        output.WriteBool(Unk2700PNOCELCOFNK);
      }
      if (Unk2700FDDCMGKDOCC != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Unk2700FDDCMGKDOCC);
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
      if (Unk2700GMICFADLAMC != false) {
        size += 1 + 1;
      }
      if (Unk2700FDDCMGKDOCC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700FDDCMGKDOCC);
      }
      size += unk2700ILCAPJBAFOI_.CalculateSize(_repeated_unk2700ILCAPJBAFOI_codec);
      if (Unk2700PNOCELCOFNK != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UgcActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      if (other.Unk2700GMICFADLAMC != false) {
        Unk2700GMICFADLAMC = other.Unk2700GMICFADLAMC;
      }
      if (other.Unk2700FDDCMGKDOCC != 0) {
        Unk2700FDDCMGKDOCC = other.Unk2700FDDCMGKDOCC;
      }
      unk2700ILCAPJBAFOI_.Add(other.unk2700ILCAPJBAFOI_);
      if (other.Unk2700PNOCELCOFNK != false) {
        Unk2700PNOCELCOFNK = other.Unk2700PNOCELCOFNK;
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
            unk2700ILCAPJBAFOI_.AddEntriesFrom(input, _repeated_unk2700ILCAPJBAFOI_codec);
            break;
          }
          case 80: {
            Unk2700GMICFADLAMC = input.ReadBool();
            break;
          }
          case 88: {
            Unk2700PNOCELCOFNK = input.ReadBool();
            break;
          }
          case 96: {
            Unk2700FDDCMGKDOCC = input.ReadUInt32();
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
            unk2700ILCAPJBAFOI_.AddEntriesFrom(ref input, _repeated_unk2700ILCAPJBAFOI_codec);
            break;
          }
          case 80: {
            Unk2700GMICFADLAMC = input.ReadBool();
            break;
          }
          case 88: {
            Unk2700PNOCELCOFNK = input.ReadBool();
            break;
          }
          case 96: {
            Unk2700FDDCMGKDOCC = input.ReadUInt32();
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
