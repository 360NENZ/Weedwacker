// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SumoSetNoSwitchPunishTimeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from SumoSetNoSwitchPunishTimeNotify.proto</summary>
  public static partial class SumoSetNoSwitchPunishTimeNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for SumoSetNoSwitchPunishTimeNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SumoSetNoSwitchPunishTimeNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVTdW1vU2V0Tm9Td2l0Y2hQdW5pc2hUaW1lTm90aWZ5LnByb3RvGhVTdW1v",
            "RHVuZ2VvblRlYW0ucHJvdG8izAEKH1N1bW9TZXROb1N3aXRjaFB1bmlzaFRp",
            "bWVOb3RpZnkSFgoOY3VyX3RlYW1faW5kZXgYDyABKA0SEAoIc3RhZ2VfaWQY",
            "DSABKA0SKwoRZHVuZ2Vvbl90ZWFtX2xpc3QYCyADKAsyEC5TdW1vRHVuZ2Vv",
            "blRlYW0SHQoVbm9fc3dpdGNoX3B1bmlzaF90aW1lGAIgASgNEh4KFm5leHRf",
            "dmFsaWRfc3dpdGNoX3RpbWUYDiABKA0SEwoLYWN0aXZpdHlfaWQYCSABKA1C",
            "IqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.SumoDungeonTeamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.SumoSetNoSwitchPunishTimeNotify), global::Weedwacker.Shared.Network.Proto.SumoSetNoSwitchPunishTimeNotify.Parser, new[]{ "CurTeamIndex", "StageId", "DungeonTeamList", "NoSwitchPunishTime", "NextValidSwitchTime", "ActivityId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 8935
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class SumoSetNoSwitchPunishTimeNotify : pb::IMessage<SumoSetNoSwitchPunishTimeNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SumoSetNoSwitchPunishTimeNotify> _parser = new pb::MessageParser<SumoSetNoSwitchPunishTimeNotify>(() => new SumoSetNoSwitchPunishTimeNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SumoSetNoSwitchPunishTimeNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.SumoSetNoSwitchPunishTimeNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SumoSetNoSwitchPunishTimeNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SumoSetNoSwitchPunishTimeNotify(SumoSetNoSwitchPunishTimeNotify other) : this() {
      curTeamIndex_ = other.curTeamIndex_;
      stageId_ = other.stageId_;
      dungeonTeamList_ = other.dungeonTeamList_.Clone();
      noSwitchPunishTime_ = other.noSwitchPunishTime_;
      nextValidSwitchTime_ = other.nextValidSwitchTime_;
      activityId_ = other.activityId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SumoSetNoSwitchPunishTimeNotify Clone() {
      return new SumoSetNoSwitchPunishTimeNotify(this);
    }

    /// <summary>Field number for the "cur_team_index" field.</summary>
    public const int CurTeamIndexFieldNumber = 15;
    private uint curTeamIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurTeamIndex {
      get { return curTeamIndex_; }
      set {
        curTeamIndex_ = value;
      }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 13;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_team_list" field.</summary>
    public const int DungeonTeamListFieldNumber = 11;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.SumoDungeonTeam> _repeated_dungeonTeamList_codec
        = pb::FieldCodec.ForMessage(90, global::Weedwacker.Shared.Network.Proto.SumoDungeonTeam.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.SumoDungeonTeam> dungeonTeamList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.SumoDungeonTeam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.SumoDungeonTeam> DungeonTeamList {
      get { return dungeonTeamList_; }
    }

    /// <summary>Field number for the "no_switch_punish_time" field.</summary>
    public const int NoSwitchPunishTimeFieldNumber = 2;
    private uint noSwitchPunishTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NoSwitchPunishTime {
      get { return noSwitchPunishTime_; }
      set {
        noSwitchPunishTime_ = value;
      }
    }

    /// <summary>Field number for the "next_valid_switch_time" field.</summary>
    public const int NextValidSwitchTimeFieldNumber = 14;
    private uint nextValidSwitchTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NextValidSwitchTime {
      get { return nextValidSwitchTime_; }
      set {
        nextValidSwitchTime_ = value;
      }
    }

    /// <summary>Field number for the "activity_id" field.</summary>
    public const int ActivityIdFieldNumber = 9;
    private uint activityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ActivityId {
      get { return activityId_; }
      set {
        activityId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SumoSetNoSwitchPunishTimeNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SumoSetNoSwitchPunishTimeNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CurTeamIndex != other.CurTeamIndex) return false;
      if (StageId != other.StageId) return false;
      if(!dungeonTeamList_.Equals(other.dungeonTeamList_)) return false;
      if (NoSwitchPunishTime != other.NoSwitchPunishTime) return false;
      if (NextValidSwitchTime != other.NextValidSwitchTime) return false;
      if (ActivityId != other.ActivityId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CurTeamIndex != 0) hash ^= CurTeamIndex.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
      hash ^= dungeonTeamList_.GetHashCode();
      if (NoSwitchPunishTime != 0) hash ^= NoSwitchPunishTime.GetHashCode();
      if (NextValidSwitchTime != 0) hash ^= NextValidSwitchTime.GetHashCode();
      if (ActivityId != 0) hash ^= ActivityId.GetHashCode();
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
      if (NoSwitchPunishTime != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(NoSwitchPunishTime);
      }
      if (ActivityId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ActivityId);
      }
      dungeonTeamList_.WriteTo(output, _repeated_dungeonTeamList_codec);
      if (StageId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(StageId);
      }
      if (NextValidSwitchTime != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(NextValidSwitchTime);
      }
      if (CurTeamIndex != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CurTeamIndex);
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
      if (NoSwitchPunishTime != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(NoSwitchPunishTime);
      }
      if (ActivityId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ActivityId);
      }
      dungeonTeamList_.WriteTo(ref output, _repeated_dungeonTeamList_codec);
      if (StageId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(StageId);
      }
      if (NextValidSwitchTime != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(NextValidSwitchTime);
      }
      if (CurTeamIndex != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CurTeamIndex);
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
      if (CurTeamIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurTeamIndex);
      }
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      size += dungeonTeamList_.CalculateSize(_repeated_dungeonTeamList_codec);
      if (NoSwitchPunishTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NoSwitchPunishTime);
      }
      if (NextValidSwitchTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NextValidSwitchTime);
      }
      if (ActivityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ActivityId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SumoSetNoSwitchPunishTimeNotify other) {
      if (other == null) {
        return;
      }
      if (other.CurTeamIndex != 0) {
        CurTeamIndex = other.CurTeamIndex;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      dungeonTeamList_.Add(other.dungeonTeamList_);
      if (other.NoSwitchPunishTime != 0) {
        NoSwitchPunishTime = other.NoSwitchPunishTime;
      }
      if (other.NextValidSwitchTime != 0) {
        NextValidSwitchTime = other.NextValidSwitchTime;
      }
      if (other.ActivityId != 0) {
        ActivityId = other.ActivityId;
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
          case 16: {
            NoSwitchPunishTime = input.ReadUInt32();
            break;
          }
          case 72: {
            ActivityId = input.ReadUInt32();
            break;
          }
          case 90: {
            dungeonTeamList_.AddEntriesFrom(input, _repeated_dungeonTeamList_codec);
            break;
          }
          case 104: {
            StageId = input.ReadUInt32();
            break;
          }
          case 112: {
            NextValidSwitchTime = input.ReadUInt32();
            break;
          }
          case 120: {
            CurTeamIndex = input.ReadUInt32();
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
          case 16: {
            NoSwitchPunishTime = input.ReadUInt32();
            break;
          }
          case 72: {
            ActivityId = input.ReadUInt32();
            break;
          }
          case 90: {
            dungeonTeamList_.AddEntriesFrom(ref input, _repeated_dungeonTeamList_codec);
            break;
          }
          case 104: {
            StageId = input.ReadUInt32();
            break;
          }
          case 112: {
            NextValidSwitchTime = input.ReadUInt32();
            break;
          }
          case 120: {
            CurTeamIndex = input.ReadUInt32();
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
