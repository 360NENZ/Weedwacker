// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BounceConjuringGallerySettleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from BounceConjuringGallerySettleInfo.proto</summary>
  public static partial class BounceConjuringGallerySettleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for BounceConjuringGallerySettleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BounceConjuringGallerySettleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZCb3VuY2VDb25qdXJpbmdHYWxsZXJ5U2V0dGxlSW5mby5wcm90bxobRXho",
            "aWJpdGlvbkRpc3BsYXlJbmZvLnByb3RvGhZPbmxpbmVQbGF5ZXJJbmZvLnBy",
            "b3RvIocDCiBCb3VuY2VDb25qdXJpbmdHYWxsZXJ5U2V0dGxlSW5mbxImCgtw",
            "bGF5ZXJfaW5mbxgOIAEoCzIRLk9ubGluZVBsYXllckluZm8SHwoXZGVzdHJv",
            "eWVkX21hY2hpbmVfY291bnQYBSABKA0SEwoLZmV2ZXJfY291bnQYBiABKA0S",
            "GAoQbm9ybWFsX2hpdF9jb3VudBgEIAEoDRIOCgZkYW1hZ2UYCyABKAISTwoQ",
            "Z2FkZ2V0X2NvdW50X21hcBgPIAMoCzI1LkJvdW5jZUNvbmp1cmluZ0dhbGxl",
            "cnlTZXR0bGVJbmZvLkdhZGdldENvdW50TWFwRW50cnkSDQoFc2NvcmUYDCAB",
            "KA0SGQoRcGVyZmVjdF9oaXRfY291bnQYCCABKA0SKQoJY2FyZF9saXN0GAcg",
            "AygLMhYuRXhoaWJpdGlvbkRpc3BsYXlJbmZvGjUKE0dhZGdldENvdW50TWFw",
            "RW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4AUIiqgIfV2Vl",
            "ZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ExhibitionDisplayInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.OnlinePlayerInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.BounceConjuringGallerySettleInfo), global::Weedwacker.Shared.Network.Proto.BounceConjuringGallerySettleInfo.Parser, new[]{ "PlayerInfo", "DestroyedMachineCount", "FeverCount", "NormalHitCount", "Damage", "GadgetCountMap", "Score", "PerfectHitCount", "CardList" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BounceConjuringGallerySettleInfo : pb::IMessage<BounceConjuringGallerySettleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BounceConjuringGallerySettleInfo> _parser = new pb::MessageParser<BounceConjuringGallerySettleInfo>(() => new BounceConjuringGallerySettleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BounceConjuringGallerySettleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.BounceConjuringGallerySettleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BounceConjuringGallerySettleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BounceConjuringGallerySettleInfo(BounceConjuringGallerySettleInfo other) : this() {
      playerInfo_ = other.playerInfo_ != null ? other.playerInfo_.Clone() : null;
      destroyedMachineCount_ = other.destroyedMachineCount_;
      feverCount_ = other.feverCount_;
      normalHitCount_ = other.normalHitCount_;
      damage_ = other.damage_;
      gadgetCountMap_ = other.gadgetCountMap_.Clone();
      score_ = other.score_;
      perfectHitCount_ = other.perfectHitCount_;
      cardList_ = other.cardList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BounceConjuringGallerySettleInfo Clone() {
      return new BounceConjuringGallerySettleInfo(this);
    }

    /// <summary>Field number for the "player_info" field.</summary>
    public const int PlayerInfoFieldNumber = 14;
    private global::Weedwacker.Shared.Network.Proto.OnlinePlayerInfo playerInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.OnlinePlayerInfo PlayerInfo {
      get { return playerInfo_; }
      set {
        playerInfo_ = value;
      }
    }

    /// <summary>Field number for the "destroyed_machine_count" field.</summary>
    public const int DestroyedMachineCountFieldNumber = 5;
    private uint destroyedMachineCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DestroyedMachineCount {
      get { return destroyedMachineCount_; }
      set {
        destroyedMachineCount_ = value;
      }
    }

    /// <summary>Field number for the "fever_count" field.</summary>
    public const int FeverCountFieldNumber = 6;
    private uint feverCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FeverCount {
      get { return feverCount_; }
      set {
        feverCount_ = value;
      }
    }

    /// <summary>Field number for the "normal_hit_count" field.</summary>
    public const int NormalHitCountFieldNumber = 4;
    private uint normalHitCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NormalHitCount {
      get { return normalHitCount_; }
      set {
        normalHitCount_ = value;
      }
    }

    /// <summary>Field number for the "damage" field.</summary>
    public const int DamageFieldNumber = 11;
    private float damage_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Damage {
      get { return damage_; }
      set {
        damage_ = value;
      }
    }

    /// <summary>Field number for the "gadget_count_map" field.</summary>
    public const int GadgetCountMapFieldNumber = 15;
    private static readonly pbc::MapField<uint, uint>.Codec _map_gadgetCountMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 122);
    private readonly pbc::MapField<uint, uint> gadgetCountMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> GadgetCountMap {
      get { return gadgetCountMap_; }
    }

    /// <summary>Field number for the "score" field.</summary>
    public const int ScoreFieldNumber = 12;
    private uint score_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Score {
      get { return score_; }
      set {
        score_ = value;
      }
    }

    /// <summary>Field number for the "perfect_hit_count" field.</summary>
    public const int PerfectHitCountFieldNumber = 8;
    private uint perfectHitCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PerfectHitCount {
      get { return perfectHitCount_; }
      set {
        perfectHitCount_ = value;
      }
    }

    /// <summary>Field number for the "card_list" field.</summary>
    public const int CardListFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ExhibitionDisplayInfo> _repeated_cardList_codec
        = pb::FieldCodec.ForMessage(58, global::Weedwacker.Shared.Network.Proto.ExhibitionDisplayInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ExhibitionDisplayInfo> cardList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ExhibitionDisplayInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ExhibitionDisplayInfo> CardList {
      get { return cardList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BounceConjuringGallerySettleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BounceConjuringGallerySettleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(PlayerInfo, other.PlayerInfo)) return false;
      if (DestroyedMachineCount != other.DestroyedMachineCount) return false;
      if (FeverCount != other.FeverCount) return false;
      if (NormalHitCount != other.NormalHitCount) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Damage, other.Damage)) return false;
      if (!GadgetCountMap.Equals(other.GadgetCountMap)) return false;
      if (Score != other.Score) return false;
      if (PerfectHitCount != other.PerfectHitCount) return false;
      if(!cardList_.Equals(other.cardList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (playerInfo_ != null) hash ^= PlayerInfo.GetHashCode();
      if (DestroyedMachineCount != 0) hash ^= DestroyedMachineCount.GetHashCode();
      if (FeverCount != 0) hash ^= FeverCount.GetHashCode();
      if (NormalHitCount != 0) hash ^= NormalHitCount.GetHashCode();
      if (Damage != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Damage);
      hash ^= GadgetCountMap.GetHashCode();
      if (Score != 0) hash ^= Score.GetHashCode();
      if (PerfectHitCount != 0) hash ^= PerfectHitCount.GetHashCode();
      hash ^= cardList_.GetHashCode();
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
      if (NormalHitCount != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(NormalHitCount);
      }
      if (DestroyedMachineCount != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(DestroyedMachineCount);
      }
      if (FeverCount != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(FeverCount);
      }
      cardList_.WriteTo(output, _repeated_cardList_codec);
      if (PerfectHitCount != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(PerfectHitCount);
      }
      if (Damage != 0F) {
        output.WriteRawTag(93);
        output.WriteFloat(Damage);
      }
      if (Score != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Score);
      }
      if (playerInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(PlayerInfo);
      }
      gadgetCountMap_.WriteTo(output, _map_gadgetCountMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (NormalHitCount != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(NormalHitCount);
      }
      if (DestroyedMachineCount != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(DestroyedMachineCount);
      }
      if (FeverCount != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(FeverCount);
      }
      cardList_.WriteTo(ref output, _repeated_cardList_codec);
      if (PerfectHitCount != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(PerfectHitCount);
      }
      if (Damage != 0F) {
        output.WriteRawTag(93);
        output.WriteFloat(Damage);
      }
      if (Score != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Score);
      }
      if (playerInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(PlayerInfo);
      }
      gadgetCountMap_.WriteTo(ref output, _map_gadgetCountMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (playerInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerInfo);
      }
      if (DestroyedMachineCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DestroyedMachineCount);
      }
      if (FeverCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FeverCount);
      }
      if (NormalHitCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NormalHitCount);
      }
      if (Damage != 0F) {
        size += 1 + 4;
      }
      size += gadgetCountMap_.CalculateSize(_map_gadgetCountMap_codec);
      if (Score != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Score);
      }
      if (PerfectHitCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PerfectHitCount);
      }
      size += cardList_.CalculateSize(_repeated_cardList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BounceConjuringGallerySettleInfo other) {
      if (other == null) {
        return;
      }
      if (other.playerInfo_ != null) {
        if (playerInfo_ == null) {
          PlayerInfo = new global::Weedwacker.Shared.Network.Proto.OnlinePlayerInfo();
        }
        PlayerInfo.MergeFrom(other.PlayerInfo);
      }
      if (other.DestroyedMachineCount != 0) {
        DestroyedMachineCount = other.DestroyedMachineCount;
      }
      if (other.FeverCount != 0) {
        FeverCount = other.FeverCount;
      }
      if (other.NormalHitCount != 0) {
        NormalHitCount = other.NormalHitCount;
      }
      if (other.Damage != 0F) {
        Damage = other.Damage;
      }
      gadgetCountMap_.Add(other.gadgetCountMap_);
      if (other.Score != 0) {
        Score = other.Score;
      }
      if (other.PerfectHitCount != 0) {
        PerfectHitCount = other.PerfectHitCount;
      }
      cardList_.Add(other.cardList_);
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
            NormalHitCount = input.ReadUInt32();
            break;
          }
          case 40: {
            DestroyedMachineCount = input.ReadUInt32();
            break;
          }
          case 48: {
            FeverCount = input.ReadUInt32();
            break;
          }
          case 58: {
            cardList_.AddEntriesFrom(input, _repeated_cardList_codec);
            break;
          }
          case 64: {
            PerfectHitCount = input.ReadUInt32();
            break;
          }
          case 93: {
            Damage = input.ReadFloat();
            break;
          }
          case 96: {
            Score = input.ReadUInt32();
            break;
          }
          case 114: {
            if (playerInfo_ == null) {
              PlayerInfo = new global::Weedwacker.Shared.Network.Proto.OnlinePlayerInfo();
            }
            input.ReadMessage(PlayerInfo);
            break;
          }
          case 122: {
            gadgetCountMap_.AddEntriesFrom(input, _map_gadgetCountMap_codec);
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
            NormalHitCount = input.ReadUInt32();
            break;
          }
          case 40: {
            DestroyedMachineCount = input.ReadUInt32();
            break;
          }
          case 48: {
            FeverCount = input.ReadUInt32();
            break;
          }
          case 58: {
            cardList_.AddEntriesFrom(ref input, _repeated_cardList_codec);
            break;
          }
          case 64: {
            PerfectHitCount = input.ReadUInt32();
            break;
          }
          case 93: {
            Damage = input.ReadFloat();
            break;
          }
          case 96: {
            Score = input.ReadUInt32();
            break;
          }
          case 114: {
            if (playerInfo_ == null) {
              PlayerInfo = new global::Weedwacker.Shared.Network.Proto.OnlinePlayerInfo();
            }
            input.ReadMessage(PlayerInfo);
            break;
          }
          case 122: {
            gadgetCountMap_.AddEntriesFrom(ref input, _map_gadgetCountMap_codec);
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
