// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TowerMonthlyCombatRecord.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from TowerMonthlyCombatRecord.proto</summary>
  public static partial class TowerMonthlyCombatRecordReflection {

    #region Descriptor
    /// <summary>File descriptor for TowerMonthlyCombatRecord.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TowerMonthlyCombatRecordReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5Ub3dlck1vbnRobHlDb21iYXRSZWNvcmQucHJvdG8aGlRvd2VyRmlnaHRS",
            "ZWNvcmRQYWlyLnByb3RvIoIDChhUb3dlck1vbnRobHlDb21iYXRSZWNvcmQS",
            "NAoVbW9zdF9raWxsX2F2YXRhcl9wYWlyGA4gASgLMhUuVG93ZXJGaWdodFJl",
            "Y29yZFBhaXISQQoibW9zdF9jYXN0X25vcm1hbF9za2lsbF9hdmF0YXJfcGFp",
            "chgIIAEoCzIVLlRvd2VyRmlnaHRSZWNvcmRQYWlyEjYKF21vc3RfcmV2ZWFs",
            "X2F2YXRhcl9saXN0GAYgAygLMhUuVG93ZXJGaWdodFJlY29yZFBhaXISQQoi",
            "bW9zdF9jYXN0X2VuZXJneV9za2lsbF9hdmF0YXJfcGFpchgEIAEoCzIVLlRv",
            "d2VyRmlnaHRSZWNvcmRQYWlyEjUKFmhpZ2hlc3RfZHBzX2F2YXRyX3BhaXIY",
            "DCABKAsyFS5Ub3dlckZpZ2h0UmVjb3JkUGFpchI7Chxtb3N0X3Rha2VfZGFt",
            "YWdlX2F2YXRhcl9wYWlyGAkgASgLMhUuVG93ZXJGaWdodFJlY29yZFBhaXJC",
            "IqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.TowerFightRecordPairReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.TowerMonthlyCombatRecord), global::Weedwacker.Shared.Network.Proto.TowerMonthlyCombatRecord.Parser, new[]{ "MostKillAvatarPair", "MostCastNormalSkillAvatarPair", "MostRevealAvatarList", "MostCastEnergySkillAvatarPair", "HighestDpsAvatrPair", "MostTakeDamageAvatarPair" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TowerMonthlyCombatRecord : pb::IMessage<TowerMonthlyCombatRecord>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TowerMonthlyCombatRecord> _parser = new pb::MessageParser<TowerMonthlyCombatRecord>(() => new TowerMonthlyCombatRecord());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TowerMonthlyCombatRecord> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.TowerMonthlyCombatRecordReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerMonthlyCombatRecord() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerMonthlyCombatRecord(TowerMonthlyCombatRecord other) : this() {
      mostKillAvatarPair_ = other.mostKillAvatarPair_ != null ? other.mostKillAvatarPair_.Clone() : null;
      mostCastNormalSkillAvatarPair_ = other.mostCastNormalSkillAvatarPair_ != null ? other.mostCastNormalSkillAvatarPair_.Clone() : null;
      mostRevealAvatarList_ = other.mostRevealAvatarList_.Clone();
      mostCastEnergySkillAvatarPair_ = other.mostCastEnergySkillAvatarPair_ != null ? other.mostCastEnergySkillAvatarPair_.Clone() : null;
      highestDpsAvatrPair_ = other.highestDpsAvatrPair_ != null ? other.highestDpsAvatrPair_.Clone() : null;
      mostTakeDamageAvatarPair_ = other.mostTakeDamageAvatarPair_ != null ? other.mostTakeDamageAvatarPair_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerMonthlyCombatRecord Clone() {
      return new TowerMonthlyCombatRecord(this);
    }

    /// <summary>Field number for the "most_kill_avatar_pair" field.</summary>
    public const int MostKillAvatarPairFieldNumber = 14;
    private global::Weedwacker.Shared.Network.Proto.TowerFightRecordPair mostKillAvatarPair_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.TowerFightRecordPair MostKillAvatarPair {
      get { return mostKillAvatarPair_; }
      set {
        mostKillAvatarPair_ = value;
      }
    }

    /// <summary>Field number for the "most_cast_normal_skill_avatar_pair" field.</summary>
    public const int MostCastNormalSkillAvatarPairFieldNumber = 8;
    private global::Weedwacker.Shared.Network.Proto.TowerFightRecordPair mostCastNormalSkillAvatarPair_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.TowerFightRecordPair MostCastNormalSkillAvatarPair {
      get { return mostCastNormalSkillAvatarPair_; }
      set {
        mostCastNormalSkillAvatarPair_ = value;
      }
    }

    /// <summary>Field number for the "most_reveal_avatar_list" field.</summary>
    public const int MostRevealAvatarListFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.TowerFightRecordPair> _repeated_mostRevealAvatarList_codec
        = pb::FieldCodec.ForMessage(50, global::Weedwacker.Shared.Network.Proto.TowerFightRecordPair.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.TowerFightRecordPair> mostRevealAvatarList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.TowerFightRecordPair>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.TowerFightRecordPair> MostRevealAvatarList {
      get { return mostRevealAvatarList_; }
    }

    /// <summary>Field number for the "most_cast_energy_skill_avatar_pair" field.</summary>
    public const int MostCastEnergySkillAvatarPairFieldNumber = 4;
    private global::Weedwacker.Shared.Network.Proto.TowerFightRecordPair mostCastEnergySkillAvatarPair_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.TowerFightRecordPair MostCastEnergySkillAvatarPair {
      get { return mostCastEnergySkillAvatarPair_; }
      set {
        mostCastEnergySkillAvatarPair_ = value;
      }
    }

    /// <summary>Field number for the "highest_dps_avatr_pair" field.</summary>
    public const int HighestDpsAvatrPairFieldNumber = 12;
    private global::Weedwacker.Shared.Network.Proto.TowerFightRecordPair highestDpsAvatrPair_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.TowerFightRecordPair HighestDpsAvatrPair {
      get { return highestDpsAvatrPair_; }
      set {
        highestDpsAvatrPair_ = value;
      }
    }

    /// <summary>Field number for the "most_take_damage_avatar_pair" field.</summary>
    public const int MostTakeDamageAvatarPairFieldNumber = 9;
    private global::Weedwacker.Shared.Network.Proto.TowerFightRecordPair mostTakeDamageAvatarPair_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.TowerFightRecordPair MostTakeDamageAvatarPair {
      get { return mostTakeDamageAvatarPair_; }
      set {
        mostTakeDamageAvatarPair_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TowerMonthlyCombatRecord);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TowerMonthlyCombatRecord other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(MostKillAvatarPair, other.MostKillAvatarPair)) return false;
      if (!object.Equals(MostCastNormalSkillAvatarPair, other.MostCastNormalSkillAvatarPair)) return false;
      if(!mostRevealAvatarList_.Equals(other.mostRevealAvatarList_)) return false;
      if (!object.Equals(MostCastEnergySkillAvatarPair, other.MostCastEnergySkillAvatarPair)) return false;
      if (!object.Equals(HighestDpsAvatrPair, other.HighestDpsAvatrPair)) return false;
      if (!object.Equals(MostTakeDamageAvatarPair, other.MostTakeDamageAvatarPair)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (mostKillAvatarPair_ != null) hash ^= MostKillAvatarPair.GetHashCode();
      if (mostCastNormalSkillAvatarPair_ != null) hash ^= MostCastNormalSkillAvatarPair.GetHashCode();
      hash ^= mostRevealAvatarList_.GetHashCode();
      if (mostCastEnergySkillAvatarPair_ != null) hash ^= MostCastEnergySkillAvatarPair.GetHashCode();
      if (highestDpsAvatrPair_ != null) hash ^= HighestDpsAvatrPair.GetHashCode();
      if (mostTakeDamageAvatarPair_ != null) hash ^= MostTakeDamageAvatarPair.GetHashCode();
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
      if (mostCastEnergySkillAvatarPair_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(MostCastEnergySkillAvatarPair);
      }
      mostRevealAvatarList_.WriteTo(output, _repeated_mostRevealAvatarList_codec);
      if (mostCastNormalSkillAvatarPair_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(MostCastNormalSkillAvatarPair);
      }
      if (mostTakeDamageAvatarPair_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(MostTakeDamageAvatarPair);
      }
      if (highestDpsAvatrPair_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(HighestDpsAvatrPair);
      }
      if (mostKillAvatarPair_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(MostKillAvatarPair);
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
      if (mostCastEnergySkillAvatarPair_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(MostCastEnergySkillAvatarPair);
      }
      mostRevealAvatarList_.WriteTo(ref output, _repeated_mostRevealAvatarList_codec);
      if (mostCastNormalSkillAvatarPair_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(MostCastNormalSkillAvatarPair);
      }
      if (mostTakeDamageAvatarPair_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(MostTakeDamageAvatarPair);
      }
      if (highestDpsAvatrPair_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(HighestDpsAvatrPair);
      }
      if (mostKillAvatarPair_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(MostKillAvatarPair);
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
      if (mostKillAvatarPair_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MostKillAvatarPair);
      }
      if (mostCastNormalSkillAvatarPair_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MostCastNormalSkillAvatarPair);
      }
      size += mostRevealAvatarList_.CalculateSize(_repeated_mostRevealAvatarList_codec);
      if (mostCastEnergySkillAvatarPair_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MostCastEnergySkillAvatarPair);
      }
      if (highestDpsAvatrPair_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HighestDpsAvatrPair);
      }
      if (mostTakeDamageAvatarPair_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MostTakeDamageAvatarPair);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TowerMonthlyCombatRecord other) {
      if (other == null) {
        return;
      }
      if (other.mostKillAvatarPair_ != null) {
        if (mostKillAvatarPair_ == null) {
          MostKillAvatarPair = new global::Weedwacker.Shared.Network.Proto.TowerFightRecordPair();
        }
        MostKillAvatarPair.MergeFrom(other.MostKillAvatarPair);
      }
      if (other.mostCastNormalSkillAvatarPair_ != null) {
        if (mostCastNormalSkillAvatarPair_ == null) {
          MostCastNormalSkillAvatarPair = new global::Weedwacker.Shared.Network.Proto.TowerFightRecordPair();
        }
        MostCastNormalSkillAvatarPair.MergeFrom(other.MostCastNormalSkillAvatarPair);
      }
      mostRevealAvatarList_.Add(other.mostRevealAvatarList_);
      if (other.mostCastEnergySkillAvatarPair_ != null) {
        if (mostCastEnergySkillAvatarPair_ == null) {
          MostCastEnergySkillAvatarPair = new global::Weedwacker.Shared.Network.Proto.TowerFightRecordPair();
        }
        MostCastEnergySkillAvatarPair.MergeFrom(other.MostCastEnergySkillAvatarPair);
      }
      if (other.highestDpsAvatrPair_ != null) {
        if (highestDpsAvatrPair_ == null) {
          HighestDpsAvatrPair = new global::Weedwacker.Shared.Network.Proto.TowerFightRecordPair();
        }
        HighestDpsAvatrPair.MergeFrom(other.HighestDpsAvatrPair);
      }
      if (other.mostTakeDamageAvatarPair_ != null) {
        if (mostTakeDamageAvatarPair_ == null) {
          MostTakeDamageAvatarPair = new global::Weedwacker.Shared.Network.Proto.TowerFightRecordPair();
        }
        MostTakeDamageAvatarPair.MergeFrom(other.MostTakeDamageAvatarPair);
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
          case 34: {
            if (mostCastEnergySkillAvatarPair_ == null) {
              MostCastEnergySkillAvatarPair = new global::Weedwacker.Shared.Network.Proto.TowerFightRecordPair();
            }
            input.ReadMessage(MostCastEnergySkillAvatarPair);
            break;
          }
          case 50: {
            mostRevealAvatarList_.AddEntriesFrom(input, _repeated_mostRevealAvatarList_codec);
            break;
          }
          case 66: {
            if (mostCastNormalSkillAvatarPair_ == null) {
              MostCastNormalSkillAvatarPair = new global::Weedwacker.Shared.Network.Proto.TowerFightRecordPair();
            }
            input.ReadMessage(MostCastNormalSkillAvatarPair);
            break;
          }
          case 74: {
            if (mostTakeDamageAvatarPair_ == null) {
              MostTakeDamageAvatarPair = new global::Weedwacker.Shared.Network.Proto.TowerFightRecordPair();
            }
            input.ReadMessage(MostTakeDamageAvatarPair);
            break;
          }
          case 98: {
            if (highestDpsAvatrPair_ == null) {
              HighestDpsAvatrPair = new global::Weedwacker.Shared.Network.Proto.TowerFightRecordPair();
            }
            input.ReadMessage(HighestDpsAvatrPair);
            break;
          }
          case 114: {
            if (mostKillAvatarPair_ == null) {
              MostKillAvatarPair = new global::Weedwacker.Shared.Network.Proto.TowerFightRecordPair();
            }
            input.ReadMessage(MostKillAvatarPair);
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
          case 34: {
            if (mostCastEnergySkillAvatarPair_ == null) {
              MostCastEnergySkillAvatarPair = new global::Weedwacker.Shared.Network.Proto.TowerFightRecordPair();
            }
            input.ReadMessage(MostCastEnergySkillAvatarPair);
            break;
          }
          case 50: {
            mostRevealAvatarList_.AddEntriesFrom(ref input, _repeated_mostRevealAvatarList_codec);
            break;
          }
          case 66: {
            if (mostCastNormalSkillAvatarPair_ == null) {
              MostCastNormalSkillAvatarPair = new global::Weedwacker.Shared.Network.Proto.TowerFightRecordPair();
            }
            input.ReadMessage(MostCastNormalSkillAvatarPair);
            break;
          }
          case 74: {
            if (mostTakeDamageAvatarPair_ == null) {
              MostTakeDamageAvatarPair = new global::Weedwacker.Shared.Network.Proto.TowerFightRecordPair();
            }
            input.ReadMessage(MostTakeDamageAvatarPair);
            break;
          }
          case 98: {
            if (highestDpsAvatrPair_ == null) {
              HighestDpsAvatrPair = new global::Weedwacker.Shared.Network.Proto.TowerFightRecordPair();
            }
            input.ReadMessage(HighestDpsAvatrPair);
            break;
          }
          case 114: {
            if (mostKillAvatarPair_ == null) {
              MostKillAvatarPair = new global::Weedwacker.Shared.Network.Proto.TowerFightRecordPair();
            }
            input.ReadMessage(MostKillAvatarPair);
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
