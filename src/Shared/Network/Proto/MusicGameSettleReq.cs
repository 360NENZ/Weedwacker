// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MusicGameSettleReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from MusicGameSettleReq.proto</summary>
  public static partial class MusicGameSettleReqReflection {

    #region Descriptor
    /// <summary>File descriptor for MusicGameSettleReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MusicGameSettleReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhNdXNpY0dhbWVTZXR0bGVSZXEucHJvdG8i5AMKEk11c2ljR2FtZVNldHRs",
            "ZVJlcRIcChNVbmsyNzAwX0dEUEtPQU5FREVCGIADIAMoDRIcChNVbmsyNzAw",
            "X05NSEdBRExBTk1NGJsGIAEoDRIbChNVbmsyNzAwX05OSEdPQ0pMS0ZIGAQg",
            "AygNEhsKE1VuazI3MDBfTkNISEVKTkZFQ0cYDyABKA0SDQoFc2NvcmUYCSAB",
            "KA0SGwoTVW5rMjcwMF9DRVBHTUtBSEhDRBgGIAEoBBIbChNVbmsyNzAwX01N",
            "SEhHQUxGSEdBGA0gASgNEhwKE1VuazI3MDBfQ0JMSUpIREZLSEEYpgMgASgI",
            "EhEKCW1heF9jb21ibxgFIAEoDRIcChNVbmsyNzAwX0ZCTEJHUEhNTEFMGKII",
            "IAEoDRIOCgVzcGVlZBiZAyABKAISGwoTVW5rMjcwMF9JT0tQSUtKREVIRxgD",
            "IAEoCBINCgVjb21ibxgBIAEoDRIWCg5tdXNpY19iYXNpY19pZBgHIAEoDRIb",
            "ChNVbmsyNzAwX0RJTUJBQk9HTkVNGAIgASgNEhwKE1VuazI3MDBfSU9NT0hF",
            "S0pKTEoYoQ8gASgNEhMKC2NvcnJlY3RfaGl0GA4gASgNEhwKE1VuazI3MDBf",
            "TEtKTkxESkFHR0wYhQogASgIQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3",
            "b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.MusicGameSettleReq), global::Weedwacker.Shared.Network.Proto.MusicGameSettleReq.Parser, new[]{ "Unk2700GDPKOANEDEB", "Unk2700NMHGADLANMM", "Unk2700NNHGOCJLKFH", "Unk2700NCHHEJNFECG", "Score", "Unk2700CEPGMKAHHCD", "Unk2700MMHHGALFHGA", "Unk2700CBLIJHDFKHA", "MaxCombo", "Unk2700FBLBGPHMLAL", "Speed", "Unk2700IOKPIKJDEHG", "Combo", "MusicBasicId", "Unk2700DIMBABOGNEM", "Unk2700IOMOHEKJJLJ", "CorrectHit", "Unk2700LKJNLDJAGGL" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 8892
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class MusicGameSettleReq : pb::IMessage<MusicGameSettleReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MusicGameSettleReq> _parser = new pb::MessageParser<MusicGameSettleReq>(() => new MusicGameSettleReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MusicGameSettleReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.MusicGameSettleReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MusicGameSettleReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MusicGameSettleReq(MusicGameSettleReq other) : this() {
      unk2700GDPKOANEDEB_ = other.unk2700GDPKOANEDEB_.Clone();
      unk2700NMHGADLANMM_ = other.unk2700NMHGADLANMM_;
      unk2700NNHGOCJLKFH_ = other.unk2700NNHGOCJLKFH_.Clone();
      unk2700NCHHEJNFECG_ = other.unk2700NCHHEJNFECG_;
      score_ = other.score_;
      unk2700CEPGMKAHHCD_ = other.unk2700CEPGMKAHHCD_;
      unk2700MMHHGALFHGA_ = other.unk2700MMHHGALFHGA_;
      unk2700CBLIJHDFKHA_ = other.unk2700CBLIJHDFKHA_;
      maxCombo_ = other.maxCombo_;
      unk2700FBLBGPHMLAL_ = other.unk2700FBLBGPHMLAL_;
      speed_ = other.speed_;
      unk2700IOKPIKJDEHG_ = other.unk2700IOKPIKJDEHG_;
      combo_ = other.combo_;
      musicBasicId_ = other.musicBasicId_;
      unk2700DIMBABOGNEM_ = other.unk2700DIMBABOGNEM_;
      unk2700IOMOHEKJJLJ_ = other.unk2700IOMOHEKJJLJ_;
      correctHit_ = other.correctHit_;
      unk2700LKJNLDJAGGL_ = other.unk2700LKJNLDJAGGL_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MusicGameSettleReq Clone() {
      return new MusicGameSettleReq(this);
    }

    /// <summary>Field number for the "Unk2700_GDPKOANEDEB" field.</summary>
    public const int Unk2700GDPKOANEDEBFieldNumber = 384;
    private static readonly pb::FieldCodec<uint> _repeated_unk2700GDPKOANEDEB_codec
        = pb::FieldCodec.ForUInt32(3074);
    private readonly pbc::RepeatedField<uint> unk2700GDPKOANEDEB_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk2700GDPKOANEDEB {
      get { return unk2700GDPKOANEDEB_; }
    }

    /// <summary>Field number for the "Unk2700_NMHGADLANMM" field.</summary>
    public const int Unk2700NMHGADLANMMFieldNumber = 795;
    private uint unk2700NMHGADLANMM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700NMHGADLANMM {
      get { return unk2700NMHGADLANMM_; }
      set {
        unk2700NMHGADLANMM_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_NNHGOCJLKFH" field.</summary>
    public const int Unk2700NNHGOCJLKFHFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_unk2700NNHGOCJLKFH_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> unk2700NNHGOCJLKFH_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk2700NNHGOCJLKFH {
      get { return unk2700NNHGOCJLKFH_; }
    }

    /// <summary>Field number for the "Unk2700_NCHHEJNFECG" field.</summary>
    public const int Unk2700NCHHEJNFECGFieldNumber = 15;
    private uint unk2700NCHHEJNFECG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700NCHHEJNFECG {
      get { return unk2700NCHHEJNFECG_; }
      set {
        unk2700NCHHEJNFECG_ = value;
      }
    }

    /// <summary>Field number for the "score" field.</summary>
    public const int ScoreFieldNumber = 9;
    private uint score_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Score {
      get { return score_; }
      set {
        score_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_CEPGMKAHHCD" field.</summary>
    public const int Unk2700CEPGMKAHHCDFieldNumber = 6;
    private ulong unk2700CEPGMKAHHCD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Unk2700CEPGMKAHHCD {
      get { return unk2700CEPGMKAHHCD_; }
      set {
        unk2700CEPGMKAHHCD_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_MMHHGALFHGA" field.</summary>
    public const int Unk2700MMHHGALFHGAFieldNumber = 13;
    private uint unk2700MMHHGALFHGA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700MMHHGALFHGA {
      get { return unk2700MMHHGALFHGA_; }
      set {
        unk2700MMHHGALFHGA_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_CBLIJHDFKHA" field.</summary>
    public const int Unk2700CBLIJHDFKHAFieldNumber = 422;
    private bool unk2700CBLIJHDFKHA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk2700CBLIJHDFKHA {
      get { return unk2700CBLIJHDFKHA_; }
      set {
        unk2700CBLIJHDFKHA_ = value;
      }
    }

    /// <summary>Field number for the "max_combo" field.</summary>
    public const int MaxComboFieldNumber = 5;
    private uint maxCombo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxCombo {
      get { return maxCombo_; }
      set {
        maxCombo_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_FBLBGPHMLAL" field.</summary>
    public const int Unk2700FBLBGPHMLALFieldNumber = 1058;
    private uint unk2700FBLBGPHMLAL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700FBLBGPHMLAL {
      get { return unk2700FBLBGPHMLAL_; }
      set {
        unk2700FBLBGPHMLAL_ = value;
      }
    }

    /// <summary>Field number for the "speed" field.</summary>
    public const int SpeedFieldNumber = 409;
    private float speed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Speed {
      get { return speed_; }
      set {
        speed_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_IOKPIKJDEHG" field.</summary>
    public const int Unk2700IOKPIKJDEHGFieldNumber = 3;
    private bool unk2700IOKPIKJDEHG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk2700IOKPIKJDEHG {
      get { return unk2700IOKPIKJDEHG_; }
      set {
        unk2700IOKPIKJDEHG_ = value;
      }
    }

    /// <summary>Field number for the "combo" field.</summary>
    public const int ComboFieldNumber = 1;
    private uint combo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Combo {
      get { return combo_; }
      set {
        combo_ = value;
      }
    }

    /// <summary>Field number for the "music_basic_id" field.</summary>
    public const int MusicBasicIdFieldNumber = 7;
    private uint musicBasicId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MusicBasicId {
      get { return musicBasicId_; }
      set {
        musicBasicId_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_DIMBABOGNEM" field.</summary>
    public const int Unk2700DIMBABOGNEMFieldNumber = 2;
    private uint unk2700DIMBABOGNEM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700DIMBABOGNEM {
      get { return unk2700DIMBABOGNEM_; }
      set {
        unk2700DIMBABOGNEM_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_IOMOHEKJJLJ" field.</summary>
    public const int Unk2700IOMOHEKJJLJFieldNumber = 1953;
    private uint unk2700IOMOHEKJJLJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700IOMOHEKJJLJ {
      get { return unk2700IOMOHEKJJLJ_; }
      set {
        unk2700IOMOHEKJJLJ_ = value;
      }
    }

    /// <summary>Field number for the "correct_hit" field.</summary>
    public const int CorrectHitFieldNumber = 14;
    private uint correctHit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CorrectHit {
      get { return correctHit_; }
      set {
        correctHit_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_LKJNLDJAGGL" field.</summary>
    public const int Unk2700LKJNLDJAGGLFieldNumber = 1285;
    private bool unk2700LKJNLDJAGGL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk2700LKJNLDJAGGL {
      get { return unk2700LKJNLDJAGGL_; }
      set {
        unk2700LKJNLDJAGGL_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MusicGameSettleReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MusicGameSettleReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!unk2700GDPKOANEDEB_.Equals(other.unk2700GDPKOANEDEB_)) return false;
      if (Unk2700NMHGADLANMM != other.Unk2700NMHGADLANMM) return false;
      if(!unk2700NNHGOCJLKFH_.Equals(other.unk2700NNHGOCJLKFH_)) return false;
      if (Unk2700NCHHEJNFECG != other.Unk2700NCHHEJNFECG) return false;
      if (Score != other.Score) return false;
      if (Unk2700CEPGMKAHHCD != other.Unk2700CEPGMKAHHCD) return false;
      if (Unk2700MMHHGALFHGA != other.Unk2700MMHHGALFHGA) return false;
      if (Unk2700CBLIJHDFKHA != other.Unk2700CBLIJHDFKHA) return false;
      if (MaxCombo != other.MaxCombo) return false;
      if (Unk2700FBLBGPHMLAL != other.Unk2700FBLBGPHMLAL) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Speed, other.Speed)) return false;
      if (Unk2700IOKPIKJDEHG != other.Unk2700IOKPIKJDEHG) return false;
      if (Combo != other.Combo) return false;
      if (MusicBasicId != other.MusicBasicId) return false;
      if (Unk2700DIMBABOGNEM != other.Unk2700DIMBABOGNEM) return false;
      if (Unk2700IOMOHEKJJLJ != other.Unk2700IOMOHEKJJLJ) return false;
      if (CorrectHit != other.CorrectHit) return false;
      if (Unk2700LKJNLDJAGGL != other.Unk2700LKJNLDJAGGL) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= unk2700GDPKOANEDEB_.GetHashCode();
      if (Unk2700NMHGADLANMM != 0) hash ^= Unk2700NMHGADLANMM.GetHashCode();
      hash ^= unk2700NNHGOCJLKFH_.GetHashCode();
      if (Unk2700NCHHEJNFECG != 0) hash ^= Unk2700NCHHEJNFECG.GetHashCode();
      if (Score != 0) hash ^= Score.GetHashCode();
      if (Unk2700CEPGMKAHHCD != 0UL) hash ^= Unk2700CEPGMKAHHCD.GetHashCode();
      if (Unk2700MMHHGALFHGA != 0) hash ^= Unk2700MMHHGALFHGA.GetHashCode();
      if (Unk2700CBLIJHDFKHA != false) hash ^= Unk2700CBLIJHDFKHA.GetHashCode();
      if (MaxCombo != 0) hash ^= MaxCombo.GetHashCode();
      if (Unk2700FBLBGPHMLAL != 0) hash ^= Unk2700FBLBGPHMLAL.GetHashCode();
      if (Speed != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Speed);
      if (Unk2700IOKPIKJDEHG != false) hash ^= Unk2700IOKPIKJDEHG.GetHashCode();
      if (Combo != 0) hash ^= Combo.GetHashCode();
      if (MusicBasicId != 0) hash ^= MusicBasicId.GetHashCode();
      if (Unk2700DIMBABOGNEM != 0) hash ^= Unk2700DIMBABOGNEM.GetHashCode();
      if (Unk2700IOMOHEKJJLJ != 0) hash ^= Unk2700IOMOHEKJJLJ.GetHashCode();
      if (CorrectHit != 0) hash ^= CorrectHit.GetHashCode();
      if (Unk2700LKJNLDJAGGL != false) hash ^= Unk2700LKJNLDJAGGL.GetHashCode();
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
      if (Combo != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Combo);
      }
      if (Unk2700DIMBABOGNEM != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Unk2700DIMBABOGNEM);
      }
      if (Unk2700IOKPIKJDEHG != false) {
        output.WriteRawTag(24);
        output.WriteBool(Unk2700IOKPIKJDEHG);
      }
      unk2700NNHGOCJLKFH_.WriteTo(output, _repeated_unk2700NNHGOCJLKFH_codec);
      if (MaxCombo != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(MaxCombo);
      }
      if (Unk2700CEPGMKAHHCD != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(Unk2700CEPGMKAHHCD);
      }
      if (MusicBasicId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(MusicBasicId);
      }
      if (Score != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Score);
      }
      if (Unk2700MMHHGALFHGA != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk2700MMHHGALFHGA);
      }
      if (CorrectHit != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(CorrectHit);
      }
      if (Unk2700NCHHEJNFECG != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Unk2700NCHHEJNFECG);
      }
      unk2700GDPKOANEDEB_.WriteTo(output, _repeated_unk2700GDPKOANEDEB_codec);
      if (Speed != 0F) {
        output.WriteRawTag(205, 25);
        output.WriteFloat(Speed);
      }
      if (Unk2700CBLIJHDFKHA != false) {
        output.WriteRawTag(176, 26);
        output.WriteBool(Unk2700CBLIJHDFKHA);
      }
      if (Unk2700NMHGADLANMM != 0) {
        output.WriteRawTag(216, 49);
        output.WriteUInt32(Unk2700NMHGADLANMM);
      }
      if (Unk2700FBLBGPHMLAL != 0) {
        output.WriteRawTag(144, 66);
        output.WriteUInt32(Unk2700FBLBGPHMLAL);
      }
      if (Unk2700LKJNLDJAGGL != false) {
        output.WriteRawTag(168, 80);
        output.WriteBool(Unk2700LKJNLDJAGGL);
      }
      if (Unk2700IOMOHEKJJLJ != 0) {
        output.WriteRawTag(136, 122);
        output.WriteUInt32(Unk2700IOMOHEKJJLJ);
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
      if (Combo != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Combo);
      }
      if (Unk2700DIMBABOGNEM != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Unk2700DIMBABOGNEM);
      }
      if (Unk2700IOKPIKJDEHG != false) {
        output.WriteRawTag(24);
        output.WriteBool(Unk2700IOKPIKJDEHG);
      }
      unk2700NNHGOCJLKFH_.WriteTo(ref output, _repeated_unk2700NNHGOCJLKFH_codec);
      if (MaxCombo != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(MaxCombo);
      }
      if (Unk2700CEPGMKAHHCD != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(Unk2700CEPGMKAHHCD);
      }
      if (MusicBasicId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(MusicBasicId);
      }
      if (Score != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Score);
      }
      if (Unk2700MMHHGALFHGA != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk2700MMHHGALFHGA);
      }
      if (CorrectHit != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(CorrectHit);
      }
      if (Unk2700NCHHEJNFECG != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Unk2700NCHHEJNFECG);
      }
      unk2700GDPKOANEDEB_.WriteTo(ref output, _repeated_unk2700GDPKOANEDEB_codec);
      if (Speed != 0F) {
        output.WriteRawTag(205, 25);
        output.WriteFloat(Speed);
      }
      if (Unk2700CBLIJHDFKHA != false) {
        output.WriteRawTag(176, 26);
        output.WriteBool(Unk2700CBLIJHDFKHA);
      }
      if (Unk2700NMHGADLANMM != 0) {
        output.WriteRawTag(216, 49);
        output.WriteUInt32(Unk2700NMHGADLANMM);
      }
      if (Unk2700FBLBGPHMLAL != 0) {
        output.WriteRawTag(144, 66);
        output.WriteUInt32(Unk2700FBLBGPHMLAL);
      }
      if (Unk2700LKJNLDJAGGL != false) {
        output.WriteRawTag(168, 80);
        output.WriteBool(Unk2700LKJNLDJAGGL);
      }
      if (Unk2700IOMOHEKJJLJ != 0) {
        output.WriteRawTag(136, 122);
        output.WriteUInt32(Unk2700IOMOHEKJJLJ);
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
      size += unk2700GDPKOANEDEB_.CalculateSize(_repeated_unk2700GDPKOANEDEB_codec);
      if (Unk2700NMHGADLANMM != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700NMHGADLANMM);
      }
      size += unk2700NNHGOCJLKFH_.CalculateSize(_repeated_unk2700NNHGOCJLKFH_codec);
      if (Unk2700NCHHEJNFECG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700NCHHEJNFECG);
      }
      if (Score != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Score);
      }
      if (Unk2700CEPGMKAHHCD != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Unk2700CEPGMKAHHCD);
      }
      if (Unk2700MMHHGALFHGA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700MMHHGALFHGA);
      }
      if (Unk2700CBLIJHDFKHA != false) {
        size += 2 + 1;
      }
      if (MaxCombo != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxCombo);
      }
      if (Unk2700FBLBGPHMLAL != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700FBLBGPHMLAL);
      }
      if (Speed != 0F) {
        size += 2 + 4;
      }
      if (Unk2700IOKPIKJDEHG != false) {
        size += 1 + 1;
      }
      if (Combo != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Combo);
      }
      if (MusicBasicId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MusicBasicId);
      }
      if (Unk2700DIMBABOGNEM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700DIMBABOGNEM);
      }
      if (Unk2700IOMOHEKJJLJ != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700IOMOHEKJJLJ);
      }
      if (CorrectHit != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CorrectHit);
      }
      if (Unk2700LKJNLDJAGGL != false) {
        size += 2 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MusicGameSettleReq other) {
      if (other == null) {
        return;
      }
      unk2700GDPKOANEDEB_.Add(other.unk2700GDPKOANEDEB_);
      if (other.Unk2700NMHGADLANMM != 0) {
        Unk2700NMHGADLANMM = other.Unk2700NMHGADLANMM;
      }
      unk2700NNHGOCJLKFH_.Add(other.unk2700NNHGOCJLKFH_);
      if (other.Unk2700NCHHEJNFECG != 0) {
        Unk2700NCHHEJNFECG = other.Unk2700NCHHEJNFECG;
      }
      if (other.Score != 0) {
        Score = other.Score;
      }
      if (other.Unk2700CEPGMKAHHCD != 0UL) {
        Unk2700CEPGMKAHHCD = other.Unk2700CEPGMKAHHCD;
      }
      if (other.Unk2700MMHHGALFHGA != 0) {
        Unk2700MMHHGALFHGA = other.Unk2700MMHHGALFHGA;
      }
      if (other.Unk2700CBLIJHDFKHA != false) {
        Unk2700CBLIJHDFKHA = other.Unk2700CBLIJHDFKHA;
      }
      if (other.MaxCombo != 0) {
        MaxCombo = other.MaxCombo;
      }
      if (other.Unk2700FBLBGPHMLAL != 0) {
        Unk2700FBLBGPHMLAL = other.Unk2700FBLBGPHMLAL;
      }
      if (other.Speed != 0F) {
        Speed = other.Speed;
      }
      if (other.Unk2700IOKPIKJDEHG != false) {
        Unk2700IOKPIKJDEHG = other.Unk2700IOKPIKJDEHG;
      }
      if (other.Combo != 0) {
        Combo = other.Combo;
      }
      if (other.MusicBasicId != 0) {
        MusicBasicId = other.MusicBasicId;
      }
      if (other.Unk2700DIMBABOGNEM != 0) {
        Unk2700DIMBABOGNEM = other.Unk2700DIMBABOGNEM;
      }
      if (other.Unk2700IOMOHEKJJLJ != 0) {
        Unk2700IOMOHEKJJLJ = other.Unk2700IOMOHEKJJLJ;
      }
      if (other.CorrectHit != 0) {
        CorrectHit = other.CorrectHit;
      }
      if (other.Unk2700LKJNLDJAGGL != false) {
        Unk2700LKJNLDJAGGL = other.Unk2700LKJNLDJAGGL;
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
            Combo = input.ReadUInt32();
            break;
          }
          case 16: {
            Unk2700DIMBABOGNEM = input.ReadUInt32();
            break;
          }
          case 24: {
            Unk2700IOKPIKJDEHG = input.ReadBool();
            break;
          }
          case 34:
          case 32: {
            unk2700NNHGOCJLKFH_.AddEntriesFrom(input, _repeated_unk2700NNHGOCJLKFH_codec);
            break;
          }
          case 40: {
            MaxCombo = input.ReadUInt32();
            break;
          }
          case 48: {
            Unk2700CEPGMKAHHCD = input.ReadUInt64();
            break;
          }
          case 56: {
            MusicBasicId = input.ReadUInt32();
            break;
          }
          case 72: {
            Score = input.ReadUInt32();
            break;
          }
          case 104: {
            Unk2700MMHHGALFHGA = input.ReadUInt32();
            break;
          }
          case 112: {
            CorrectHit = input.ReadUInt32();
            break;
          }
          case 120: {
            Unk2700NCHHEJNFECG = input.ReadUInt32();
            break;
          }
          case 3074:
          case 3072: {
            unk2700GDPKOANEDEB_.AddEntriesFrom(input, _repeated_unk2700GDPKOANEDEB_codec);
            break;
          }
          case 3277: {
            Speed = input.ReadFloat();
            break;
          }
          case 3376: {
            Unk2700CBLIJHDFKHA = input.ReadBool();
            break;
          }
          case 6360: {
            Unk2700NMHGADLANMM = input.ReadUInt32();
            break;
          }
          case 8464: {
            Unk2700FBLBGPHMLAL = input.ReadUInt32();
            break;
          }
          case 10280: {
            Unk2700LKJNLDJAGGL = input.ReadBool();
            break;
          }
          case 15624: {
            Unk2700IOMOHEKJJLJ = input.ReadUInt32();
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
            Combo = input.ReadUInt32();
            break;
          }
          case 16: {
            Unk2700DIMBABOGNEM = input.ReadUInt32();
            break;
          }
          case 24: {
            Unk2700IOKPIKJDEHG = input.ReadBool();
            break;
          }
          case 34:
          case 32: {
            unk2700NNHGOCJLKFH_.AddEntriesFrom(ref input, _repeated_unk2700NNHGOCJLKFH_codec);
            break;
          }
          case 40: {
            MaxCombo = input.ReadUInt32();
            break;
          }
          case 48: {
            Unk2700CEPGMKAHHCD = input.ReadUInt64();
            break;
          }
          case 56: {
            MusicBasicId = input.ReadUInt32();
            break;
          }
          case 72: {
            Score = input.ReadUInt32();
            break;
          }
          case 104: {
            Unk2700MMHHGALFHGA = input.ReadUInt32();
            break;
          }
          case 112: {
            CorrectHit = input.ReadUInt32();
            break;
          }
          case 120: {
            Unk2700NCHHEJNFECG = input.ReadUInt32();
            break;
          }
          case 3074:
          case 3072: {
            unk2700GDPKOANEDEB_.AddEntriesFrom(ref input, _repeated_unk2700GDPKOANEDEB_codec);
            break;
          }
          case 3277: {
            Speed = input.ReadFloat();
            break;
          }
          case 3376: {
            Unk2700CBLIJHDFKHA = input.ReadBool();
            break;
          }
          case 6360: {
            Unk2700NMHGADLANMM = input.ReadUInt32();
            break;
          }
          case 8464: {
            Unk2700FBLBGPHMLAL = input.ReadUInt32();
            break;
          }
          case 10280: {
            Unk2700LKJNLDJAGGL = input.ReadBool();
            break;
          }
          case 15624: {
            Unk2700IOMOHEKJJLJ = input.ReadUInt32();
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
