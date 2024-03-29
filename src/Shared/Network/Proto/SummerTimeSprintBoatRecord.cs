// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SummerTimeSprintBoatRecord.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from SummerTimeSprintBoatRecord.proto</summary>
  public static partial class SummerTimeSprintBoatRecordReflection {

    #region Descriptor
    /// <summary>File descriptor for SummerTimeSprintBoatRecord.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SummerTimeSprintBoatRecordReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBTdW1tZXJUaW1lU3ByaW50Qm9hdFJlY29yZC5wcm90byKDAQoaU3VtbWVy",
            "VGltZVNwcmludEJvYXRSZWNvcmQSEgoKYmVzdF9zY29yZRgDIAEoDRISCgpz",
            "dGFydF90aW1lGA0gASgNEhIKCmlzX3RvdWNoZWQYByABKAgSFwoPd2F0Y2hl",
            "cl9pZF9saXN0GAogAygNEhAKCGdyb3VwX2lkGAIgASgNQiKqAh9XZWVkd2Fj",
            "a2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.SummerTimeSprintBoatRecord), global::Weedwacker.Shared.Network.Proto.SummerTimeSprintBoatRecord.Parser, new[]{ "BestScore", "StartTime", "IsTouched", "WatcherIdList", "GroupId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SummerTimeSprintBoatRecord : pb::IMessage<SummerTimeSprintBoatRecord>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SummerTimeSprintBoatRecord> _parser = new pb::MessageParser<SummerTimeSprintBoatRecord>(() => new SummerTimeSprintBoatRecord());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SummerTimeSprintBoatRecord> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.SummerTimeSprintBoatRecordReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SummerTimeSprintBoatRecord() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SummerTimeSprintBoatRecord(SummerTimeSprintBoatRecord other) : this() {
      bestScore_ = other.bestScore_;
      startTime_ = other.startTime_;
      isTouched_ = other.isTouched_;
      watcherIdList_ = other.watcherIdList_.Clone();
      groupId_ = other.groupId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SummerTimeSprintBoatRecord Clone() {
      return new SummerTimeSprintBoatRecord(this);
    }

    /// <summary>Field number for the "best_score" field.</summary>
    public const int BestScoreFieldNumber = 3;
    private uint bestScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BestScore {
      get { return bestScore_; }
      set {
        bestScore_ = value;
      }
    }

    /// <summary>Field number for the "start_time" field.</summary>
    public const int StartTimeFieldNumber = 13;
    private uint startTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StartTime {
      get { return startTime_; }
      set {
        startTime_ = value;
      }
    }

    /// <summary>Field number for the "is_touched" field.</summary>
    public const int IsTouchedFieldNumber = 7;
    private bool isTouched_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsTouched {
      get { return isTouched_; }
      set {
        isTouched_ = value;
      }
    }

    /// <summary>Field number for the "watcher_id_list" field.</summary>
    public const int WatcherIdListFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_watcherIdList_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> watcherIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> WatcherIdList {
      get { return watcherIdList_; }
    }

    /// <summary>Field number for the "group_id" field.</summary>
    public const int GroupIdFieldNumber = 2;
    private uint groupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GroupId {
      get { return groupId_; }
      set {
        groupId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SummerTimeSprintBoatRecord);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SummerTimeSprintBoatRecord other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BestScore != other.BestScore) return false;
      if (StartTime != other.StartTime) return false;
      if (IsTouched != other.IsTouched) return false;
      if(!watcherIdList_.Equals(other.watcherIdList_)) return false;
      if (GroupId != other.GroupId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BestScore != 0) hash ^= BestScore.GetHashCode();
      if (StartTime != 0) hash ^= StartTime.GetHashCode();
      if (IsTouched != false) hash ^= IsTouched.GetHashCode();
      hash ^= watcherIdList_.GetHashCode();
      if (GroupId != 0) hash ^= GroupId.GetHashCode();
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
      if (GroupId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GroupId);
      }
      if (BestScore != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(BestScore);
      }
      if (IsTouched != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsTouched);
      }
      watcherIdList_.WriteTo(output, _repeated_watcherIdList_codec);
      if (StartTime != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(StartTime);
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
      if (GroupId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GroupId);
      }
      if (BestScore != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(BestScore);
      }
      if (IsTouched != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsTouched);
      }
      watcherIdList_.WriteTo(ref output, _repeated_watcherIdList_codec);
      if (StartTime != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(StartTime);
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
      if (BestScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BestScore);
      }
      if (StartTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StartTime);
      }
      if (IsTouched != false) {
        size += 1 + 1;
      }
      size += watcherIdList_.CalculateSize(_repeated_watcherIdList_codec);
      if (GroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SummerTimeSprintBoatRecord other) {
      if (other == null) {
        return;
      }
      if (other.BestScore != 0) {
        BestScore = other.BestScore;
      }
      if (other.StartTime != 0) {
        StartTime = other.StartTime;
      }
      if (other.IsTouched != false) {
        IsTouched = other.IsTouched;
      }
      watcherIdList_.Add(other.watcherIdList_);
      if (other.GroupId != 0) {
        GroupId = other.GroupId;
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
            GroupId = input.ReadUInt32();
            break;
          }
          case 24: {
            BestScore = input.ReadUInt32();
            break;
          }
          case 56: {
            IsTouched = input.ReadBool();
            break;
          }
          case 82:
          case 80: {
            watcherIdList_.AddEntriesFrom(input, _repeated_watcherIdList_codec);
            break;
          }
          case 104: {
            StartTime = input.ReadUInt32();
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
            GroupId = input.ReadUInt32();
            break;
          }
          case 24: {
            BestScore = input.ReadUInt32();
            break;
          }
          case 56: {
            IsTouched = input.ReadBool();
            break;
          }
          case 82:
          case 80: {
            watcherIdList_.AddEntriesFrom(ref input, _repeated_watcherIdList_codec);
            break;
          }
          case 104: {
            StartTime = input.ReadUInt32();
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
