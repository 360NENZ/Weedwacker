// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk3000_ALPEACOMIPG.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from Unk3000_ALPEACOMIPG.proto</summary>
  public static partial class Unk3000ALPEACOMIPGReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk3000_ALPEACOMIPG.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk3000ALPEACOMIPGReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmszMDAwX0FMUEVBQ09NSVBHLnByb3RvGhlVbmszMDAwX0VDR0hKS0FO",
            "UEpLLnByb3RvIoIBChNVbmszMDAwX0FMUEVBQ09NSVBHEjEKE1VuazI3MDBf",
            "UEhLSElQTERPT0EYCiADKAsyFC5VbmszMDAwX0VDR0hKS0FOUEpLEhsKE1Vu",
            "azMwMDBfRkpFTk1NQ0ZNR0QYByABKA0SGwoTVW5rMzAwMF9IS0FCSEZMRE5L",
            "RhgGIAMoDUIaqgIXV2VlZHdhY2tlci5TZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.Unk3000ECGHJKANPJKReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.Unk3000_ALPEACOMIPG), global::Weedwacker.Server.Proto.Unk3000_ALPEACOMIPG.Parser, new[]{ "Unk2700PHKHIPLDOOA", "Unk3000FJENMMCFMGD", "Unk3000HKABHFLDNKF" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Unk3000_ALPEACOMIPG : pb::IMessage<Unk3000_ALPEACOMIPG>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk3000_ALPEACOMIPG> _parser = new pb::MessageParser<Unk3000_ALPEACOMIPG>(() => new Unk3000_ALPEACOMIPG());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk3000_ALPEACOMIPG> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.Unk3000ALPEACOMIPGReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3000_ALPEACOMIPG() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3000_ALPEACOMIPG(Unk3000_ALPEACOMIPG other) : this() {
      unk2700PHKHIPLDOOA_ = other.unk2700PHKHIPLDOOA_.Clone();
      unk3000FJENMMCFMGD_ = other.unk3000FJENMMCFMGD_;
      unk3000HKABHFLDNKF_ = other.unk3000HKABHFLDNKF_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3000_ALPEACOMIPG Clone() {
      return new Unk3000_ALPEACOMIPG(this);
    }

    /// <summary>Field number for the "Unk2700_PHKHIPLDOOA" field.</summary>
    public const int Unk2700PHKHIPLDOOAFieldNumber = 10;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.Unk3000_ECGHJKANPJK> _repeated_unk2700PHKHIPLDOOA_codec
        = pb::FieldCodec.ForMessage(82, global::Weedwacker.Server.Proto.Unk3000_ECGHJKANPJK.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk3000_ECGHJKANPJK> unk2700PHKHIPLDOOA_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk3000_ECGHJKANPJK>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk3000_ECGHJKANPJK> Unk2700PHKHIPLDOOA {
      get { return unk2700PHKHIPLDOOA_; }
    }

    /// <summary>Field number for the "Unk3000_FJENMMCFMGD" field.</summary>
    public const int Unk3000FJENMMCFMGDFieldNumber = 7;
    private uint unk3000FJENMMCFMGD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3000FJENMMCFMGD {
      get { return unk3000FJENMMCFMGD_; }
      set {
        unk3000FJENMMCFMGD_ = value;
      }
    }

    /// <summary>Field number for the "Unk3000_HKABHFLDNKF" field.</summary>
    public const int Unk3000HKABHFLDNKFFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_unk3000HKABHFLDNKF_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> unk3000HKABHFLDNKF_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk3000HKABHFLDNKF {
      get { return unk3000HKABHFLDNKF_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk3000_ALPEACOMIPG);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk3000_ALPEACOMIPG other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!unk2700PHKHIPLDOOA_.Equals(other.unk2700PHKHIPLDOOA_)) return false;
      if (Unk3000FJENMMCFMGD != other.Unk3000FJENMMCFMGD) return false;
      if(!unk3000HKABHFLDNKF_.Equals(other.unk3000HKABHFLDNKF_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= unk2700PHKHIPLDOOA_.GetHashCode();
      if (Unk3000FJENMMCFMGD != 0) hash ^= Unk3000FJENMMCFMGD.GetHashCode();
      hash ^= unk3000HKABHFLDNKF_.GetHashCode();
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
      unk3000HKABHFLDNKF_.WriteTo(output, _repeated_unk3000HKABHFLDNKF_codec);
      if (Unk3000FJENMMCFMGD != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Unk3000FJENMMCFMGD);
      }
      unk2700PHKHIPLDOOA_.WriteTo(output, _repeated_unk2700PHKHIPLDOOA_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      unk3000HKABHFLDNKF_.WriteTo(ref output, _repeated_unk3000HKABHFLDNKF_codec);
      if (Unk3000FJENMMCFMGD != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Unk3000FJENMMCFMGD);
      }
      unk2700PHKHIPLDOOA_.WriteTo(ref output, _repeated_unk2700PHKHIPLDOOA_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += unk2700PHKHIPLDOOA_.CalculateSize(_repeated_unk2700PHKHIPLDOOA_codec);
      if (Unk3000FJENMMCFMGD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3000FJENMMCFMGD);
      }
      size += unk3000HKABHFLDNKF_.CalculateSize(_repeated_unk3000HKABHFLDNKF_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk3000_ALPEACOMIPG other) {
      if (other == null) {
        return;
      }
      unk2700PHKHIPLDOOA_.Add(other.unk2700PHKHIPLDOOA_);
      if (other.Unk3000FJENMMCFMGD != 0) {
        Unk3000FJENMMCFMGD = other.Unk3000FJENMMCFMGD;
      }
      unk3000HKABHFLDNKF_.Add(other.unk3000HKABHFLDNKF_);
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
          case 50:
          case 48: {
            unk3000HKABHFLDNKF_.AddEntriesFrom(input, _repeated_unk3000HKABHFLDNKF_codec);
            break;
          }
          case 56: {
            Unk3000FJENMMCFMGD = input.ReadUInt32();
            break;
          }
          case 82: {
            unk2700PHKHIPLDOOA_.AddEntriesFrom(input, _repeated_unk2700PHKHIPLDOOA_codec);
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
          case 50:
          case 48: {
            unk3000HKABHFLDNKF_.AddEntriesFrom(ref input, _repeated_unk3000HKABHFLDNKF_codec);
            break;
          }
          case 56: {
            Unk3000FJENMMCFMGD = input.ReadUInt32();
            break;
          }
          case 82: {
            unk2700PHKHIPLDOOA_.AddEntriesFrom(ref input, _repeated_unk2700PHKHIPLDOOA_codec);
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