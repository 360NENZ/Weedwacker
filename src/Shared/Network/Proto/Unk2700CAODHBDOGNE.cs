// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_CAODHBDOGNE.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_CAODHBDOGNE.proto</summary>
  public static partial class Unk2700CAODHBDOGNEReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_CAODHBDOGNE.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700CAODHBDOGNEReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmsyNzAwX0NBT0RIQkRPR05FLnByb3RvGhlVbmsyNzAwX0JKSk9NUERM",
            "TkFMLnByb3RvIpICChNVbmsyNzAwX0NBT0RIQkRPR05FEhAKCHN0YWdlX2lk",
            "GAwgASgNEhsKE1VuazI3MDBfSElNSklDRU5HQ0MYDyADKA0SDAoEdGltZRgE",
            "IAEoDRIbChNVbmsyNzAwX0NPT0NFT09NTUtDGAUgASgNEhsKE1VuazI3MDBf",
            "UFBFQk9LQkNQTEUYBiABKA0SDAoEY29pbhgLIAEoDRISCgpkaWZmaWN1bHR5",
            "GAggASgNEhIKCmR1bmdlb25faWQYDiABKA0SMQoTVW5rMjcwMF9BQUdCSUZI",
            "Tk5QUBgHIAMoCzIULlVuazI3MDBfQkpKT01QRExOQUwSGwoTVW5rMjcwMF9B",
            "TE1PQU1NTk5HUBgKIAMoDUIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29y",
            "ay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.Unk2700BJJOMPDLNALReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.Unk2700_CAODHBDOGNE), global::Weedwacker.Shared.Network.Proto.Unk2700_CAODHBDOGNE.Parser, new[]{ "StageId", "Unk2700HIMJICENGCC", "Time", "Unk2700COOCEOOMMKC", "Unk2700PPEBOKBCPLE", "Coin", "Difficulty", "DungeonId", "Unk2700AAGBIFHNNPP", "Unk2700ALMOAMMNNGP" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 8597
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class Unk2700_CAODHBDOGNE : pb::IMessage<Unk2700_CAODHBDOGNE>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_CAODHBDOGNE> _parser = new pb::MessageParser<Unk2700_CAODHBDOGNE>(() => new Unk2700_CAODHBDOGNE());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_CAODHBDOGNE> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.Unk2700CAODHBDOGNEReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_CAODHBDOGNE() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_CAODHBDOGNE(Unk2700_CAODHBDOGNE other) : this() {
      stageId_ = other.stageId_;
      unk2700HIMJICENGCC_ = other.unk2700HIMJICENGCC_.Clone();
      time_ = other.time_;
      unk2700COOCEOOMMKC_ = other.unk2700COOCEOOMMKC_;
      unk2700PPEBOKBCPLE_ = other.unk2700PPEBOKBCPLE_;
      coin_ = other.coin_;
      difficulty_ = other.difficulty_;
      dungeonId_ = other.dungeonId_;
      unk2700AAGBIFHNNPP_ = other.unk2700AAGBIFHNNPP_.Clone();
      unk2700ALMOAMMNNGP_ = other.unk2700ALMOAMMNNGP_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_CAODHBDOGNE Clone() {
      return new Unk2700_CAODHBDOGNE(this);
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 12;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_HIMJICENGCC" field.</summary>
    public const int Unk2700HIMJICENGCCFieldNumber = 15;
    private static readonly pb::FieldCodec<uint> _repeated_unk2700HIMJICENGCC_codec
        = pb::FieldCodec.ForUInt32(122);
    private readonly pbc::RepeatedField<uint> unk2700HIMJICENGCC_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk2700HIMJICENGCC {
      get { return unk2700HIMJICENGCC_; }
    }

    /// <summary>Field number for the "time" field.</summary>
    public const int TimeFieldNumber = 4;
    private uint time_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_COOCEOOMMKC" field.</summary>
    public const int Unk2700COOCEOOMMKCFieldNumber = 5;
    private uint unk2700COOCEOOMMKC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700COOCEOOMMKC {
      get { return unk2700COOCEOOMMKC_; }
      set {
        unk2700COOCEOOMMKC_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_PPEBOKBCPLE" field.</summary>
    public const int Unk2700PPEBOKBCPLEFieldNumber = 6;
    private uint unk2700PPEBOKBCPLE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700PPEBOKBCPLE {
      get { return unk2700PPEBOKBCPLE_; }
      set {
        unk2700PPEBOKBCPLE_ = value;
      }
    }

    /// <summary>Field number for the "coin" field.</summary>
    public const int CoinFieldNumber = 11;
    private uint coin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Coin {
      get { return coin_; }
      set {
        coin_ = value;
      }
    }

    /// <summary>Field number for the "difficulty" field.</summary>
    public const int DifficultyFieldNumber = 8;
    private uint difficulty_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Difficulty {
      get { return difficulty_; }
      set {
        difficulty_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_id" field.</summary>
    public const int DungeonIdFieldNumber = 14;
    private uint dungeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DungeonId {
      get { return dungeonId_; }
      set {
        dungeonId_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_AAGBIFHNNPP" field.</summary>
    public const int Unk2700AAGBIFHNNPPFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.Unk2700_BJJOMPDLNAL> _repeated_unk2700AAGBIFHNNPP_codec
        = pb::FieldCodec.ForMessage(58, global::Weedwacker.Shared.Network.Proto.Unk2700_BJJOMPDLNAL.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk2700_BJJOMPDLNAL> unk2700AAGBIFHNNPP_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk2700_BJJOMPDLNAL>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk2700_BJJOMPDLNAL> Unk2700AAGBIFHNNPP {
      get { return unk2700AAGBIFHNNPP_; }
    }

    /// <summary>Field number for the "Unk2700_ALMOAMMNNGP" field.</summary>
    public const int Unk2700ALMOAMMNNGPFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_unk2700ALMOAMMNNGP_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> unk2700ALMOAMMNNGP_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk2700ALMOAMMNNGP {
      get { return unk2700ALMOAMMNNGP_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_CAODHBDOGNE);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_CAODHBDOGNE other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StageId != other.StageId) return false;
      if(!unk2700HIMJICENGCC_.Equals(other.unk2700HIMJICENGCC_)) return false;
      if (Time != other.Time) return false;
      if (Unk2700COOCEOOMMKC != other.Unk2700COOCEOOMMKC) return false;
      if (Unk2700PPEBOKBCPLE != other.Unk2700PPEBOKBCPLE) return false;
      if (Coin != other.Coin) return false;
      if (Difficulty != other.Difficulty) return false;
      if (DungeonId != other.DungeonId) return false;
      if(!unk2700AAGBIFHNNPP_.Equals(other.unk2700AAGBIFHNNPP_)) return false;
      if(!unk2700ALMOAMMNNGP_.Equals(other.unk2700ALMOAMMNNGP_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StageId != 0) hash ^= StageId.GetHashCode();
      hash ^= unk2700HIMJICENGCC_.GetHashCode();
      if (Time != 0) hash ^= Time.GetHashCode();
      if (Unk2700COOCEOOMMKC != 0) hash ^= Unk2700COOCEOOMMKC.GetHashCode();
      if (Unk2700PPEBOKBCPLE != 0) hash ^= Unk2700PPEBOKBCPLE.GetHashCode();
      if (Coin != 0) hash ^= Coin.GetHashCode();
      if (Difficulty != 0) hash ^= Difficulty.GetHashCode();
      if (DungeonId != 0) hash ^= DungeonId.GetHashCode();
      hash ^= unk2700AAGBIFHNNPP_.GetHashCode();
      hash ^= unk2700ALMOAMMNNGP_.GetHashCode();
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
      if (Time != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Time);
      }
      if (Unk2700COOCEOOMMKC != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Unk2700COOCEOOMMKC);
      }
      if (Unk2700PPEBOKBCPLE != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Unk2700PPEBOKBCPLE);
      }
      unk2700AAGBIFHNNPP_.WriteTo(output, _repeated_unk2700AAGBIFHNNPP_codec);
      if (Difficulty != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Difficulty);
      }
      unk2700ALMOAMMNNGP_.WriteTo(output, _repeated_unk2700ALMOAMMNNGP_codec);
      if (Coin != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Coin);
      }
      if (StageId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(StageId);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(DungeonId);
      }
      unk2700HIMJICENGCC_.WriteTo(output, _repeated_unk2700HIMJICENGCC_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Time != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Time);
      }
      if (Unk2700COOCEOOMMKC != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Unk2700COOCEOOMMKC);
      }
      if (Unk2700PPEBOKBCPLE != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Unk2700PPEBOKBCPLE);
      }
      unk2700AAGBIFHNNPP_.WriteTo(ref output, _repeated_unk2700AAGBIFHNNPP_codec);
      if (Difficulty != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Difficulty);
      }
      unk2700ALMOAMMNNGP_.WriteTo(ref output, _repeated_unk2700ALMOAMMNNGP_codec);
      if (Coin != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Coin);
      }
      if (StageId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(StageId);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(DungeonId);
      }
      unk2700HIMJICENGCC_.WriteTo(ref output, _repeated_unk2700HIMJICENGCC_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      size += unk2700HIMJICENGCC_.CalculateSize(_repeated_unk2700HIMJICENGCC_codec);
      if (Time != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Time);
      }
      if (Unk2700COOCEOOMMKC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700COOCEOOMMKC);
      }
      if (Unk2700PPEBOKBCPLE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700PPEBOKBCPLE);
      }
      if (Coin != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Coin);
      }
      if (Difficulty != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Difficulty);
      }
      if (DungeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonId);
      }
      size += unk2700AAGBIFHNNPP_.CalculateSize(_repeated_unk2700AAGBIFHNNPP_codec);
      size += unk2700ALMOAMMNNGP_.CalculateSize(_repeated_unk2700ALMOAMMNNGP_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_CAODHBDOGNE other) {
      if (other == null) {
        return;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      unk2700HIMJICENGCC_.Add(other.unk2700HIMJICENGCC_);
      if (other.Time != 0) {
        Time = other.Time;
      }
      if (other.Unk2700COOCEOOMMKC != 0) {
        Unk2700COOCEOOMMKC = other.Unk2700COOCEOOMMKC;
      }
      if (other.Unk2700PPEBOKBCPLE != 0) {
        Unk2700PPEBOKBCPLE = other.Unk2700PPEBOKBCPLE;
      }
      if (other.Coin != 0) {
        Coin = other.Coin;
      }
      if (other.Difficulty != 0) {
        Difficulty = other.Difficulty;
      }
      if (other.DungeonId != 0) {
        DungeonId = other.DungeonId;
      }
      unk2700AAGBIFHNNPP_.Add(other.unk2700AAGBIFHNNPP_);
      unk2700ALMOAMMNNGP_.Add(other.unk2700ALMOAMMNNGP_);
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
          case 32: {
            Time = input.ReadUInt32();
            break;
          }
          case 40: {
            Unk2700COOCEOOMMKC = input.ReadUInt32();
            break;
          }
          case 48: {
            Unk2700PPEBOKBCPLE = input.ReadUInt32();
            break;
          }
          case 58: {
            unk2700AAGBIFHNNPP_.AddEntriesFrom(input, _repeated_unk2700AAGBIFHNNPP_codec);
            break;
          }
          case 64: {
            Difficulty = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            unk2700ALMOAMMNNGP_.AddEntriesFrom(input, _repeated_unk2700ALMOAMMNNGP_codec);
            break;
          }
          case 88: {
            Coin = input.ReadUInt32();
            break;
          }
          case 96: {
            StageId = input.ReadUInt32();
            break;
          }
          case 112: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 122:
          case 120: {
            unk2700HIMJICENGCC_.AddEntriesFrom(input, _repeated_unk2700HIMJICENGCC_codec);
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
          case 32: {
            Time = input.ReadUInt32();
            break;
          }
          case 40: {
            Unk2700COOCEOOMMKC = input.ReadUInt32();
            break;
          }
          case 48: {
            Unk2700PPEBOKBCPLE = input.ReadUInt32();
            break;
          }
          case 58: {
            unk2700AAGBIFHNNPP_.AddEntriesFrom(ref input, _repeated_unk2700AAGBIFHNNPP_codec);
            break;
          }
          case 64: {
            Difficulty = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            unk2700ALMOAMMNNGP_.AddEntriesFrom(ref input, _repeated_unk2700ALMOAMMNNGP_codec);
            break;
          }
          case 88: {
            Coin = input.ReadUInt32();
            break;
          }
          case 96: {
            StageId = input.ReadUInt32();
            break;
          }
          case 112: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 122:
          case 120: {
            unk2700HIMJICENGCC_.AddEntriesFrom(ref input, _repeated_unk2700HIMJICENGCC_codec);
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
