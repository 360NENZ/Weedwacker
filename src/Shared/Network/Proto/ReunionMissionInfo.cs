// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ReunionMissionInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ReunionMissionInfo.proto</summary>
  public static partial class ReunionMissionInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ReunionMissionInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReunionMissionInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhSZXVuaW9uTWlzc2lvbkluZm8ucHJvdG8aGFJldW5pb25XYXRjaGVySW5m",
            "by5wcm90byKAAgoSUmV1bmlvbk1pc3Npb25JbmZvEjEKFGN1cl9kYXlfd2F0",
            "Y2hlcl9saXN0GAMgAygLMhMuUmV1bmlvbldhdGNoZXJJbmZvEhEKCWN1cl9z",
            "Y29yZRgLIAEoDRIXCg9pc190YWtlbl9yZXdhcmQYCCABKAgSHAoUaXNfdGFr",
            "ZW5fcmV3YXJkX2xpc3QYBiADKAgSGQoRbmV4dF9yZWZyZXNoX3RpbWUYBSAB",
            "KA0SEwoLaXNfZmluaXNoZWQYCSABKAgSEgoKbWlzc2lvbl9pZBgMIAEoDRIp",
            "Cgx3YXRjaGVyX2xpc3QYAiADKAsyEy5SZXVuaW9uV2F0Y2hlckluZm9CIqoC",
            "H1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ReunionWatcherInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ReunionMissionInfo), global::Weedwacker.Shared.Network.Proto.ReunionMissionInfo.Parser, new[]{ "CurDayWatcherList", "CurScore", "IsTakenReward", "IsTakenRewardList", "NextRefreshTime", "IsFinished", "MissionId", "WatcherList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReunionMissionInfo : pb::IMessage<ReunionMissionInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ReunionMissionInfo> _parser = new pb::MessageParser<ReunionMissionInfo>(() => new ReunionMissionInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ReunionMissionInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ReunionMissionInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReunionMissionInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReunionMissionInfo(ReunionMissionInfo other) : this() {
      curDayWatcherList_ = other.curDayWatcherList_.Clone();
      curScore_ = other.curScore_;
      isTakenReward_ = other.isTakenReward_;
      isTakenRewardList_ = other.isTakenRewardList_.Clone();
      nextRefreshTime_ = other.nextRefreshTime_;
      isFinished_ = other.isFinished_;
      missionId_ = other.missionId_;
      watcherList_ = other.watcherList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReunionMissionInfo Clone() {
      return new ReunionMissionInfo(this);
    }

    /// <summary>Field number for the "cur_day_watcher_list" field.</summary>
    public const int CurDayWatcherListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ReunionWatcherInfo> _repeated_curDayWatcherList_codec
        = pb::FieldCodec.ForMessage(26, global::Weedwacker.Shared.Network.Proto.ReunionWatcherInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ReunionWatcherInfo> curDayWatcherList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ReunionWatcherInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ReunionWatcherInfo> CurDayWatcherList {
      get { return curDayWatcherList_; }
    }

    /// <summary>Field number for the "cur_score" field.</summary>
    public const int CurScoreFieldNumber = 11;
    private uint curScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurScore {
      get { return curScore_; }
      set {
        curScore_ = value;
      }
    }

    /// <summary>Field number for the "is_taken_reward" field.</summary>
    public const int IsTakenRewardFieldNumber = 8;
    private bool isTakenReward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsTakenReward {
      get { return isTakenReward_; }
      set {
        isTakenReward_ = value;
      }
    }

    /// <summary>Field number for the "is_taken_reward_list" field.</summary>
    public const int IsTakenRewardListFieldNumber = 6;
    private static readonly pb::FieldCodec<bool> _repeated_isTakenRewardList_codec
        = pb::FieldCodec.ForBool(50);
    private readonly pbc::RepeatedField<bool> isTakenRewardList_ = new pbc::RepeatedField<bool>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<bool> IsTakenRewardList {
      get { return isTakenRewardList_; }
    }

    /// <summary>Field number for the "next_refresh_time" field.</summary>
    public const int NextRefreshTimeFieldNumber = 5;
    private uint nextRefreshTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NextRefreshTime {
      get { return nextRefreshTime_; }
      set {
        nextRefreshTime_ = value;
      }
    }

    /// <summary>Field number for the "is_finished" field.</summary>
    public const int IsFinishedFieldNumber = 9;
    private bool isFinished_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFinished {
      get { return isFinished_; }
      set {
        isFinished_ = value;
      }
    }

    /// <summary>Field number for the "mission_id" field.</summary>
    public const int MissionIdFieldNumber = 12;
    private uint missionId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MissionId {
      get { return missionId_; }
      set {
        missionId_ = value;
      }
    }

    /// <summary>Field number for the "watcher_list" field.</summary>
    public const int WatcherListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ReunionWatcherInfo> _repeated_watcherList_codec
        = pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.ReunionWatcherInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ReunionWatcherInfo> watcherList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ReunionWatcherInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ReunionWatcherInfo> WatcherList {
      get { return watcherList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ReunionMissionInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ReunionMissionInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!curDayWatcherList_.Equals(other.curDayWatcherList_)) return false;
      if (CurScore != other.CurScore) return false;
      if (IsTakenReward != other.IsTakenReward) return false;
      if(!isTakenRewardList_.Equals(other.isTakenRewardList_)) return false;
      if (NextRefreshTime != other.NextRefreshTime) return false;
      if (IsFinished != other.IsFinished) return false;
      if (MissionId != other.MissionId) return false;
      if(!watcherList_.Equals(other.watcherList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= curDayWatcherList_.GetHashCode();
      if (CurScore != 0) hash ^= CurScore.GetHashCode();
      if (IsTakenReward != false) hash ^= IsTakenReward.GetHashCode();
      hash ^= isTakenRewardList_.GetHashCode();
      if (NextRefreshTime != 0) hash ^= NextRefreshTime.GetHashCode();
      if (IsFinished != false) hash ^= IsFinished.GetHashCode();
      if (MissionId != 0) hash ^= MissionId.GetHashCode();
      hash ^= watcherList_.GetHashCode();
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
      watcherList_.WriteTo(output, _repeated_watcherList_codec);
      curDayWatcherList_.WriteTo(output, _repeated_curDayWatcherList_codec);
      if (NextRefreshTime != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(NextRefreshTime);
      }
      isTakenRewardList_.WriteTo(output, _repeated_isTakenRewardList_codec);
      if (IsTakenReward != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsTakenReward);
      }
      if (IsFinished != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsFinished);
      }
      if (CurScore != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CurScore);
      }
      if (MissionId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(MissionId);
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
      watcherList_.WriteTo(ref output, _repeated_watcherList_codec);
      curDayWatcherList_.WriteTo(ref output, _repeated_curDayWatcherList_codec);
      if (NextRefreshTime != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(NextRefreshTime);
      }
      isTakenRewardList_.WriteTo(ref output, _repeated_isTakenRewardList_codec);
      if (IsTakenReward != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsTakenReward);
      }
      if (IsFinished != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsFinished);
      }
      if (CurScore != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CurScore);
      }
      if (MissionId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(MissionId);
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
      size += curDayWatcherList_.CalculateSize(_repeated_curDayWatcherList_codec);
      if (CurScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurScore);
      }
      if (IsTakenReward != false) {
        size += 1 + 1;
      }
      size += isTakenRewardList_.CalculateSize(_repeated_isTakenRewardList_codec);
      if (NextRefreshTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NextRefreshTime);
      }
      if (IsFinished != false) {
        size += 1 + 1;
      }
      if (MissionId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MissionId);
      }
      size += watcherList_.CalculateSize(_repeated_watcherList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ReunionMissionInfo other) {
      if (other == null) {
        return;
      }
      curDayWatcherList_.Add(other.curDayWatcherList_);
      if (other.CurScore != 0) {
        CurScore = other.CurScore;
      }
      if (other.IsTakenReward != false) {
        IsTakenReward = other.IsTakenReward;
      }
      isTakenRewardList_.Add(other.isTakenRewardList_);
      if (other.NextRefreshTime != 0) {
        NextRefreshTime = other.NextRefreshTime;
      }
      if (other.IsFinished != false) {
        IsFinished = other.IsFinished;
      }
      if (other.MissionId != 0) {
        MissionId = other.MissionId;
      }
      watcherList_.Add(other.watcherList_);
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
          case 18: {
            watcherList_.AddEntriesFrom(input, _repeated_watcherList_codec);
            break;
          }
          case 26: {
            curDayWatcherList_.AddEntriesFrom(input, _repeated_curDayWatcherList_codec);
            break;
          }
          case 40: {
            NextRefreshTime = input.ReadUInt32();
            break;
          }
          case 50:
          case 48: {
            isTakenRewardList_.AddEntriesFrom(input, _repeated_isTakenRewardList_codec);
            break;
          }
          case 64: {
            IsTakenReward = input.ReadBool();
            break;
          }
          case 72: {
            IsFinished = input.ReadBool();
            break;
          }
          case 88: {
            CurScore = input.ReadUInt32();
            break;
          }
          case 96: {
            MissionId = input.ReadUInt32();
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
          case 18: {
            watcherList_.AddEntriesFrom(ref input, _repeated_watcherList_codec);
            break;
          }
          case 26: {
            curDayWatcherList_.AddEntriesFrom(ref input, _repeated_curDayWatcherList_codec);
            break;
          }
          case 40: {
            NextRefreshTime = input.ReadUInt32();
            break;
          }
          case 50:
          case 48: {
            isTakenRewardList_.AddEntriesFrom(ref input, _repeated_isTakenRewardList_codec);
            break;
          }
          case 64: {
            IsTakenReward = input.ReadBool();
            break;
          }
          case 72: {
            IsFinished = input.ReadBool();
            break;
          }
          case 88: {
            CurScore = input.ReadUInt32();
            break;
          }
          case 96: {
            MissionId = input.ReadUInt32();
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
