// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DailyTaskDataNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from DailyTaskDataNotify.proto</summary>
  public static partial class DailyTaskDataNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for DailyTaskDataNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DailyTaskDataNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlEYWlseVRhc2tEYXRhTm90aWZ5LnByb3RvImMKE0RhaWx5VGFza0RhdGFO",
            "b3RpZnkSFwoPc2NvcmVfcmV3YXJkX2lkGAsgASgNEhQKDGZpbmlzaGVkX251",
            "bRgEIAEoDRIdChVpc190YWtlbl9zY29yZV9yZXdhcmQYCSABKAhCIqoCH1dl",
            "ZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.DailyTaskDataNotify), global::Weedwacker.Shared.Network.Proto.DailyTaskDataNotify.Parser, new[]{ "ScoreRewardId", "FinishedNum", "IsTakenScoreReward" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 158
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class DailyTaskDataNotify : pb::IMessage<DailyTaskDataNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DailyTaskDataNotify> _parser = new pb::MessageParser<DailyTaskDataNotify>(() => new DailyTaskDataNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DailyTaskDataNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.DailyTaskDataNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DailyTaskDataNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DailyTaskDataNotify(DailyTaskDataNotify other) : this() {
      scoreRewardId_ = other.scoreRewardId_;
      finishedNum_ = other.finishedNum_;
      isTakenScoreReward_ = other.isTakenScoreReward_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DailyTaskDataNotify Clone() {
      return new DailyTaskDataNotify(this);
    }

    /// <summary>Field number for the "score_reward_id" field.</summary>
    public const int ScoreRewardIdFieldNumber = 11;
    private uint scoreRewardId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ScoreRewardId {
      get { return scoreRewardId_; }
      set {
        scoreRewardId_ = value;
      }
    }

    /// <summary>Field number for the "finished_num" field.</summary>
    public const int FinishedNumFieldNumber = 4;
    private uint finishedNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FinishedNum {
      get { return finishedNum_; }
      set {
        finishedNum_ = value;
      }
    }

    /// <summary>Field number for the "is_taken_score_reward" field.</summary>
    public const int IsTakenScoreRewardFieldNumber = 9;
    private bool isTakenScoreReward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsTakenScoreReward {
      get { return isTakenScoreReward_; }
      set {
        isTakenScoreReward_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DailyTaskDataNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DailyTaskDataNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ScoreRewardId != other.ScoreRewardId) return false;
      if (FinishedNum != other.FinishedNum) return false;
      if (IsTakenScoreReward != other.IsTakenScoreReward) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ScoreRewardId != 0) hash ^= ScoreRewardId.GetHashCode();
      if (FinishedNum != 0) hash ^= FinishedNum.GetHashCode();
      if (IsTakenScoreReward != false) hash ^= IsTakenScoreReward.GetHashCode();
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
      if (FinishedNum != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(FinishedNum);
      }
      if (IsTakenScoreReward != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsTakenScoreReward);
      }
      if (ScoreRewardId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ScoreRewardId);
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
      if (FinishedNum != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(FinishedNum);
      }
      if (IsTakenScoreReward != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsTakenScoreReward);
      }
      if (ScoreRewardId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ScoreRewardId);
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
      if (ScoreRewardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ScoreRewardId);
      }
      if (FinishedNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinishedNum);
      }
      if (IsTakenScoreReward != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DailyTaskDataNotify other) {
      if (other == null) {
        return;
      }
      if (other.ScoreRewardId != 0) {
        ScoreRewardId = other.ScoreRewardId;
      }
      if (other.FinishedNum != 0) {
        FinishedNum = other.FinishedNum;
      }
      if (other.IsTakenScoreReward != false) {
        IsTakenScoreReward = other.IsTakenScoreReward;
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
          case 32: {
            FinishedNum = input.ReadUInt32();
            break;
          }
          case 72: {
            IsTakenScoreReward = input.ReadBool();
            break;
          }
          case 88: {
            ScoreRewardId = input.ReadUInt32();
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
            FinishedNum = input.ReadUInt32();
            break;
          }
          case 72: {
            IsTakenScoreReward = input.ReadBool();
            break;
          }
          case 88: {
            ScoreRewardId = input.ReadUInt32();
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
