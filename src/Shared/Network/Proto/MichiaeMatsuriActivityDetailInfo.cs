// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MichiaeMatsuriActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from MichiaeMatsuriActivityDetailInfo.proto</summary>
  public static partial class MichiaeMatsuriActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for MichiaeMatsuriActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MichiaeMatsuriActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZNaWNoaWFlTWF0c3VyaUFjdGl2aXR5RGV0YWlsSW5mby5wcm90bxoZTWlj",
            "aGlhZU1hdHN1cmlTdGFnZS5wcm90bxoZVW5rMjcwMF9IR0ZGR01DT0ROQy5w",
            "cm90bxoZVW5rMjcwMF9OQUZBSU1IRkVGRy5wcm90byLsAQogTWljaGlhZU1h",
            "dHN1cmlBY3Rpdml0eURldGFpbEluZm8SMQoTVW5rMjcwMF9NUE5OTUNQT0xB",
            "TRgGIAMoCzIULlVuazI3MDBfSEdGRkdNQ09ETkMSGwoTVW5rMjcwMF9NQU9B",
            "SEhCQ0tJQRgNIAEoDRIbChNVbmsyNzAwX0JFSEFBSEhHQ0xLGAIgAygNEjEK",
            "E1VuazI3MDBfTEVLSEtOS0hJUE8YCiADKAsyFC5VbmsyNzAwX05BRkFJTUhG",
            "RUZHEigKCnN0YWdlX2xpc3QYDiADKAsyFC5NaWNoaWFlTWF0c3VyaVN0YWdl",
            "QiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.MichiaeMatsuriStageReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.Unk2700HGFFGMCODNCReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.Unk2700NAFAIMHFEFGReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.MichiaeMatsuriActivityDetailInfo), global::Weedwacker.Shared.Network.Proto.MichiaeMatsuriActivityDetailInfo.Parser, new[]{ "Unk2700MPNNMCPOLAM", "Unk2700MAOAHHBCKIA", "Unk2700BEHAAHHGCLK", "Unk2700LEKHKNKHIPO", "StageList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MichiaeMatsuriActivityDetailInfo : pb::IMessage<MichiaeMatsuriActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MichiaeMatsuriActivityDetailInfo> _parser = new pb::MessageParser<MichiaeMatsuriActivityDetailInfo>(() => new MichiaeMatsuriActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MichiaeMatsuriActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.MichiaeMatsuriActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MichiaeMatsuriActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MichiaeMatsuriActivityDetailInfo(MichiaeMatsuriActivityDetailInfo other) : this() {
      unk2700MPNNMCPOLAM_ = other.unk2700MPNNMCPOLAM_.Clone();
      unk2700MAOAHHBCKIA_ = other.unk2700MAOAHHBCKIA_;
      unk2700BEHAAHHGCLK_ = other.unk2700BEHAAHHGCLK_.Clone();
      unk2700LEKHKNKHIPO_ = other.unk2700LEKHKNKHIPO_.Clone();
      stageList_ = other.stageList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MichiaeMatsuriActivityDetailInfo Clone() {
      return new MichiaeMatsuriActivityDetailInfo(this);
    }

    /// <summary>Field number for the "Unk2700_MPNNMCPOLAM" field.</summary>
    public const int Unk2700MPNNMCPOLAMFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.Unk2700_HGFFGMCODNC> _repeated_unk2700MPNNMCPOLAM_codec
        = pb::FieldCodec.ForMessage(50, global::Weedwacker.Shared.Network.Proto.Unk2700_HGFFGMCODNC.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk2700_HGFFGMCODNC> unk2700MPNNMCPOLAM_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk2700_HGFFGMCODNC>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk2700_HGFFGMCODNC> Unk2700MPNNMCPOLAM {
      get { return unk2700MPNNMCPOLAM_; }
    }

    /// <summary>Field number for the "Unk2700_MAOAHHBCKIA" field.</summary>
    public const int Unk2700MAOAHHBCKIAFieldNumber = 13;
    private uint unk2700MAOAHHBCKIA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700MAOAHHBCKIA {
      get { return unk2700MAOAHHBCKIA_; }
      set {
        unk2700MAOAHHBCKIA_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_BEHAAHHGCLK" field.</summary>
    public const int Unk2700BEHAAHHGCLKFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_unk2700BEHAAHHGCLK_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> unk2700BEHAAHHGCLK_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk2700BEHAAHHGCLK {
      get { return unk2700BEHAAHHGCLK_; }
    }

    /// <summary>Field number for the "Unk2700_LEKHKNKHIPO" field.</summary>
    public const int Unk2700LEKHKNKHIPOFieldNumber = 10;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.Unk2700_NAFAIMHFEFG> _repeated_unk2700LEKHKNKHIPO_codec
        = pb::FieldCodec.ForMessage(82, global::Weedwacker.Shared.Network.Proto.Unk2700_NAFAIMHFEFG.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk2700_NAFAIMHFEFG> unk2700LEKHKNKHIPO_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk2700_NAFAIMHFEFG>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk2700_NAFAIMHFEFG> Unk2700LEKHKNKHIPO {
      get { return unk2700LEKHKNKHIPO_; }
    }

    /// <summary>Field number for the "stage_list" field.</summary>
    public const int StageListFieldNumber = 14;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.MichiaeMatsuriStage> _repeated_stageList_codec
        = pb::FieldCodec.ForMessage(114, global::Weedwacker.Shared.Network.Proto.MichiaeMatsuriStage.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.MichiaeMatsuriStage> stageList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.MichiaeMatsuriStage>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.MichiaeMatsuriStage> StageList {
      get { return stageList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MichiaeMatsuriActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MichiaeMatsuriActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!unk2700MPNNMCPOLAM_.Equals(other.unk2700MPNNMCPOLAM_)) return false;
      if (Unk2700MAOAHHBCKIA != other.Unk2700MAOAHHBCKIA) return false;
      if(!unk2700BEHAAHHGCLK_.Equals(other.unk2700BEHAAHHGCLK_)) return false;
      if(!unk2700LEKHKNKHIPO_.Equals(other.unk2700LEKHKNKHIPO_)) return false;
      if(!stageList_.Equals(other.stageList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= unk2700MPNNMCPOLAM_.GetHashCode();
      if (Unk2700MAOAHHBCKIA != 0) hash ^= Unk2700MAOAHHBCKIA.GetHashCode();
      hash ^= unk2700BEHAAHHGCLK_.GetHashCode();
      hash ^= unk2700LEKHKNKHIPO_.GetHashCode();
      hash ^= stageList_.GetHashCode();
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
      unk2700BEHAAHHGCLK_.WriteTo(output, _repeated_unk2700BEHAAHHGCLK_codec);
      unk2700MPNNMCPOLAM_.WriteTo(output, _repeated_unk2700MPNNMCPOLAM_codec);
      unk2700LEKHKNKHIPO_.WriteTo(output, _repeated_unk2700LEKHKNKHIPO_codec);
      if (Unk2700MAOAHHBCKIA != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk2700MAOAHHBCKIA);
      }
      stageList_.WriteTo(output, _repeated_stageList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      unk2700BEHAAHHGCLK_.WriteTo(ref output, _repeated_unk2700BEHAAHHGCLK_codec);
      unk2700MPNNMCPOLAM_.WriteTo(ref output, _repeated_unk2700MPNNMCPOLAM_codec);
      unk2700LEKHKNKHIPO_.WriteTo(ref output, _repeated_unk2700LEKHKNKHIPO_codec);
      if (Unk2700MAOAHHBCKIA != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk2700MAOAHHBCKIA);
      }
      stageList_.WriteTo(ref output, _repeated_stageList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += unk2700MPNNMCPOLAM_.CalculateSize(_repeated_unk2700MPNNMCPOLAM_codec);
      if (Unk2700MAOAHHBCKIA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700MAOAHHBCKIA);
      }
      size += unk2700BEHAAHHGCLK_.CalculateSize(_repeated_unk2700BEHAAHHGCLK_codec);
      size += unk2700LEKHKNKHIPO_.CalculateSize(_repeated_unk2700LEKHKNKHIPO_codec);
      size += stageList_.CalculateSize(_repeated_stageList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MichiaeMatsuriActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      unk2700MPNNMCPOLAM_.Add(other.unk2700MPNNMCPOLAM_);
      if (other.Unk2700MAOAHHBCKIA != 0) {
        Unk2700MAOAHHBCKIA = other.Unk2700MAOAHHBCKIA;
      }
      unk2700BEHAAHHGCLK_.Add(other.unk2700BEHAAHHGCLK_);
      unk2700LEKHKNKHIPO_.Add(other.unk2700LEKHKNKHIPO_);
      stageList_.Add(other.stageList_);
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
          case 18:
          case 16: {
            unk2700BEHAAHHGCLK_.AddEntriesFrom(input, _repeated_unk2700BEHAAHHGCLK_codec);
            break;
          }
          case 50: {
            unk2700MPNNMCPOLAM_.AddEntriesFrom(input, _repeated_unk2700MPNNMCPOLAM_codec);
            break;
          }
          case 82: {
            unk2700LEKHKNKHIPO_.AddEntriesFrom(input, _repeated_unk2700LEKHKNKHIPO_codec);
            break;
          }
          case 104: {
            Unk2700MAOAHHBCKIA = input.ReadUInt32();
            break;
          }
          case 114: {
            stageList_.AddEntriesFrom(input, _repeated_stageList_codec);
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
          case 18:
          case 16: {
            unk2700BEHAAHHGCLK_.AddEntriesFrom(ref input, _repeated_unk2700BEHAAHHGCLK_codec);
            break;
          }
          case 50: {
            unk2700MPNNMCPOLAM_.AddEntriesFrom(ref input, _repeated_unk2700MPNNMCPOLAM_codec);
            break;
          }
          case 82: {
            unk2700LEKHKNKHIPO_.AddEntriesFrom(ref input, _repeated_unk2700LEKHKNKHIPO_codec);
            break;
          }
          case 104: {
            Unk2700MAOAHHBCKIA = input.ReadUInt32();
            break;
          }
          case 114: {
            stageList_.AddEntriesFrom(ref input, _repeated_stageList_codec);
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
